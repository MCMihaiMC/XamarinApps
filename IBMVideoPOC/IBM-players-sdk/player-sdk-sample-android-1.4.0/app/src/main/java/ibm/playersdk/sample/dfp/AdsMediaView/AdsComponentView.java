package ibm.playersdk.sample.dfp.AdsMediaView;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import ibm.playersdk.ui.components.MediaController;
import ibm.playersdk.ui.components.MediaProvider;
import ibm.playersdk.ui.components.viewfader.FaderController;
import ibm.playersdk.ui.components.viewfader.ViewFader;
import tv.ustream.player.android.plugin.ads.api.AdStateListener;

public class AdsComponentView extends FrameLayout implements AdStateListener, FaderController, MediaController {

    private static final Logger logger = LoggerFactory.getLogger(AdsComponentView.class);

    private ViewFader viewFader;
    private boolean isAdStarted = false;
    private MediaProvider mediaProvider;
    View resumeAdButton;

    public AdsComponentView(Context context, AttributeSet attrs) {
        super(context, attrs);
        logger.debug("AdsComponentView( context = {}, attrs = {}) ", context, attrs);
        View rootView = inflate(context, R.layout.view_ads_component, this);
        resumeAdButton = rootView.findViewById(R.id.ad_resume_playbutton);
        resumeAdButton.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View view) {
                mediaProvider.play();
                resumeAdButton.setVisibility(GONE);
                viewFader.forceFadeout();
                viewFader.stop();
            }
        });
    }

    @Override
    public void setViewFader(ViewFader viewFader) {
        this.viewFader = viewFader;
    }

    @Override
    public void onEnableFadingLogic() {
        if(isAdStarted) {
            viewFader.stop();
        }
    }

    @Override
    public void onDisableFadingLogic() {

    }

    @Override
    public void adStarted() {
        viewFader.forceFadeout();
        viewFader.stop();
        isAdStarted = true;
    }

    @Override
    public void adFinished() {
        isAdStarted = false;

        viewFader.start();
    }

    public void start() {
        if(isAdStarted) {
            resumeAdButton.setVisibility(VISIBLE);
        }
    }

    @Override
    public void setMediaProvider(MediaProvider mediaProvider) {
        this.mediaProvider = mediaProvider;
    }
}
