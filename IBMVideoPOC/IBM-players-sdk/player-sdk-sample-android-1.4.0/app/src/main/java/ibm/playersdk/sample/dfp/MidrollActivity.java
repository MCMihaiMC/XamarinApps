package ibm.playersdk.sample.dfp;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.dfp.AdsMediaView.AdsMediaView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.android.plugin.ads.api.AdScheduleRule;
import tv.ustream.player.android.plugin.ads.api.AdsMediaPlayerModuleAndroid;
import tv.ustream.player.android.plugin.ads.api.FixedIntervalRule;

import java.util.concurrent.TimeUnit;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.DFP_TAG_URL;
import static ibm.playersdk.sample.util.Consts.VIDEO_ID;

public class MidrollActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(MidrollActivity.class);

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private AdsMediaView mediaView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_dfp);

        mediaView = findViewById(R.id.media_display_view);

        AdScheduleRule rule = new FixedIntervalRule(false, 10, TimeUnit.SECONDS);
        mediaView.init(ustreamPlayerFactory, VIDEO_ID,
                new AdsMediaPlayerModuleAndroid(this, DFP_TAG_URL, rule)
        );
    }

    @Override
    protected void onStart() {
        mediaView.start();
        super.onStart();
    }

    @Override
    protected void onStop() {
        mediaView.stop();
        super.onStop();
    }
}
