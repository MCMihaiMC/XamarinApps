package ibm.playersdk.sample.subtitle;

import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import androidx.appcompat.app.AlertDialog;
import androidx.fragment.app.DialogFragment;
import androidx.fragment.app.FragmentManager;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.ArrayList;
import java.util.List;

import ibm.playersdk.sample.R;

public class SubtitleSelectorFragment extends DialogFragment {


    private static final String DIALOG_TAG = SubtitleSelectorFragment.class.getName();
    private static final Logger logger = LoggerFactory.getLogger(SubtitleSelectorFragment.class);
    public static final String SUBTITLE_TITLE_LIST = "SELECTOR_TITLE_LIST";
    public static final String SUBTITLE_SELECTED = "SELECTOR_SELECTED";

    private final List<SubtitleSelectorResultListener> listeners = new ArrayList<>();

    public interface SubtitleSelectorResultListener {
        void onSubtitleSelectorFragmentApply(int idx, String title);
        void onSubtitleSelectorFragmentCancel();
    }

    private ArrayList<String> tracklistTitles;
    private int selected;

    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {
        logger.debug("onCreateDialog( savedInstanceState = {}) ", savedInstanceState);

        Bundle b = getArguments();
        if(b != null) {
            this.tracklistTitles = b.getStringArrayList(SUBTITLE_TITLE_LIST);
            this.selected = b.getInt(SUBTITLE_SELECTED, 0);
        }

        final CharSequence[] titles = tracklistTitles.toArray(new CharSequence[tracklistTitles.size()]);
        AlertDialog dialog = new AlertDialog.Builder(getActivity())
                .setTitle(getResources().getString(R.string.subtitle_selector_title))
                .setSingleChoiceItems(titles, this.selected, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        for(SubtitleSelectorResultListener listener: listeners) {
                            listener.onSubtitleSelectorFragmentApply(i, SubtitleSelectorFragment.this.tracklistTitles.get(i).toString());
                            dismiss();
                        }
                    }
                })
                .create();
        return dialog;
    }


    @Override
    public void onStart() {
        super.onStart();
        if (getActivity() instanceof SubtitleSelectorResultListener) {
            listeners.add((SubtitleSelectorResultListener) getActivity());
        }

    }

    @Override
    public void onStop() {
        super.onStop();
        if (getActivity() instanceof SubtitleSelectorResultListener) {
            listeners.remove(getActivity());
        }
    }


    @Override
    public void onCancel(DialogInterface dialog) {
        super.onCancel(dialog);
        for (SubtitleSelectorResultListener listener : listeners) {
            listener.onSubtitleSelectorFragmentCancel();
        }
    }

    public static void showDialog(FragmentManager fragmentManager, ArrayList<String> tracklistTitles, int selected) {
        logger.debug("showDialog( fragmentManager = {}, tracklistTitles = {}, selected = {}) ", fragmentManager, tracklistTitles, selected);

        SubtitleSelectorFragment dialog = (SubtitleSelectorFragment) fragmentManager.findFragmentByTag(DIALOG_TAG);
        if (dialog == null) {
            dialog = new SubtitleSelectorFragment();
            Bundle args = new Bundle();
            args.putStringArrayList(SUBTITLE_TITLE_LIST, tracklistTitles);
            args.putInt(SUBTITLE_SELECTED, selected);
            dialog.setArguments(args);
            dialog.show(fragmentManager, DIALOG_TAG);
        }
    }
}
