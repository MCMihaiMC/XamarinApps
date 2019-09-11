package md57fda4b2a7ec36a6cba009c90f7d43c1f;


public class PieViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MihaisPieShopMobile.ViewHolders.PieViewHolder, MihaisPieShopMobile", PieViewHolder.class, __md_methods);
	}


	public PieViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == PieViewHolder.class)
			mono.android.TypeManager.Activate ("MihaisPieShopMobile.ViewHolders.PieViewHolder, MihaisPieShopMobile", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
