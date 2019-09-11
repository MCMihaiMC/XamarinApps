package ibm.playersdk.sample.util;

import tv.ustream.content.ContentDescriptor;
import tv.ustream.content.ContentType;

public class Consts {
    public static final String API_KEY = "jpZI2KoZhV2S0KEzBPIajwdHXlm54KPa0V1KLhGw";

    public static final ContentDescriptor LIVE_CHANNEL = new ContentDescriptor(ContentType.LIVE, 23308285);
    public static final ContentDescriptor VIDEO_ID = new ContentDescriptor(ContentType.RECORDED, 105449238);
    public static final ContentDescriptor CLOSED_CAPTION_VIDEO = new ContentDescriptor(ContentType.RECORDED, 109016469);
    public static final ContentDescriptor MULTI_AUDIO_VIDEO = new ContentDescriptor(ContentType.RECORDED, 115178919);

    public static final ContentDescriptor NEWSFEED_VIDEO_1 = new ContentDescriptor(ContentType.RECORDED, 109048583);
    public static final ContentDescriptor NEWSFEED_VIDEO_2 = new ContentDescriptor(ContentType.RECORDED, 105418991);
    public static final ContentDescriptor NEWSFEED_VIDEO_3 = new ContentDescriptor(ContentType.RECORDED, 105418957);
    public static final ContentDescriptor GEOLOCKED_VIDEO_USA_BLACKLISTED = new ContentDescriptor(ContentType.RECORDED, 108978504); //USA Blacklisted
    public static final ContentDescriptor GEOLOCKED_VIDEO_USA_WHITELISTED = new ContentDescriptor(ContentType.RECORDED, 109049415); //USA Whitelisted

    public static final ContentDescriptor HASHLOCKED_VIDEO = new ContentDescriptor(ContentType.RECORDED, 109049663);
    public static final ContentDescriptor PASSWORD_LOCKED_VIDEO = new ContentDescriptor(ContentType.RECORDED, 108977970); //pw: "ibm100+"
    public static final String PASSWORD_LOCKED_VIDEO_PWD = "ibm100+";

    public static final ContentDescriptor OFFLINE_CHANNEL = new ContentDescriptor(ContentType.LIVE, 23439002);

    public static final String HASHLOCK_API_URL_WEB_AUTH = "https://openwhisk.eu-gb.bluemix.net/api/v1/web/IBM%20Player%20SDK_dev/ibm-playersdk-sample/hashlock?platform=mobile";
    public static final String HASHLOCK_API_URL = "https://openwhisk.eu-gb.bluemix.net/api/v1/web/IBM%20Player%20SDK_dev/ibm-playersdk-sample/hashlock";
    public static final String HASHLOCK_RESPONSE_PARAM = "hash";

    public static final String DFP_TAG_URL = "https://pubads.g.doubleclick.net/gampad/ads?sz=640x480&iu=/1044507/sandbox&impl=s&gdfp_req=1&env=vp&output=vast&unviewed_position_start=1&url=[referrer_url]&description_url=[description_url]&correlator=[timestamp]";

}
