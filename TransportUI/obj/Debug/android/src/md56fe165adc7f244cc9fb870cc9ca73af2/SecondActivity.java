package md56fe165adc7f244cc9fb870cc9ca73af2;


public class SecondActivity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TransportUI.SecondActivity, TransportUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SecondActivity.class, __md_methods);
	}


	public SecondActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SecondActivity.class)
			mono.android.TypeManager.Activate ("TransportUI.SecondActivity, TransportUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
