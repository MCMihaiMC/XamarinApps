package ibm.playersdk.sample.locks;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.UUID;

import ibm.playersdk.sample.R;
import ibm.playersdk.sample.locks.dialogs.PasswordDialog;
import ibm.playersdk.sample.util.CustomBufferingListener;
import ibm.playersdk.sample.util.EmptyErrorListener;
import ibm.playersdk.sample.util.PlayerListenerAutoplay;
import tv.ustream.content.ContentDescriptor;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.UstreamPlayer;

import static ibm.playersdk.sample.util.Consts.*;

// This is an example demonstration of PasswordLock handling.
// PasswordLock is a simple authentication method in which the user must enter a password to view the content.
public class PasswordLockActivity extends AppCompatActivity implements PasswordDialog.PasswordEnteredListener {

    private static final Logger logger = LoggerFactory.getLogger(PasswordLockActivity.class);
    private static final String PLAYER_ID_KEY = "USTREAM_PLAYER_ID_KEY";
    private static final String CONTENT = "Content";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private UstreamPlayer ustreamPlayer;
    private String playerId; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView;

    public static Intent createIntent(Context context, ContentDescriptor contentDescriptor) {
        final Intent intent = new Intent(context, PasswordLockActivity.class);
        intent.putExtra(CONTENT, contentDescriptor);
        return intent;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_passwordlock);

        final ContentDescriptor contentDescriptor = (ContentDescriptor) getIntent().getSerializableExtra(CONTENT);
        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId = savedInstanceState.getString(PLAYER_ID_KEY, UUID.randomUUID().toString());
        } else {
            playerId = UUID.randomUUID().toString();
        }

        playerView = findViewById(R.id.playerview);

        ustreamPlayer = ustreamPlayerFactory.createUstreamPlayer(playerId);
        if (!ustreamPlayer.isInitialized()) {
            ustreamPlayer.initWithContent(contentDescriptor);
        }
    }

    @Override
    protected void onStart() {
        super.onStart();
        ustreamPlayer.setPlayerListener(new PlayerListenerAutoplay(ustreamPlayer));
        ustreamPlayer.setErrorListener(new ErrorListenerImpl(this));
        ustreamPlayer.setBufferingListener(new CustomBufferingListener(findViewById(R.id.progressBar)));
        ustreamPlayer.setPlayerView(playerView);
        ustreamPlayer.attach();
    }

    @Override
    protected void onStop() {
        ustreamPlayer.detach();
        super.onStop();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putString(PLAYER_ID_KEY, playerId); // Save the player id so it can be restored after a config change.
        super.onSaveInstanceState(outState);
    }

    @Override
    public void onPasswordEntered(String password) {
        ustreamPlayer.setPassword(password);
        ustreamPlayer.play();
    }

    @Override
    public void onPasswordCancelled() {
        finish();
    }

    private class ErrorListenerImpl extends EmptyErrorListener {

        public ErrorListenerImpl(Context context) {
            super(context);
        }

        @Override
        public void onPasswordLock() {
            logger.debug("error: {}", getString(R.string.sample_error_password_lock_msg));
            PasswordDialog.create().show(getFragmentManager(), "onPasswordLock");
            ustreamPlayer.clearError(); // we clear the error here, because without clear after configuration change (ex. device rotation) we get this error message again.
        }
    }
}
