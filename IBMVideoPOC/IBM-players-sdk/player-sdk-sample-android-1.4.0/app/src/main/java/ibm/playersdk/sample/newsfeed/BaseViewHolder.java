package ibm.playersdk.sample.newsfeed;

import androidx.recyclerview.widget.RecyclerView;
import android.view.View;

abstract class BaseViewHolder<T> extends RecyclerView.ViewHolder {

    BaseViewHolder(View root) {
        super(root);
    }

    abstract void bind(T data);

}
