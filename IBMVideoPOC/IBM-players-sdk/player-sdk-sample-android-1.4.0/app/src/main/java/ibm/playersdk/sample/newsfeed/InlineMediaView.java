package ibm.playersdk.sample.newsfeed;

import android.content.Context;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.util.CustomBufferingListener;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.ErrorListener;
import tv.ustream.player.api.PlayerListener;
import tv.ustream.player.api.UstreamPlayer;

public class InlineMediaView extends FrameLayout {

    private static final Logger logger = LoggerFactory.getLogger(InlineMediaView.class);

    private final PlayerView playerView;

    UstreamPlayer playerAndroid;
    private UstreamPlayerFactory playerFactory;

    boolean playing = false;

    public InlineMediaView(@NonNull Context context, @Nullable AttributeSet attrs) {
        super(context, attrs);
        View.inflate(context, R.layout.view_inline_media, this);
        playerView = findViewById(R.id.player_view);
    }

    public void bind(final ListItemData data) {
        logger.debug("bind( data = {}) ", data);

        playerAndroid = playerFactory.createUstreamPlayer(data.contentDescriptor.toString());
        if(!playerAndroid.isInitialized()){
            playerAndroid.initWithContent(data.contentDescriptor);
        }
        playerAndroid.mute();
        playerAndroid.setPlayerView(playerView);
        playerAndroid.setPlayerListener(new SimplePlayerListener());
        playerAndroid.setErrorListener(new SimpleErrorListener());
        playerAndroid.setBufferingListener(new CustomBufferingListener(findViewById(R.id.progressBar)));
    }

    public void setPlayerFactory(UstreamPlayerFactory playerFactory) {
        logger.debug("setPlayerFactory( playerFactory = {}) ", playerFactory);

        this.playerFactory = playerFactory;
    }

    public void detach() {
        logger.debug("detach() ");

        playerAndroid.detach();
    }

    public void attach() {
        logger.debug("attach() ");

        playerAndroid.attach();
    }

    public void recycle() {
        logger.debug("recycle() ");

        playerAndroid.destroy();
    }

    public void play() {
        logger.debug("play() ");

        playerAndroid.play();
        playerAndroid.mute();
    }

    public void pause() {
        logger.debug("pause() ");
        if(playerAndroid.isInitialized()) {
            playerAndroid.pause();
        }
    }

    private class SimplePlayerListener implements PlayerListener {

        @Override
        public void onInitialized() {
            logger.debug("onInitialized() ");

            playing = false;
        }

        @Override
        public void onWaitingForContent() {
            logger.debug("onWaitingForContent() ");

            playing = false;
        }

        @Override
        public void onContentReady() {
            logger.debug("onContentReady() ");

            playing = false;
            playerAndroid.mute();
        }

        @Override
        public void onPlaying() {
            logger.debug("onPlaying() ");

            playing = true;
        }

        @Override
        public void onPaused() {
            logger.debug("onPaused() ");

            playing = false;
        }

        @Override
        public void onStopped() {
            logger.debug("onStopped() ");

            playing = false;
        }
    }

    public class SimpleErrorListener implements ErrorListener {
        @Override
        public void onContentNotPlayable() {
            logger.debug("onContentNotPlayable() ");

        }

        @Override
        public void onNoSuchContent() {
            logger.debug("onNoSuchContent() ");

        }

        @Override
        public void onPasswordLock() {
            logger.debug("onPasswordLock() ");

        }

        @Override
        public void onAgeLock() {
            logger.debug("onAgeLock() ");

        }

        @Override
        public void onHashLock() {
            logger.debug("onHashLock() ");

        }

        @Override
        public void onGeoLock() {
            logger.debug("onGeoLock() ");
        }

        @Override
        public void onRestricted() {
            logger.debug("onRestricted() ");

        }

        @Override
        public void onInvalidApiKey() {
            logger.debug("onInvalidApiKey() ");

        }

        @Override
        public void onViewerHourLimitLock() {
            logger.debug("onViewerHourLimitLock() ");

        }

        @Override
        public void onConnectionError() {
            logger.debug("onConnectionError() ");

        }

        @Override
        public void onUnknownError() {
            logger.debug("onUnknownError() ");

        }
    }

}
