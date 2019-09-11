package ibm.playersdk.sample.dfp.AdsMediaView;

import android.content.Context;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import android.util.AttributeSet;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.List;
import java.util.Map;

import ibm.playersdk.sample.R;
import ibm.playersdk.ui.components.MediaViewBase;
import tv.ustream.content.ContentDescriptor;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.android.plugin.ads.api.AdData;
import tv.ustream.player.android.plugin.ads.api.AdsMediaPlayerModuleAndroid;
import tv.ustream.player.plugin.MediaPlayerModule;

public class AdsMediaView extends MediaViewBase {

    private static final Logger logger = LoggerFactory.getLogger(AdsMediaView.class);

    private AdsMediaPlayerModuleAndroid mediaPlayerPlugin;
    private AdsComponentView adsComponentView;

    public AdsMediaView(@NonNull Context context, @Nullable AttributeSet attrs) {
        super(context, attrs);
        adsComponentView = getRootView().findViewById(R.id.ads_component);
    }

    @Override
    public void init(UstreamPlayerFactory playerFactory, ContentDescriptor contentDescriptor, MediaPlayerModule mediaPlayerModule) {
        logger.debug("init( playerFactory = {}, contentDescriptor = {}) ", playerFactory, contentDescriptor);
        super.init(playerFactory, contentDescriptor, mediaPlayerModule);

        mediaPlayerPlugin = getMediaPlayerPlugin();
        mediaPlayerPlugin.setAdStateListener(adsComponentView);
    }

    public void setAdData(String title, List<String> adKeywords, Map<String, String> adExtras) {
        mediaPlayerPlugin.setAdData(new AdData( title, adKeywords, adExtras));
    }

    @Override
    public void start() {
        super.start();
        adsComponentView.start();
    }

    @Override
    protected int getViewId() {
        logger.debug("getViewId() ");

        return R.layout.view_ads_media;
    }
}
