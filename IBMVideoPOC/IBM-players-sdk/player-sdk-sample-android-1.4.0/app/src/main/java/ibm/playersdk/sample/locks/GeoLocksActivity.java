package ibm.playersdk.sample.locks;

import android.content.Context;
import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.UUID;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.util.CustomBufferingListener;
import ibm.playersdk.sample.util.EmptyErrorListener;
import ibm.playersdk.sample.util.PlayerListenerAutoplay;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.UstreamPlayer;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.GEOLOCKED_VIDEO_USA_BLACKLISTED;
import static ibm.playersdk.sample.util.Consts.GEOLOCKED_VIDEO_USA_WHITELISTED;

// An example demonstration of how to handle GeoLocks in the SDK.
// GeoLock is a feature that can be enabled for a specific content on your dashboard.
// Using this you can control which countries (or regions) can or can not access your content.
public class GeoLocksActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(GeoLocksActivity.class);
    private static final String PLAYER_ID_KEY1 = "USTREAM_PLAYER_ID_KEY1";
    private static final String PLAYER_ID_KEY2 = "USTREAM_PLAYER_ID_KEY2";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private UstreamPlayer ustreamPlayer1;
    private UstreamPlayer ustreamPlayer2;
    private String playerId1; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private String playerId2; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView1;
    private PlayerView playerView2;
    private View errorView1;
    private View errorView2;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_geolocks);

        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId1 = savedInstanceState.getString(PLAYER_ID_KEY1, UUID.randomUUID().toString());
            playerId2 = savedInstanceState.getString(PLAYER_ID_KEY2, UUID.randomUUID().toString());
        } else {
            playerId1 = UUID.randomUUID().toString();
            playerId2 = UUID.randomUUID().toString();
        }

        playerView1 = findViewById(R.id.playerview1);
        playerView2 = findViewById(R.id.playerview2);

        //finding the error layout
        errorView1 = findViewById(R.id.geolock_msg_1);
        errorView2 = findViewById(R.id.geolock_msg_2);

        ustreamPlayer1 = ustreamPlayerFactory.createUstreamPlayer(playerId1);
        ustreamPlayer2 = ustreamPlayerFactory.createUstreamPlayer(playerId2);

        // Initialize (and start) both of our player, but with different contents
        if (!ustreamPlayer1.isInitialized()) {
            ustreamPlayer1.initWithContent(GEOLOCKED_VIDEO_USA_BLACKLISTED);
            ustreamPlayer1.play(); // immediately start the playback (optional)
        }

        if (!ustreamPlayer2.isInitialized()) {
            ustreamPlayer2.initWithContent(GEOLOCKED_VIDEO_USA_WHITELISTED);
            ustreamPlayer2.play(); // immediately start the playback (optional)
        }
    }

    @Override
    protected void onStart() {
        super.onStart();
        ustreamPlayer1.setPlayerListener(new PlayerListenerAutoplay(ustreamPlayer1));
        ustreamPlayer2.setPlayerListener(new PlayerListenerAutoplay(ustreamPlayer2));

        ustreamPlayer1.setErrorListener(new ErrorListenerImpl(this, errorView1)); //add the error layout to the custom error listener
        ustreamPlayer2.setErrorListener(new ErrorListenerImpl(this, errorView2)); //add the error layout to the custom error listener

        ustreamPlayer1.setBufferingListener(new CustomBufferingListener(findViewById(R.id.progressBar1)));
        ustreamPlayer2.setBufferingListener(new CustomBufferingListener(findViewById(R.id.progressBar2)));


        ustreamPlayer1.setPlayerView(playerView1);
        ustreamPlayer2.setPlayerView(playerView2);

        ustreamPlayer1.attach();
        ustreamPlayer2.attach();

    }

    @Override
    protected void onStop() {
        ustreamPlayer1.detach();
        ustreamPlayer2.detach();
        super.onStop();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putString(PLAYER_ID_KEY1, playerId1); // Save the player id so it can be restored after a config change.
        outState.putString(PLAYER_ID_KEY2, playerId2); // Save the player id so it can be restored after a config change.
        super.onSaveInstanceState(outState);
    }


    private class ErrorListenerImpl extends EmptyErrorListener {

        private final View errorView;

        public ErrorListenerImpl(Context context, View errorView) {
            super(context);
            this.errorView = errorView;
        }

        @Override
        public void onGeoLock() {
            logger.debug("error: {}", getString(R.string.sample_error_geo_lock_msg));
            errorView.setVisibility(View.VISIBLE);
        }
    }
}
