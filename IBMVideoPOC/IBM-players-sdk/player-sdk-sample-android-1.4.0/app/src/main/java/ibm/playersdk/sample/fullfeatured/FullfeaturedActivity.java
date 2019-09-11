package ibm.playersdk.sample.fullfeatured;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.fullfeatured.customizedUI.MyCustomMediaView;
import ibm.playersdk.ui.components.MediaView;
import tv.ustream.player.android.UstreamPlayerFactory;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.MULTI_AUDIO_VIDEO;
import static ibm.playersdk.sample.util.Consts.VIDEO_ID;

// This is an example demonstration of a 'full featured' player.
// This sample is a reference implementation of one of our UX use cases.
// The player has been put together using pre-made UI components on top of the SDK.
// These UI components can be customized to your needs, or dropped altogether.
// If the components do not fit your use case feel free to use the SDK with your own custom UI.
public class FullfeaturedActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(FullfeaturedActivity.class);

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private MediaView mediaView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_fullfeatured);

        mediaView = findViewById(R.id.media_display_view);
        mediaView.init(ustreamPlayerFactory, MULTI_AUDIO_VIDEO);

// To use custom mediaView go to 'activity_fullfeatured.xml' and replace the MediaView to MyCustomMediaView
//        mediaView = findViewById(R.id.custom_media_display_view);
//        mediaView.init(ustreamPlayerFactory, data, (SubtitleSelector) this);
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
