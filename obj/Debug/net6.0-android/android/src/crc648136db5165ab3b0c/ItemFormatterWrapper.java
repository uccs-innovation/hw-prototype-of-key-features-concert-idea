package crc648136db5165ab3b0c;


public class ItemFormatterWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.editors.ComboBoxEdit.Formatter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_format:(Ljava/lang/Object;)Ljava/lang/String;:GetFormat_Ljava_lang_Object_Handler:DevExpress.Xamarin.Android.Editors.ComboBoxEdit/IFormatterInvoker, DevExpress.Maui.Android.Editors\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Wrappers.ItemFormatterWrapper, DevExpress.Maui.Editors", ItemFormatterWrapper.class, __md_methods);
	}


	public ItemFormatterWrapper ()
	{
		super ();
		if (getClass () == ItemFormatterWrapper.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Wrappers.ItemFormatterWrapper, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
	}


	public java.lang.String format (java.lang.Object p0)
	{
		return n_format (p0);
	}

	private native java.lang.String n_format (java.lang.Object p0);

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
