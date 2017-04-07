package md5529f98f7a08450076d539a34a6d9f932;


public class Name
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
		mono.android.Runtime.register ("HuffmanHenryAssn3.Name, HuffmanHenryAssn3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Name.class, __md_methods);
	}


	public Name () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Name.class)
			mono.android.TypeManager.Activate ("HuffmanHenryAssn3.Name, HuffmanHenryAssn3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
