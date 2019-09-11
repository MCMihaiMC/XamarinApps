package ibm.playersdk.sample.newsfeed;


import android.os.Bundle;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

import ibm.playersdk.sample.R;
import tv.ustream.player.android.UstreamPlayerFactory;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.NEWSFEED_VIDEO_1;
import static ibm.playersdk.sample.util.Consts.NEWSFEED_VIDEO_2;
import static ibm.playersdk.sample.util.Consts.NEWSFEED_VIDEO_3;

// This is simple example demonstration of the newsfeed use case,
// video content is mixed in a list with other 'blog type' content.
// The video contents are pre-buffered to create the illusion of
// instantly starting playback when the user scrolls it into view.
public class NewsfeedActivity extends AppCompatActivity {

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private List<ListItemData> data;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_newsfeed);

        RecyclerView recyclerView = findViewById(R.id.recycler_view);

        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(this);
        recyclerView.setLayoutManager(layoutManager);
        data = createData();

        ItemsAdapter adapter = new ItemsAdapter(data , ustreamPlayerFactory);
        recyclerView.setAdapter(adapter);
    }

    private List<ListItemData> createData() {
        List<ListItemData> data = new ArrayList<>();
        data.add(new ListItemData(null));
        data.add(new ListItemData(null));
        data.add(new ListItemData(NEWSFEED_VIDEO_1));
        data.add(new ListItemData(null));
        data.add(new ListItemData(null));
        data.add(new ListItemData(NEWSFEED_VIDEO_2));
        data.add(new ListItemData(null));
        data.add(new ListItemData(null));
        data.add(new ListItemData(NEWSFEED_VIDEO_3));
        data.add(new ListItemData(null));
        data.add(new ListItemData(null));

        return data;
    }

}
