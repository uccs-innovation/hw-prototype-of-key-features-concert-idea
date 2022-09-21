package crc6455904b5a4bb8e215;


public class ColumnHeaderViewProvider
	extends crc6455904b5a4bb8e215.ViewProviderBase
	implements
		mono.android.IGCUserPeer,
		com.devexpress.dxgrid.providers.ColumnHeaderViewProvider
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getColumnHeaderView:(Landroid/content/Context;I)Landroid/view/View;:GetGetColumnHeaderView_Landroid_content_Context_IHandler:DevExpress.XamarinAndroid.Grid.IColumnHeaderViewProviderInvoker, DevExpress.Maui.Android.Grid\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Maui.DataGrid.Android.ColumnHeaderViewProvider, DevExpress.Maui.DataGrid", ColumnHeaderViewProvider.class, __md_methods);
	}


	public ColumnHeaderViewProvider ()
	{
		super ();
		if (getClass () == ColumnHeaderViewProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.DataGrid.Android.ColumnHeaderViewProvider, DevExpress.Maui.DataGrid", "", this, new java.lang.Object[] {  });
	}


	public android.view.View getColumnHeaderView (android.content.Context p0, int p1)
	{
		return n_getColumnHeaderView (p0, p1);
	}

	private native android.view.View n_getColumnHeaderView (android.content.Context p0, int p1);

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
