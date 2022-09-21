package crc648136db5165ab3b0c;


public abstract class HeaderViewProvider
	extends crc648136db5165ab3b0c.CellViewProvider_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Wrappers.HeaderViewProvider, DevExpress.Maui.Editors", HeaderViewProvider.class, __md_methods);
	}


	public HeaderViewProvider ()
	{
		super ();
		if (getClass () == HeaderViewProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Wrappers.HeaderViewProvider, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
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
