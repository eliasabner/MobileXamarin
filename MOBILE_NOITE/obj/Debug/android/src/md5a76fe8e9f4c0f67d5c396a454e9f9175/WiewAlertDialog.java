package md5a76fe8e9f4c0f67d5c396a454e9f9175;


public class WiewAlertDialog
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MOBILE_NOITE.WiewAlertDialog, MOBILE_NOITE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WiewAlertDialog.class, __md_methods);
	}


	public WiewAlertDialog ()
	{
		super ();
		if (getClass () == WiewAlertDialog.class)
			mono.android.TypeManager.Activate ("MOBILE_NOITE.WiewAlertDialog, MOBILE_NOITE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
