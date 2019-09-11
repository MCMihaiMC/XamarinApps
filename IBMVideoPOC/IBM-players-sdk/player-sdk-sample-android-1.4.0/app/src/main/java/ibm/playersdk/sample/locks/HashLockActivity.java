package ibm.playersdk.sample.locks;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import androidx.browser.customtabs.CustomTabsIntent;
import androidx.appcompat.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import ibm.playersdk.sample.R;
import ibm.playersdk.sample.locks.dialogs.HashLockDialog;
import ibm.playersdk.sample.util.CustomBufferingListener;
import ibm.playersdk.sample.util.EmptyErrorListener;
import ibm.playersdk.sample.util.PlayerListenerAutoplay;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import tv.ustream.content.ContentDescriptor;
import tv.ustream.player.android.PlayerView;
import tv.ustream.player.android.UstreamPlayerFactory;
import tv.ustream.player.api.UstreamPlayer;

import java.util.UUID;

import static ibm.playersdk.sample.util.Consts.API_KEY;
import static ibm.playersdk.sample.util.Consts.HASHLOCK_API_URL_WEB_AUTH;
import static ibm.playersdk.sample.util.Consts.HASHLOCK_RESPONSE_PARAM;

// This is an example demonstration of HashLock handling.
// HashLock is an advanced form of authentication in which the user must authenticate on your auth service (SSO, or other).
//          Authentication can happen using WebView (or Custom Tabs interface) or native UI elements.
//          It depends on your authentication service implementation. Use whichever fits your use case the most.
//          For more information on the hashLock topic see: http://developers.ustream.tv/channel-api/viewer-authentication-api.html
public class HashLockActivity extends AppCompatActivity implements HashLockDialog.OnHashLockEnteredListener {

    private static final Logger logger = LoggerFactory.getLogger(HashLockActivity.class);
    private static final String PLAYER_ID_KEY = "USTREAM_PLAYER_ID_KEY";
    private static final String CONTENT = "Content";
    private static final String USE_WEB_AUTH = "UseWebAuth";

    private final UstreamPlayerFactory ustreamPlayerFactory = new UstreamPlayerFactory(API_KEY, this);

    private UstreamPlayer ustreamPlayer;
    private String playerId; // The identifier of our player. Must be persisted in order to retrieve the same instance in case of a configuration change.
    private PlayerView playerView;
    private Button hashLockAuthButton;
    private boolean isWebAuth;

    public static Intent createIntent(Context context, ContentDescriptor contentDescriptor, boolean useWebAuth) {
        final Intent intent = new Intent(context, HashLockActivity.class);
        intent.putExtra(CONTENT, contentDescriptor);
        intent.putExtra(USE_WEB_AUTH, useWebAuth);
        return intent;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_hashlock);

        isWebAuth = getIntent().getBooleanExtra(USE_WEB_AUTH, false);
        final ContentDescriptor contentDescriptor = (ContentDescriptor) getIntent().getSerializableExtra(CONTENT);
        // Generate a new id for the player if necessary.
        if (savedInstanceState != null) {
            playerId = savedInstanceState.getString(PLAYER_ID_KEY, UUID.randomUUID().toString());
        } else {
            playerId = UUID.randomUUID().toString();
        }

        playerView = findViewById(R.id.playerview);
        hashLockAuthButton = findViewById(R.id.hashlock_auth_button);
        hashLockAuthButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (isWebAuth) {
                    final CustomTabsIntent.Builder builder = new CustomTabsIntent.Builder();
                    final CustomTabsIntent customTabsIntent = builder.build();
                    customTabsIntent.launchUrl(HashLockActivity.this, Uri.parse(HASHLOCK_API_URL_WEB_AUTH));
                } else {
                    HashLockDialog.create(HashLockActivity.this).show(getFragmentManager(), "onHashLock");
                    ustreamPlayer.clearError(); // Clear the HashLock error state, so it does not report it again when we re-attach to it. This is convenient because the FragmentDialog's lifecycle is already managed.
                }
            }
        });

        ustreamPlayer = ustreamPlayerFactory.createUstreamPlayer(playerId);
        if (!ustreamPlayer.isInitialized()) {
            ustreamPlayer.initWithContent(contentDescriptor);
        }
    }

    // The new intent contains the hashLock object that will unlock the hashlocked content.
    // Activity is singleTask only because upon a successful login CustomTab will start this
    // activity with the hash object. And the login callback can not provide the content descriptor.
    @Override
    protected void onNewIntent(Intent intent) {
        super.onNewIntent(intent);
        final Uri uri = intent.getData();
        if (uri != null) {
            final String hash = intent.getData().getQueryParameter(HASHLOCK_RESPONSE_PARAM);
            ustreamPlayer.clearError(); // Clear the hashlock error from player. It would otherwise report the last received error upon attach, but we already have the proper hash to set.
            setHashAndStartPlayback(hash);
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
    public void onHashReceived(final String hash) {
        setHashAndStartPlayback(hash);
    }

    private void setHashAndStartPlayback(String hash) {
        logger.debug("setting hash: {}", hash);
        ustreamPlayer.setHash(hash);
        ustreamPlayer.play();
        hashLockAuthButton.setVisibility(View.GONE);
    }

    private class ErrorListenerImpl extends EmptyErrorListener {

        public ErrorListenerImpl(Context context) {
            super(context);
        }

        @Override
        public void onHashLock() {
            logger.debug("error: {}", getString(R.string.sample_error_hashlocked_content_msg));
            hashLockAuthButton.setVisibility(View.VISIBLE);
        }
    }
}
