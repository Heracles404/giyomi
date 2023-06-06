package crc64b586044d1ed0f36a;


public class Start_Activity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"";
		mono.android.Runtime.register ("Group2_IT123P_MP.Start_Activity, Group2_IT123P_MP", Start_Activity.class, __md_methods);
	}


	public Start_Activity ()
	{
		super ();
		if (getClass () == Start_Activity.class) {
			mono.android.TypeManager.Activate ("Group2_IT123P_MP.Start_Activity, Group2_IT123P_MP", "", this, new java.lang.Object[] {  });
		}
	}


	public Start_Activity (int p0)
	{
		super (p0);
		if (getClass () == Start_Activity.class) {
			mono.android.TypeManager.Activate ("Group2_IT123P_MP.Start_Activity, Group2_IT123P_MP", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);

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
