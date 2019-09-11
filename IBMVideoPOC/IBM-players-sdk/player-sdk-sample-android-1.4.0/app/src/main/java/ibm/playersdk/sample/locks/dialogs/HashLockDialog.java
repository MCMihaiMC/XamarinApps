package ibm.playersdk.sample.locks.dialogs;

import android.app.AlertDialog;
import android.app.Dialog;
import android.app.DialogFragment;
import android.content.DialogInterface;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import java.io.IOException;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.util.Consts;
import okhttp3.FormBody;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.RequestBody;
import okhttp3.Response;

public class HashLockDialog extends DialogFragment {

    public interface OnHashLockEnteredListener {
        void onHashReceived(String hash);
    }

    private EditText inputUser;
    private EditText inputPw;
    View hashlockForm;
    View hashlockProgress;

    private Handler handler;

    private OnHashLockEnteredListener listener;

    @Override
    public Dialog onCreateDialog(Bundle savedInstanceState) {

        handler = new Handler();

        View inputs = View.inflate(getActivity(), R.layout.dialog_hashlock, null);
        inputUser = inputs.findViewById(R.id.input_user);
        inputPw = inputs.findViewById(R.id.input_password);
        hashlockForm = inputs.findViewById(R.id.hashlock_form);
        hashlockProgress = inputs.findViewById(R.id.hashlock_progress);

        AlertDialog dialog = new AlertDialog.Builder(getActivity())
                .setView(inputs)
                .setTitle(R.string.sample_hashlock_dialog_title)
                .setPositiveButton(android.R.string.ok, null)
                .setNegativeButton(android.R.string.cancel, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        dismiss();
                    }
                })
                .create();
        dialog.setOnShowListener(new DialogInterface.OnShowListener() {
            @Override
            public void onShow(DialogInterface dialog) {
                Button positiveButton = ((AlertDialog) dialog).getButton(DialogInterface.BUTTON_POSITIVE);
                positiveButton.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(final View v) {

                        hashlockForm.setVisibility(View.GONE);
                        hashlockProgress.setVisibility(View.VISIBLE);

                        OkHttpClient.Builder builder = new OkHttpClient.Builder();

                        final OkHttpClient client = builder.build();

                        final RequestBody formBody = new FormBody.Builder()
                                .add("user", inputUser.getText().toString())
                                .add("pw", inputPw.getText().toString())
                                .add("platform", "mobile")
                                .add("redirect", "false")
                                .add("comment", "abcdef 123456 ?!%.")
                                .build();

                        final Request postRequest = new Request.Builder()
                                .url(Consts.HASHLOCK_API_URL)
                                .post(formBody)
                                .build();

                        new Thread() {
                            @Override
                            public void run() {
                                try {
                                    Response response = client.newCall(postRequest).execute();
                                    final String hash = response.body().string();
                                    callbackAndClose(hash);
                                } catch (IOException e) {
                                    e.printStackTrace();
                                }


                            }
                        }.start();

                    }
                });
            }
        });
        return dialog;
    }

    private void callbackAndClose(final String hash) {
        handler.post(new Runnable() {
            @Override
            public void run() {
                if(listener != null) {
                    listener.onHashReceived(hash);
                }
                hashlockForm.setVisibility(View.VISIBLE);
                hashlockForm.setVisibility(View.GONE);
                dismiss();
            }
        });
    }

    public static HashLockDialog create(OnHashLockEnteredListener listener){
        HashLockDialog dialog = new HashLockDialog();
        dialog.listener = listener;
        return dialog;
    }
}
