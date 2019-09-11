package ibm.playersdk.sample.offline;

import android.app.DatePickerDialog;
import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;
import android.widget.DatePicker;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Calendar;
import java.util.UUID;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.util.CustomBufferingListener;
import ibm.playersdk.sample.util.EmptyErrorListener;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.PlayerListener;
import tv.ustream.player.api.UstreamPlayer;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.OFFLINE_CHANNEL;

// This is an example demonstration of how to handle offline (off-air) channels.
// A channel is offline if it is not currently broadcasting (and neither a live playlist is set).
// If a channel is (or goes) offline the player reports this on the onWaitingForContent() callback.
// In this state the player is still connected to the servers and waits for the channel to go live.
// When the channel does go live, the player starts as soon as it can (respecting the previously requested state: ustreamPlayer.play() or ustreamPlayer.pause()).
public class OfflineActivity extends AppCompatActivity implements DatePickerDialog.OnDateSetListener {

    private static final Logger logger = LoggerFactory.getLogger(OfflineActivity.class);
    private static final String PLAYER_ID_KEY = "USTREAM_PLAYER_ID_KEY";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);
    private UstreamPlayer ustreamPlayer;
    private String playerId; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView;
    private View offlinePanel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_offline);

        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId = savedInstanceState.getString(PLAYER_ID_KEY, UUID.randomUUID().toString());
        } else {
            playerId = UUID.randomUUID().toString();
        }

        playerView = findViewById(R.id.playerview);
        offlinePanel = findViewById(R.id.offline_panel);

        ustreamPlayer = ustreamPlayerFactory.createUstreamPlayer(playerId);
        if (!ustreamPlayer.isInitialized()) {
            ustreamPlayer.initWithContent(OFFLINE_CHANNEL);
        }
    }

    @Override
    protected void onResume() {
        ustreamPlayer.setPlayerListener(new PlayerListenerImpl());
        ustreamPlayer.setErrorListener(new EmptyErrorListener(this));
        ustreamPlayer.setPlayerView(playerView);
        ustreamPlayer.attach();
        super.onResume();
    }

    @Override
    protected void onPause() {
        ustreamPlayer.detach();
        super.onPause();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putString(PLAYER_ID_KEY, playerId); // Save the player id so it can be restored after a config change.
        super.onSaveInstanceState(outState);
    }

    @Override
    public void onDateSet(DatePicker datePicker, int year, int monthOfYear, int dayOfMonth) {
        final Calendar calendar = Calendar.getInstance();
        calendar.set(year, monthOfYear, dayOfMonth);
        ustreamPlayer.setBirthDate(calendar);
        ustreamPlayer.play();
    }


    private class PlayerListenerImpl implements PlayerListener {

        @Override
        public void onInitialized() {
            ustreamPlayer.play();
            hideOfflinePanel();
        }

        @Override
        public void onStopped() {
            hideOfflinePanel();
        }

        @Override
        public void onWaitingForContent() {
            showOfflinePanel();
        }

        @Override
        public void onContentReady() {
            logger.debug("ready");
            hideOfflinePanel();
        }

        @Override
        public void onPlaying() {

        }

        @Override
        public void onPaused() {

        }
    }


    void showOfflinePanel() {
        offlinePanel.setVisibility(View.VISIBLE);
    }

    void hideOfflinePanel() {
        offlinePanel.setVisibility(View.GONE);
    }

}
