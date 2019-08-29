using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='AutoResolvableResult']"
	[Register ("com/google/android/gms/wallet/AutoResolvableResult", "", "Com.Google.Android.Gms.Wallet.IAutoResolvableResultInvoker")]
	public partial interface IAutoResolvableResult : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='AutoResolvableResult']/method[@name='putIntoIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("putIntoIntent", "(Landroid/content/Intent;)V", "GetPutIntoIntent_Landroid_content_Intent_Handler:Com.Google.Android.Gms.Wallet.IAutoResolvableResultInvoker, JavaBindingExample")]
		void PutIntoIntent (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/wallet/AutoResolvableResult", DoNotGenerateAcw=true)]
	internal class IAutoResolvableResultInvoker : global::Java.Lang.Object, IAutoResolvableResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/AutoResolvableResult", typeof (IAutoResolvableResultInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAutoResolvableResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAutoResolvableResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.AutoResolvableResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAutoResolvableResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_putIntoIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetPutIntoIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_putIntoIntent_Landroid_content_Intent_ == null)
				cb_putIntoIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutIntoIntent_Landroid_content_Intent_);
			return cb_putIntoIntent_Landroid_content_Intent_;
		}

		static void n_PutIntoIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Wallet.IAutoResolvableResult __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.IAutoResolvableResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutIntoIntent (p0);
		}
#pragma warning restore 0169

		IntPtr id_putIntoIntent_Landroid_content_Intent_;
		public unsafe void PutIntoIntent (global::Android.Content.Intent p0)
		{
			if (id_putIntoIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_putIntoIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "putIntoIntent", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putIntoIntent_Landroid_content_Intent_, __args);
		}

	}

}
