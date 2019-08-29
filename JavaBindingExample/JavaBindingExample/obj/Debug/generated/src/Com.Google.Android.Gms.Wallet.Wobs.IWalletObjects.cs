using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet.Wobs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjects']"
	[Register ("com/google/android/gms/wallet/wobs/WalletObjects", "", "Com.Google.Android.Gms.Wallet.Wobs.IWalletObjectsInvoker")]
	public partial interface IWalletObjects : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/google/android/gms/wallet/wobs/WalletObjects", DoNotGenerateAcw=true)]
	internal class IWalletObjectsInvoker : global::Java.Lang.Object, IWalletObjects {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/wobs/WalletObjects", typeof (IWalletObjectsInvoker));

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

		public static IWalletObjects GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWalletObjects> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.wobs.WalletObjects"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWalletObjectsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
