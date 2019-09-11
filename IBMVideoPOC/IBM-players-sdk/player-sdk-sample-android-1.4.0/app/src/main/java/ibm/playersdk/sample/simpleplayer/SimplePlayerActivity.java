package ibm.playersdk.sample.simpleplayer;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.net.URI;
import java.util.UUID;

import ibm.playersdk.sample.R;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.BufferingListener;
import tv.ustream.player.api.ChatAndSocialStreamData;
import tv.ustream.player.api.ErrorListener;
import tv.ustream.player.api.LogoClickListener;
import tv.ustream.player.api.MetaData;
import tv.ustream.player.api.MetaDataListener;
import tv.ustream.player.api.PlayerListener;
import tv.ustream.player.api.ProgressListener;
import tv.ustream.player.api.UstreamPlayer;
import tv.ustream.player.api.ViewerCountListener;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.LIVE_CHANNEL;

// This is an example demonstration of a barebone player.
// Listeners and a playerView is set, but no other UI is provided, to learn the basics.
public class SimplePlayerActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(SimplePlayerActivity.class);
    private static final String PLAYER_ID_KEY = "USTREAM_PLAYER_ID_KEY";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);
    private UstreamPlayer ustreamPlayer;
    private String playerId; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView;
    private View progressbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_simpleplayer);

        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId = savedInstanceState.getString(PLAYER_ID_KEY, UUID.randomUUID().toString());
        } else {
            playerId = UUID.randomUUID().toString();
        }

        playerView = findViewById(R.id.playerview); // finding the tv.ustream.player.android.PlayerView in the layout
        progressbar = findViewById(R.id.progressBar);

        ustreamPlayer = ustreamPlayerFactory.createUstreamPlayer(playerId); // creating the ustream player. Not initialized yet.
        // ustreamPlayer might be initialized if onCreate is called due to a configuration change.
        if (!ustreamPlayer.isInitialized()) {
            // Initialize with the contentDescriptor (consists of content type (LIVE/RECORDED) and the content ID)
            ustreamPlayer.initWithContent(LIVE_CHANNEL);

            ustreamPlayer.play(); // immediately start the playback (optional)
        }
    }

    @Override
    protected void onStart() {
        super.onStart();
        // adding listeners to the player
        // mandatory
        ustreamPlayer.setPlayerListener(new PlayerListenerImpl());
        ustreamPlayer.setErrorListener(new ErrorListenerImpl());

        // optional
        ustreamPlayer.setProgressListener(new ProgressListenerImpl());
        ustreamPlayer.setViewerCountListener(new ViewerCountListenerImpl());
        ustreamPlayer.setLogoClickListener(new LogoClickListenerImpl());
        ustreamPlayer.setMetaDataListener(new MetaDataListenerImpl());
        ustreamPlayer.setBufferingListener(new BufferingListenerImpl());

        ustreamPlayer.setPlayerView(playerView); // set the surface for a player to render on (optional)

        // listeners and the player view is bound to the persisted Player SDK
        ustreamPlayer.attach();
    }

    @Override
    protected void onStop() {
        // the counterpart of attach(). Unbound the listeners from the SDK.
        ustreamPlayer.detach();
        super.onStop();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putString(PLAYER_ID_KEY, playerId); // Save the player id so it can be restored after a config change.
        super.onSaveInstanceState(outState);
    }

    private class ErrorListenerImpl implements ErrorListener {

        @Override
        public void onNoSuchContent() {
            logger.debug("error: {}", getString(R.string.sample_error_no_such_content_msg));
        }

        @Override
        public void onContentNotPlayable() {
            logger.debug("error: {}", getString(R.string.sample_error_no_content_msg));
        }

        @Override
        public void onPasswordLock() {
            logger.debug("error: {}", getString(R.string.sample_error_password_lock_msg));
        }

        @Override
        public void onAgeLock() {
            logger.debug("error: {}", getString(R.string.sample_error_age_lock_msg));
        }

        @Override
        public void onHashLock() {
            logger.debug("error: {}", getString(R.string.sample_error_hashlocked_content_msg));
        }

        @Override
        public void onGeoLock() {
            logger.debug("error: {}", getString(R.string.sample_error_geo_lock_msg));
        }

        @Override
        public void onRestricted() {
            logger.debug("error: {}", getString(R.string.sample_error_restricted_content_msg));
        }

        @Override
        public void onInvalidApiKey() {
            logger.debug("error: {}", getString(R.string.sample_error_invalid_player_sdk_key));
        }

        @Override
        public void onViewerHourLimitLock() {
            logger.debug("error: {}", getString(R.string.sample_error_viewer_hour_limit_lock_msg));
        }

        @Override
        public void onConnectionError() {
            logger.debug("error: {}", getString(R.string.sample_error_network));
        }

        @Override
        public void onUnknownError() {
            logger.debug("error: {}", getString(R.string.sample_unknown_reject));
        }
    }

    private class ProgressListenerImpl implements ProgressListener {

        @Override
        public void onPositionUpdated(long positionMs) {
            logger.debug("onPositionUpdated( positionMs = {}) ", positionMs);
        }

        @Override
        public void onDurationUpdated(long durationMs) {
            logger.debug("onDurationUpdated( durationMs = {}) ", durationMs);
        }

        @Override
        public void onDurationDisabled() {
            logger.debug("onDurationDisabled() ");
        }

        @Override
        public void onCompleted() {
            logger.debug("onCompleted() ");
        }
    }

    private class LogoClickListenerImpl implements LogoClickListener {

        @Override
        public void onLogoClick(URI logoUrl) {
            logger.debug("onLogoClick( logoUrl = {}) ", logoUrl);
            Intent browserIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(logoUrl.toString()));
            startActivity(browserIntent);
        }
    }

    private class ViewerCountListenerImpl implements ViewerCountListener {
        @Override
        public void onCurrentViewersUpdated(long viewers) {
            logger.debug("onCurrentViewersUpdated( viewers = {}) ", viewers);
        }

        @Override
        public void onCurrentViewersDisabled() {
            logger.debug("onCurrentViewersDisabled() ");
        }

        @Override
        public void onTotalViewersUpdated(long totalViewers) {
            logger.debug("onTotalViewersUpdated( totalViewers = {}) ", totalViewers);
        }

        @Override
        public void onTotalViewersDisabled() {
            logger.debug("onTotalViewersDisabled() ");
        }
    }

    private class MetaDataListenerImpl implements MetaDataListener {

        @Override
        public void onMetaData(MetaData data) {
            logger.debug("onMetaData( data = {}) ", data);
        }

        @Override
        public void onChatAndSocialStreamData(ChatAndSocialStreamData data) {
            logger.debug("onChatAndSocialStreamData( data = {}) ", data);
        }

        @Override
        public void onChatAndSocialStreamDisabled() {
            logger.debug("onChatAndSocialStreamDisabled() ");
        }
    }


    private class BufferingListenerImpl implements BufferingListener {

        @Override
        public void onBufferingStarted() {
            logger.debug("onBufferingStarted() ");
            progressbar.setVisibility(View.VISIBLE);
        }

        @Override
        public void onBufferingStopped() {
            logger.debug("onBufferingStopped() ");
            progressbar.setVisibility(View.GONE);
        }
    }

    private class PlayerListenerImpl implements PlayerListener {

        @Override
        public void onInitialized() {
            logger.debug("onInitialized() ");
        }

        @Override
        public void onStopped() {
            logger.debug("onStopped() ");
        }

        @Override
        public void onWaitingForContent() {
            logger.debug("onWaitingForContent() ");
        }

        @Override
        public void onContentReady() {
            logger.debug("onContentReady() ");
        }

        @Override
        public void onPlaying() {
            logger.debug("onPlaying() ");
        }

        @Override
        public void onPaused() {
            logger.debug("onPaused() ");
        }
    }
}
