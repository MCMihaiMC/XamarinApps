package ibm.playersdk.sample.dfp;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.dfp.AdsMediaView.AdsMediaView;
import ibm.playersdk.ui.components.MediaView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.android.plugin.ads.api.AdScheduleRule;
import tv.ustream.player.android.plugin.ads.api.AdsMediaPlayerModuleAndroid;
import tv.ustream.player.android.plugin.ads.api.FixedIntervalRule;
import tv.ustream.player.android.plugin.ads.api.PrerollOnlyRule;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.DFP_TAG_URL;
import static ibm.playersdk.sample.util.Consts.VIDEO_ID;

public class PrerollActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(PrerollActivity.class);

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);


    private AdsMediaView mediaView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_dfp);

        mediaView = findViewById(R.id.media_display_view);

        AdScheduleRule rule = new PrerollOnlyRule();
        mediaView.init(ustreamPlayerFactory, VIDEO_ID,
                new AdsMediaPlayerModuleAndroid(this, DFP_TAG_URL, rule)
        );
        List<String> adKeywords = new ArrayList<>(Arrays.asList("testKeyword1", "testKeyword2"));
        Map<String, String> adExtras = new HashMap<>();

        adExtras.put("test1_kv_predefined", "Red");
        adExtras.put("test2_kv_freeform", "Blue2");
        mediaView.setAdData( "TestTitle", adKeywords, adExtras);
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
