package ibm.playersdk.sample.locks.dialogs;

import android.app.AlertDialog;
import android.app.Dialog;
import android.app.DialogFragment;
import android.content.DialogInterface;
import android.os.Bundle;
import android.text.InputType;
import android.widget.EditText;

import ibm.playersdk.sample.R;

import static ibm.playersdk.sample.util.Consts.PASSWORD_LOCKED_VIDEO_PWD;

public class PasswordDialog extends DialogFragment {

    private EditText input;

    public interface PasswordEnteredListener {
        void onPasswordEntered(String password);
        void onPasswordCancelled();
    }

    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {

        input = new EditText(getActivity());
        input.setHint(R.string.sample_enter_password);
        input.setInputType(InputType.TYPE_TEXT_VARIATION_PASSWORD);

        return new AlertDialog.Builder(getActivity())
                .setView(input)
                .setTitle(getString(R.string.sample_password_dialog_title))
                .setMessage("try: " + PASSWORD_LOCKED_VIDEO_PWD)
                .setPositiveButton(android.R.string.ok, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        PasswordEnteredListener listener = (PasswordEnteredListener) getActivity();
                        if(listener != null) {
                            listener.onPasswordEntered(input.getText().toString());
                        }
                    }
                })
                .setNegativeButton(android.R.string.cancel, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        PasswordEnteredListener listener = (PasswordEnteredListener) getActivity();
                        if(listener != null) {
                            listener.onPasswordCancelled();
                            dismiss();
                        }
                    }
                })
                .create();
    }

    public static PasswordDialog create(){
        PasswordDialog dialog = new PasswordDialog();
        return dialog;
    }
}
