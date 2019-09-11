package ibm.playersdk.sample.newsfeed;

import android.view.View;
import android.view.ViewTreeObserver;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import ibm.playersdk.sample.R;
import tv.ustream.player.android.UstreamPlayerFactory;

class VideoViewHolder extends BaseViewHolder<ListItemData> implements ViewTreeObserver.OnScrollChangedListener, AttachableViewHolder {

    private static final Logger logger = LoggerFactory.getLogger(VideoViewHolder.class);

    private final InlineMediaView inlineMediaView;


    VideoViewHolder(View itemView, UstreamPlayerFactory playerFactory) {
        super(itemView);

        inlineMediaView = itemView.findViewById(R.id.inline_player_component);
        inlineMediaView.setPlayerFactory(playerFactory);
    }

    /*
    Content to becomes available when the RecyclerView binds data to the ViewHolder.
    This is the place when the current MediaDisplayView can get it's ustreamPlayer instance.
    The player might have been initialized at this point (for example to pre-buffer data).
    So retrieve a player identified with the content it is initialized to.
     */
    void bind(final ListItemData data) {
        logger.debug("bind( data = {}) ", data);

        inlineMediaView.bind(data);

    }

    /*
    This is delegated from ItemsAdapter.onViewAttachedToWindow.
    The method is called when the card view is about to be displayed on the screen.
    This can be a good place to start playing the content.
     */
    @Override
    public void attach() {
        logger.debug("attach() ");

        itemView.getViewTreeObserver().addOnScrollChangedListener(this);
        inlineMediaView.attach();
        inlineMediaView.play();
    }

    /*
    This is delegated from ItemsAdapter.onViewDetachedFromWindow.
    The method is called when the card view is about to be removed from the screen.
    This can be a good place to pause the content.
     */
    @Override
    public void detach() {
        logger.debug("detach() ");

        inlineMediaView.pause();
        inlineMediaView.detach();
        itemView.getViewTreeObserver().removeOnScrollChangedListener(this);
    }

    /*
    When this ViewHolder is recycled destroy the player to not waste resources.
     */
    @Override
    public void recycle() {
        logger.debug("recycle() ");

        inlineMediaView.recycle();
    }

    @Override
    public void onScrollChanged() {

    }
}
