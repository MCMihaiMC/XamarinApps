package ibm.playersdk.sample;

import androidx.multidex.MultiDexApplication;

import ibm.playersdk.sample.util.Logging;

public class App extends MultiDexApplication {

    @Override
    public void onCreate() {
        Logging.configure();
        super.onCreate();
    }
}
