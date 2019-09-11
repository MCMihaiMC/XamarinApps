package ibm.playersdk.sample.newsfeed;

import androidx.recyclerview.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.ArrayList;
import java.util.List;

import ibm.playersdk.sample.R;
import ibm.playersdk.ui.components.utils.prebuffer.SimplePrebufferLogic;
import tv.ustream.content.ContentDescriptor;
import tv.ustream.player.android.UstreamPlayerFactory;

public class ItemsAdapter extends RecyclerView.Adapter<BaseViewHolder<ListItemData>> {

    private static final Logger logger = LoggerFactory.getLogger(ItemsAdapter.class);

    private final List<ListItemData> data;
    private final UstreamPlayerFactory playerFactory;
    private final SimplePrebufferLogic prebufferLogic;

    private static final int TYPE_VIDEO = 1;
    private static final int TYPE_OTHER = 2;
    private static final int BUFFER_SIZE = 3;

    public ItemsAdapter(List<ListItemData> data, UstreamPlayerFactory playerFactory) {
        this.data = data;
        this.playerFactory = playerFactory;
        prebufferLogic = new SimplePrebufferLogic(playerFactory);
        for (ListItemData item : data) {
            if (item.contentDescriptor != null)
            {
                prebufferLogic.add(item.contentDescriptor);
            }
        }
        prebufferLogic.start();
    }

    @Override
    public BaseViewHolder<ListItemData> onCreateViewHolder(ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        switch (viewType) {
            case TYPE_VIDEO:
                View video =  inflater.inflate(R.layout.list_item_video, parent, false);
                return new VideoViewHolder(video, playerFactory);
            case TYPE_OTHER:
                View other = inflater.inflate(R.layout.list_item_other, parent, false);
                return new OtherViewHolder(other);
            default:
                throw new IllegalStateException();
        }
    }

    @Override
    public void onBindViewHolder(BaseViewHolder<ListItemData> holder, int position) {
        holder.bind(data.get(position));
    }

    private List<ContentDescriptor> getBuffereData(int position) {
        List<ContentDescriptor> bufferdata = new ArrayList<>();

        for (int i = position; i<(data.size()) && bufferdata.size() < BUFFER_SIZE; i++){

            ListItemData item = data.get(i);
            if (item.contentDescriptor != null) {
                bufferdata.add(item.contentDescriptor);
            }
        }

        logger.debug("getBuffereData(  = {}) ", bufferdata.toString());
        return bufferdata;
    }

    @Override
    public void onViewAttachedToWindow(BaseViewHolder<ListItemData> holder) {
        if(holder instanceof AttachableViewHolder) {
            ((AttachableViewHolder)holder).attach();
        }
    }

    @Override
    public void onViewDetachedFromWindow(BaseViewHolder<ListItemData> holder) {
        if(holder instanceof AttachableViewHolder) {
            ((AttachableViewHolder)holder).detach();
        }
        super.onViewDetachedFromWindow(holder);
    }

    @Override
    public void onViewRecycled(BaseViewHolder<ListItemData> holder) {
        if(holder instanceof AttachableViewHolder) {
            logger.debug("onViewRecycled( holder = {}) ", holder);
            ((AttachableViewHolder)holder).recycle();
        }
    }

    @Override
    public int getItemCount() {
        return data.size();
    }

    @Override
    public int getItemViewType(int position) {
        return data.get(position).contentDescriptor != null ? TYPE_VIDEO : TYPE_OTHER;
    }

}
