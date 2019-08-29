using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='AutoResolvableVoidResult']"
	[global::Android.Runtime.Register ("com/google/android/gms/wallet/AutoResolvableVoidResult", DoNotGenerateAcw=true)]
	public partial class AutoResolvableVoidResult : global::Java.Lang.Object, global::Com.Google.Android.Gms.Wallet.IAutoResolvableResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/AutoResolvableVoidResult", typeof (AutoResolvableVoidResult));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AutoResolvableVoidResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='AutoResolvableVoidResult']/constructor[@name='AutoResolvableVoidResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AutoResolvableVoidResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
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
			global::Com.Google.Android.Gms.Wallet.AutoResolvableVoidResult __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.AutoResolvableVoidResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutIntoIntent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='AutoResolvableVoidResult']/method[@name='putIntoIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("putIntoIntent", "(Landroid/content/Intent;)V", "GetPutIntoIntent_Landroid_content_Intent_Handler")]
		public virtual unsafe void PutIntoIntent (global::Android.Content.Intent p0)
		{
			const string __id = "putIntoIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
