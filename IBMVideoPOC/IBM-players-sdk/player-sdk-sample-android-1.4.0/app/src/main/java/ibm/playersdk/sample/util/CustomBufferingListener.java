package ibm.playersdk.sample.util;

import android.view.View;

import tv.ustream.player.api.BufferingListener;

public class CustomBufferingListener implements BufferingListener {

    private final View progressbar;

    public CustomBufferingListener(View progressbar) {
        this.progressbar = progressbar;
    }

    @Override
    public void onBufferingStarted() {
        progressbar.setVisibility(View.VISIBLE);
    }

    @Override
    public void onBufferingStopped() {
        progressbar.setVisibility(View.GONE);
    }
}
