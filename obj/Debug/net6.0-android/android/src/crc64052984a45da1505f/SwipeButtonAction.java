package crc64052984a45da1505f;


public class SwipeButtonAction
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.dxgrid.providers.SwipeButtonAction
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTap:(I)V:GetOnTap_IHandler:DevExpress.XamarinAndroid.Grid.ISwipeButtonActionInvoker, DevExpress.Maui.Android.Grid\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Maui.DataGrid.Android.NativeBridge.SwipeButtonAction, DevExpress.Maui.DataGrid", SwipeButtonAction.class, __md_methods);
	}


	public SwipeButtonAction ()
	{
		super ();
		if (getClass () == SwipeButtonAction.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.DataGrid.Android.NativeBridge.SwipeButtonAction, DevExpress.Maui.DataGrid", "", this, new java.lang.Object[] {  });
	}


	public void onTap (int p0)
	{
		n_onTap (p0);
	}

	private native void n_onTap (int p0);

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
