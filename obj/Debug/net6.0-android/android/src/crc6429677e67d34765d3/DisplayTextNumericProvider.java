package crc6429677e67d34765d3;


public class DisplayTextNumericProvider
	extends crc6429677e67d34765d3.DisplayTextProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Android.DisplayTextNumericProvider, DevExpress.Maui.Editors", DisplayTextNumericProvider.class, __md_methods);
	}


	public DisplayTextNumericProvider ()
	{
		super ();
		if (getClass () == DisplayTextNumericProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Android.DisplayTextNumericProvider, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
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
