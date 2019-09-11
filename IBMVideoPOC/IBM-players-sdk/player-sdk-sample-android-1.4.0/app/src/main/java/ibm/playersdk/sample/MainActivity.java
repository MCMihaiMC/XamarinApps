package ibm.playersdk.sample;


import android.content.Intent;
import android.os.Bundle;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import ibm.playersdk.sample.dfp.MidrollActivity;
import ibm.playersdk.sample.dfp.PrerollActivity;
import ibm.playersdk.sample.locks.HashLockActivity;
import ibm.playersdk.sample.multiaudio.MultiAudioActivity;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.fullfeatured.FullfeaturedActivity;
import ibm.playersdk.sample.locks.GeoLocksActivity;
import ibm.playersdk.sample.simpleplayer.SimplePlayerActivity;
import ibm.playersdk.sample.locks.PasswordLockActivity;
import ibm.playersdk.sample.newsfeed.NewsfeedActivity;
import ibm.playersdk.sample.offline.OfflineActivity;
import ibm.playersdk.sample.subtitle.SubtitleActivity;

import static ibm.playersdk.sample.util.Consts.HASHLOCKED_VIDEO;
import static ibm.playersdk.sample.util.Consts.PASSWORD_LOCKED_VIDEO;

public class MainActivity extends AppCompatActivity {

    private static final Logger logger = LoggerFactory.getLogger(MainActivity.class);

    public class SampleData {
        public final String name;
        public final Intent intent;

        public SampleData(String name, Intent intent) {
            this.name = name;
            this.intent = intent;
        }

        @Override
        public String toString() {
            return name;
        }
    }

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        logger.debug("onCreate( savedInstanceState = {}) ", savedInstanceState);

        setContentView(R.layout.activity_main);
        SampleData[] samples = {
                new SampleData("Simple Player", new Intent(MainActivity.this, SimplePlayerActivity.class)),
                new SampleData("Newsfeed", new Intent(MainActivity.this, NewsfeedActivity.class)),
                new SampleData("Subtitle", new Intent(MainActivity.this, SubtitleActivity.class)),
                new SampleData("Multi Audio", new Intent(MainActivity.this, MultiAudioActivity.class)),
                new SampleData("Locks - Password", PasswordLockActivity.createIntent(MainActivity.this, PASSWORD_LOCKED_VIDEO)),
                new SampleData("Locks - Area", new Intent(MainActivity.this, GeoLocksActivity.class)),
                new SampleData("Locks - Hash (In-App Auth)", HashLockActivity.createIntent(MainActivity.this, HASHLOCKED_VIDEO, false)),
                new SampleData("Locks - Hash (Web Auth)", HashLockActivity.createIntent(MainActivity.this, HASHLOCKED_VIDEO, true)),
                new SampleData("Offline", new Intent(MainActivity.this, OfflineActivity.class)),
                new SampleData("Full-Featured", new Intent(MainActivity.this, FullfeaturedActivity.class)),
                new SampleData("DFP pre-roll ad example", new Intent(MainActivity.this, PrerollActivity.class)),
                new SampleData("DFP mid-roll ad example", new Intent(MainActivity.this, MidrollActivity.class)),
        };

        ListView list = findViewById(R.id.example_list);
        final ArrayAdapter<SampleData> sampleAdapter = new ArrayAdapter<SampleData>(this,
                android.R.layout.simple_list_item_1, samples);

        list.setAdapter(sampleAdapter);

        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                logger.debug("onItemClick( adapterView = {}, view = {}, i = {}, l = {}) ", adapterView, view, i, l);
                startActivity(sampleAdapter.getItem(i).intent);
            }
        });
    }
}
