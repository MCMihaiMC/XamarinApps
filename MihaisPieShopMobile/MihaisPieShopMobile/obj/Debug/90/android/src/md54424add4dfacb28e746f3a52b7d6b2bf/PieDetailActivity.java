package md54424add4dfacb28e746f3a52b7d6b2bf;


public class PieDetailActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MihaisPieShopMobile.PieDetailActivity, MihaisPieShopMobile", PieDetailActivity.class, __md_methods);
	}


	public PieDetailActivity ()
	{
		super ();
		if (getClass () == PieDetailActivity.class)
			mono.android.TypeManager.Activate ("MihaisPieShopMobile.PieDetailActivity, MihaisPieShopMobile", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
