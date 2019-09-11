package ibm.playersdk.sample.fullfeatured.customizedUI;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.CompoundButton;
import android.widget.FrameLayout;
import android.widget.Switch;
import android.widget.TextView;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import ibm.playersdk.ui.components.MediaController;
import ibm.playersdk.ui.components.MediaProvider;
import ibm.playersdk.ui.components.callbacks.BufferingStateListener;
import ibm.playersdk.ui.components.callbacks.PlayerStateListener;
import ibm.playersdk.ui.components.viewfader.Fadeable;

public class MyCustomComponentView extends FrameLayout implements PlayerStateListener, Fadeable, BufferingStateListener, MediaController {

    private static final Logger logger = LoggerFactory.getLogger(MyCustomComponentView.class);
    private MediaProvider mediaProvider;
    private TextView label;
    private View buffering;

    public MyCustomComponentView(Context context, AttributeSet attrs) {
        super(context, attrs);
        View rootView = inflate(context, R.layout.view_my_custom_control, this);
        Switch muteSwitch = rootView.findViewById(R.id.my_custom_switch);
        label = rootView.findViewById(R.id.my_custom_label);
        buffering = rootView.findViewById(R.id.my_custom_progressbar);

        muteSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                if(b) {
                    mediaProvider.mute();
                } else {
                    mediaProvider.unMute();
                }
            }
        });

        buffering.setVisibility(INVISIBLE);
    }

    @Override
    public void setMediaProvider(MediaProvider mediaProvider) {
        this.mediaProvider = mediaProvider;
    }

    @Override
    public void bufferingStarted() {
        label.setText(R.string.label_buffering);
        buffering.setVisibility(VISIBLE);
    }

    @Override
    public void bufferingStopped() {
        buffering.setVisibility(INVISIBLE);
    }

    @Override
    public void initialized() {
        label.setText(R.string.label_initialized);
    }

    @Override
    public void playing() {
        label.setText(R.string.label_playing);
    }

    @Override
    public void paused() {
        label.setText(R.string.label_paused);
    }

    @Override
    public void stopped() {
        label.setText(R.string.label_stopped);
    }

    @Override
    public View getView() {
        return this;
    }
}
