package ibm.playersdk.sample.util;


import ibm.playersdk.sample.BuildConfig;
import timber.log.Timber;

public class Logging {
    public static void configure() {
        if (BuildConfig.DEBUG) {
            Timber.plant(new Timber.DebugTree());
        }
    }
}
