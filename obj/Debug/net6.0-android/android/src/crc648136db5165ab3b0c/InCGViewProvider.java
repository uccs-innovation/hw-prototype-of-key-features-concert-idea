package crc648136db5165ab3b0c;


public class InCGViewProvider
	extends crc648136db5165ab3b0c.CGViewProvider_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Wrappers.InCGViewProvider, DevExpress.Maui.Editors", InCGViewProvider.class, __md_methods);
	}


	public InCGViewProvider ()
	{
		super ();
		if (getClass () == InCGViewProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Wrappers.InCGViewProvider, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
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
