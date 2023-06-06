package crc6454d2e78dafc1cb11;


public class OTP_Activity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Group2_IT123P_MP.Menu.OTP_Activity, Group2_IT123P_MP", OTP_Activity.class, __md_methods);
	}


	public OTP_Activity ()
	{
		super ();
		if (getClass () == OTP_Activity.class) {
			mono.android.TypeManager.Activate ("Group2_IT123P_MP.Menu.OTP_Activity, Group2_IT123P_MP", "", this, new java.lang.Object[] {  });
		}
	}


	public OTP_Activity (int p0)
	{
		super (p0);
		if (getClass () == OTP_Activity.class) {
			mono.android.TypeManager.Activate ("Group2_IT123P_MP.Menu.OTP_Activity, Group2_IT123P_MP", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
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
