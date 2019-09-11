package ibm.playersdk.sample.fullfeatured.customizedUI;

import android.content.Context;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import android.util.AttributeSet;

import ibm.playersdk.sample.R;
import ibm.playersdk.ui.components.MediaViewBase;

public class MyCustomMediaView extends MediaViewBase {

    public MyCustomMediaView(@NonNull Context context, @Nullable AttributeSet attrs) {
        super(context, attrs);
    }

    @Override
    protected int getViewId() {
        return R.layout.view_my_custom_media;
    }

}
