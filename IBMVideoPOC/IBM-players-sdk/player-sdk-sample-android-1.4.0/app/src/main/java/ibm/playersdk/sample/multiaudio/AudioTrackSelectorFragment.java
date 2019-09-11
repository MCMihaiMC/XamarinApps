package ibm.playersdk.sample.multiaudio;

import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import androidx.appcompat.app.AlertDialog;
import androidx.fragment.app.DialogFragment;
import androidx.fragment.app.FragmentManager;

import ibm.playersdk.sample.R;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.ArrayList;
import java.util.List;

public class AudioTrackSelectorFragment extends DialogFragment {


    private static final String DIALOG_TAG = AudioTrackSelectorFragment.class.getName();
    private static final Logger logger = LoggerFactory.getLogger(AudioTrackSelectorFragment.class);
    public static final String AUDIO_TRACK_TITLE_LIST = "AUDIO_SELECTOR_TITLE_LIST";
    public static final String AUDIO_TRACK_SELECTED = "AUDIO_SELECTOR_SELECTED";

    private final List<AudioTrackSelectorResultListener> listeners = new ArrayList<>();

    public interface AudioTrackSelectorResultListener {
        void onAudioTrackSelectorFragmentApply(int idx, String title);
        void onAudioTrackSelectorFragmentCancel();
    }

    private ArrayList<String> tracklistTitles;
    private int selected;

    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {
        logger.debug("onCreateDialog( savedInstanceState = {}) ", savedInstanceState);

        Bundle b = getArguments();
        if(b != null) {
            this.tracklistTitles = b.getStringArrayList(AUDIO_TRACK_TITLE_LIST);
            this.selected = b.getInt(AUDIO_TRACK_SELECTED, 0);
        }

        final CharSequence[] titles = tracklistTitles.toArray(new CharSequence[tracklistTitles.size()]);
        return new AlertDialog.Builder(getActivity())
                .setTitle(getResources().getString(R.string.language_selector_title))
                .setSingleChoiceItems(titles, this.selected, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        for(AudioTrackSelectorResultListener listener: listeners) {
                            listener.onAudioTrackSelectorFragmentApply(i, AudioTrackSelectorFragment.this.tracklistTitles.get(i));
                            dismiss();
                        }
                    }
                })
                .create();
    }


    @Override
    public void onStart() {
        super.onStart();
        if (getActivity() instanceof AudioTrackSelectorResultListener) {
            listeners.add((AudioTrackSelectorResultListener) getActivity());
        }

    }

    @Override
    public void onStop() {
        super.onStop();
        if (getActivity() instanceof AudioTrackSelectorResultListener) {
            listeners.remove(getActivity());
        }
    }


    @Override
    public void onCancel(DialogInterface dialog) {
        super.onCancel(dialog);
        for (AudioTrackSelectorResultListener listener : listeners) {
            listener.onAudioTrackSelectorFragmentCancel();
        }
    }

    public static void showDialog(FragmentManager fragmentManager, ArrayList<String> tracklistTitles, int selected) {
        logger.debug("showDialog( fragmentManager = {}, tracklistTitles = {}, selected = {}) ", fragmentManager, tracklistTitles, selected);

        AudioTrackSelectorFragment dialog = (AudioTrackSelectorFragment) fragmentManager.findFragmentByTag(DIALOG_TAG);
        if (dialog == null) {
            dialog = new AudioTrackSelectorFragment();
            Bundle args = new Bundle();
            args.putStringArrayList(AUDIO_TRACK_TITLE_LIST, tracklistTitles);
            args.putInt(AUDIO_TRACK_SELECTED, selected);
            dialog.setArguments(args);
            dialog.show(fragmentManager, DIALOG_TAG);
        }
    }
}
