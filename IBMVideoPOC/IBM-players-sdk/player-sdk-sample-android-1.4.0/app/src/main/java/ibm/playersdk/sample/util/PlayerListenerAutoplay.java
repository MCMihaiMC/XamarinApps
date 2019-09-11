package ibm.playersdk.sample.util;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import tv.ustream.player.api.PlayerListener;
import tv.ustream.player.api.UstreamPlayer;

public class PlayerListenerAutoplay implements PlayerListener {

    private static final Logger logger = LoggerFactory.getLogger(PlayerListenerAutoplay.class);

    private UstreamPlayer ustreamPlayer;

    public PlayerListenerAutoplay(UstreamPlayer player) {
        this.ustreamPlayer = player;
    }

    @Override
    public void onInitialized() {
        logger.debug("onInitialized() ");
        ustreamPlayer.play();
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
