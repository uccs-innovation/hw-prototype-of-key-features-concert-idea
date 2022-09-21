package crc6455904b5a4bb8e215;


public class GroupRowSummaryViewProvider
	extends crc6455904b5a4bb8e215.GroupRowValueViewProviderBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Maui.DataGrid.Android.GroupRowSummaryViewProvider, DevExpress.Maui.DataGrid", GroupRowSummaryViewProvider.class, __md_methods);
	}


	public GroupRowSummaryViewProvider ()
	{
		super ();
		if (getClass () == GroupRowSummaryViewProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.DataGrid.Android.GroupRowSummaryViewProvider, DevExpress.Maui.DataGrid", "", this, new java.lang.Object[] {  });
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
