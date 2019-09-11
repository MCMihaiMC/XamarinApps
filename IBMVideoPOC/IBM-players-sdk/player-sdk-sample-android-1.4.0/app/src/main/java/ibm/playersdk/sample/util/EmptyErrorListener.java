package ibm.playersdk.sample.util;

import android.content.Context;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import tv.ustream.player.api.ErrorListener;

public class EmptyErrorListener implements ErrorListener {

    private static final Logger logger = LoggerFactory.getLogger(EmptyErrorListener.class);
    private final Context context;

    public EmptyErrorListener(Context context) {
        this.context = context;
    }

    @Override
    public void onNoSuchContent() {
        logger.debug("error: {}", context.getString(R.string.sample_error_no_such_content_msg));
    }

    @Override
    public void onContentNotPlayable() {
        logger.debug("error: {}", context.getString(R.string.sample_error_no_content_msg));
    }

    @Override
    public void onPasswordLock() {
        logger.debug("error: {}", context.getString(R.string.sample_error_password_lock_msg));
    }

    @Override
    public void onAgeLock() {
        logger.debug("error: {}", context.getString(R.string.sample_error_age_lock_msg));
    }

    @Override
    public void onHashLock() {
        logger.debug("error: {}", context.getString(R.string.sample_error_hashlocked_content_msg));
    }

    @Override
    public void onGeoLock() {
        logger.debug("error: {}", context.getString(R.string.sample_error_geo_lock_msg));
    }

    @Override
    public void onRestricted() {
        logger.debug("error: {}", context.getString(R.string.sample_error_restricted_content_msg));
    }

    @Override
    public void onInvalidApiKey() {
        logger.debug("error: {}", context.getString(R.string.sample_error_invalid_player_sdk_key));
    }

    @Override
    public void onViewerHourLimitLock() {
        logger.debug("error: {}", context.getString(R.string.sample_error_viewer_hour_limit_lock_msg));
    }

    @Override
    public void onConnectionError() {
        logger.debug("error: {}", context.getString(R.string.sample_error_network));
    }

    @Override
    public void onUnknownError() {
        logger.debug("error: {}", context.getString(R.string.sample_unknown_reject));
    }
}
