package crc648136db5165ab3b0c;


public class EditBaseWrapper_3_OnEditActionListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.editors.OnEditActionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEditorAction:(I)Z:GetOnEditorAction_IHandler:DevExpress.Xamarin.Android.Editors.IOnEditActionListenerInvoker, DevExpress.Maui.Android.Editors\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Wrappers.EditBaseWrapper`3+OnEditActionListener, DevExpress.Maui.Editors", EditBaseWrapper_3_OnEditActionListener.class, __md_methods);
	}


	public EditBaseWrapper_3_OnEditActionListener ()
	{
		super ();
		if (getClass () == EditBaseWrapper_3_OnEditActionListener.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Wrappers.EditBaseWrapper`3+OnEditActionListener, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
	}


	public boolean onEditorAction (int p0)
	{
		return n_onEditorAction (p0);
	}

	private native boolean n_onEditorAction (int p0);

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
