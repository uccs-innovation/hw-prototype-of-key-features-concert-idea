package crc6424c1bd9050dc6c1b;


public class DataFormComboBoxEditor
	extends crc6424c1bd9050dc6c1b.DataFormEditorBase_2
	implements
		mono.android.IGCUserPeer,
		com.devexpress.editors.dataForm.protocols.DataFormPickerItem
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setPickerDataProvider:(Lcom/devexpress/editors/dataForm/protocols/DataFormPickerItemDataProvider;)V:GetSetPickerDataProvider_Lcom_devexpress_editors_dataForm_protocols_DataFormPickerItemDataProvider_Handler:Com.Devexpress.Editors.DataForm.Protocols.IDataFormPickerItemInvoker, DevExpress.Maui.Android.Editors\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.DataForm.Editors.DataFormComboBoxEditor, DevExpress.Maui.Editors", DataFormComboBoxEditor.class, __md_methods);
	}


	public DataFormComboBoxEditor (android.view.View p0)
	{
		super (p0);
		if (getClass () == DataFormComboBoxEditor.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.DataForm.Editors.DataFormComboBoxEditor, DevExpress.Maui.Editors", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public DataFormComboBoxEditor (android.view.View p0, com.devexpress.editors.dataForm.protocols.DXDataFormEditorItemErrorProvider p1)
	{
		super (p0, p1);
		if (getClass () == DataFormComboBoxEditor.class)
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.DataForm.Editors.DataFormComboBoxEditor, DevExpress.Maui.Editors", "Android.Views.View, Mono.Android:Com.Devexpress.Editors.DataForm.Protocols.DXDataFormEditorItemErrorProvider, DevExpress.Maui.Android.Editors", this, new java.lang.Object[] { p0, p1 });
	}


	public void setPickerDataProvider (com.devexpress.editors.dataForm.protocols.DataFormPickerItemDataProvider p0)
	{
		n_setPickerDataProvider (p0);
	}

	private native void n_setPickerDataProvider (com.devexpress.editors.dataForm.protocols.DataFormPickerItemDataProvider p0);

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
