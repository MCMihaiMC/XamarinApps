package ibm.playersdk.sample.multiaudio;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;
import android.widget.Toast;
import ibm.playersdk.sample.R;
import ibm.playersdk.sample.util.CustomBufferingListener;
import ibm.playersdk.sample.util.EmptyErrorListener;
import ibm.playersdk.sample.util.PlayerListenerAutoplay;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.MediaTrackChangeListener;
import tv.ustream.player.api.UstreamPlayer;
import tv.ustream.player.api.trackselection.MediaFormat;
import tv.ustream.player.api.trackselection.MediaTrack;
import tv.ustream.player.api.trackselection.MediaTrackGroupHolder;
import tv.ustream.player.api.trackselection.MediaTrackSelection;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.MULTI_AUDIO_VIDEO;
import static tv.ustream.player.api.trackselection.MediaTrack.TrackType.Audio;

// This is an example demonstration of multi audio handling in the SDK.
// A LIVE or RECORDED media may have multiple audio tracks in it's stream.
// Audio renderers can have a track (for example a language) set to render, have the renderer disabled or set to it's default value. (Defaults can be set on your dashboard.)
// The basic principles of this sample could be used to handle generic track selection (ie.: video track, video format (bitrate), or text track) also.
// However it is not scope of this sample at the moment.
public class MultiAudioActivity extends AppCompatActivity implements AudioTrackSelectorFragment.AudioTrackSelectorResultListener {

    private static final Logger logger = LoggerFactory.getLogger(MultiAudioActivity.class);
    private static final String PLAYER_ID_KEY = "USTREAM_PLAYER_ID_KEY";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);
    private UstreamPlayer ustreamPlayer;
    private String playerId; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView;
    private List<MediaTrack> trackList = null;
    private MediaTrack selectedTrack;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_multiaudio_basic);

        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId = savedInstanceState.getString(PLAYER_ID_KEY, UUID.randomUUID().toString());
        } else {
            playerId = UUID.randomUUID().toString();
        }

        playerView = findViewById(R.id.playerview);

        ustreamPlayer = ustreamPlayerFactory.createUstreamPlayer(playerId);
        if (!ustreamPlayer.isInitialized()) {
            ustreamPlayer.initWithContent(MULTI_AUDIO_VIDEO);
        }

        findViewById(R.id.audio_button).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showAudioSelectorDialog();
            }
        });
    }

    @Override
    protected void onStart() {
        super.onStart();
        ustreamPlayer.setPlayerListener(new PlayerListenerAutoplay(ustreamPlayer));
        ustreamPlayer.setErrorListener(new EmptyErrorListener(this));
        ustreamPlayer.setPlayerView(playerView);
        ustreamPlayer.setMediaTracksChangeListener(new MediaTrackChangeListenerImpl());
        ustreamPlayer.setBufferingListener(new CustomBufferingListener(findViewById(R.id.progressBar)));
        ustreamPlayer.attach();
    }

    @Override
    protected void onStop() {
        ustreamPlayer.detach();
        super.onStop();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putString(PLAYER_ID_KEY, playerId); // Save the player id so it can be restored after a config change.
        super.onSaveInstanceState(outState);
    }
    public void showAudioSelectorDialog() {
        if(trackList == null) {
            return;
        }
        ArrayList<String> trackListTitles = new ArrayList<>();

        int idx = 0;
        int i = 0;
        trackListTitles.add("None");
        i++;
        trackListTitles.add("Default");
        for(MediaTrack track : trackList) {
            if(track.mediaFormats.size() > 0) {
                i++; // increment i early, because we have the 'None' and 'Default' list item inserted previously
                trackListTitles.add(track.mediaFormats.get(0).formatId);
                if(track.equals(selectedTrack)) {
                    idx = i;
                }
            }
        }
        if(trackListTitles.size() > 0) {
            AudioTrackSelectorFragment.showDialog(getSupportFragmentManager(), trackListTitles, idx);
        } else {
            Toast.makeText(this, "No audio track found in the media", Toast.LENGTH_LONG).show();
        }
    }

    @Override
    public void onAudioTrackSelectorFragmentApply(int idx, String title) {
        if(idx == 0) {
            ustreamPlayer.disableRenderer(Audio);
        } else if (idx == 1) {
            ustreamPlayer.selectDefaultTrack(Audio);
        } else {
            int trackIdx = idx - 2;
            if (trackList.get(trackIdx).mediaFormats.get(0).formatId.equals(title)) {
                MediaTrack selectedAudioTrack = trackList.get(trackIdx);
                if(selectedAudioTrack.trackType != Audio) {
                    logger.error("Audio track type should be: Audio");
                    return;
                }
                ustreamPlayer.selectTrackForRenderer(selectedAudioTrack, null);
            }
        }
    }

    @Override
    public void onAudioTrackSelectorFragmentCancel() {
        // No-Op
    }

    private class MediaTrackChangeListenerImpl implements MediaTrackChangeListener {

        @Override
        public void onMediaTracksChanged(MediaTrackGroupHolder mediaTrackGroups) {
            trackList = new ArrayList<>();
            // Iterate over the list of audio tracks. Each audio track usually corresponds to a language.
            // Build a list of the audio tracks.
            for(MediaTrack track : mediaTrackGroups.audioTracks) {
                // Each audio track should contain a mediaFormat, which can be rendered. Check just to be sure.
                if(track.mediaFormats.size() > 0) {
                    trackList.add(track);
                }
            }
        }

        @Override
        public void onVideoTrackSelectionChanged(MediaTrackSelection trackSelection) {
            // No-Op
        }

        @Override
        public void onAudioTrackSelectionChanged(MediaTrackSelection trackSelection) {
            selectedTrack = trackSelection != null ? trackSelection.trackGroup : null;
        }

        @Override
        public void onTextTrackSelectionChanged(MediaTrackSelection trackSelection) {
            // No-Op
        }

        @Override
        public void onVideoFormatChanged(MediaFormat videoFormat) {
            // No-Op
        }
    }

}
