package mono.com.squareup.picasso;


public class Picasso_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.squareup.picasso.Picasso.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onImageLoadFailed:(Lcom/squareup/picasso/Picasso;Landroid/net/Uri;Ljava/lang/Exception;)V:GetOnImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_Handler:Com.Squareup.Picasso.Picasso/IListenerInvoker, JavaBindingExample\n" +
			"";
		mono.android.Runtime.register ("Com.Squareup.Picasso.Picasso+IListenerImplementor, JavaBindingExample", Picasso_ListenerImplementor.class, __md_methods);
	}


	public Picasso_ListenerImplementor ()
	{
		super ();
		if (getClass () == Picasso_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Squareup.Picasso.Picasso+IListenerImplementor, JavaBindingExample", "", this, new java.lang.Object[] {  });
	}


	public void onImageLoadFailed (com.squareup.picasso.Picasso p0, android.net.Uri p1, java.lang.Exception p2)
	{
		n_onImageLoadFailed (p0, p1, p2);
	}

	private native void n_onImageLoadFailed (com.squareup.picasso.Picasso p0, android.net.Uri p1, java.lang.Exception p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
