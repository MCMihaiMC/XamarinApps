using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet.Wobs {

	[Register ("com/google/android/gms/wallet/wobs/WalletObjectsConstants$State", DoNotGenerateAcw=true)]
	public abstract class WalletObjectsConstantsState : Java.Lang.Object {

		internal WalletObjectsConstantsState ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjectsConstants.State']/field[@name='ACTIVE']"
		[Register ("ACTIVE")]
		public const int Active = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjectsConstants.State']/field[@name='COMPLETED']"
		[Register ("COMPLETED")]
		public const int Completed = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjectsConstants.State']/field[@name='EXPIRED']"
		[Register ("EXPIRED")]
		public const int Expired = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjectsConstants.State']/field[@name='INACTIVE']"
		[Register ("INACTIVE")]
		public const int Inactive = (int) 5;
	}

	[Register ("com/google/android/gms/wallet/wobs/WalletObjectsConstants$State", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'WalletObjectsConstantsState' type. This type will be removed in a future release.")]
	public abstract class WalletObjectsConstantsStateConsts : WalletObjectsConstantsState {

		private WalletObjectsConstantsStateConsts ()
		{
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet.wobs']/interface[@name='WalletObjectsConstants']"
	[Register ("com/google/android/gms/wallet/wobs/WalletObjectsConstants", "", "Com.Google.Android.Gms.Wallet.Wobs.IWalletObjectsConstantsInvoker")]
	public partial interface IWalletObjectsConstants : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/google/android/gms/wallet/wobs/WalletObjectsConstants", DoNotGenerateAcw=true)]
	internal class IWalletObjectsConstantsInvoker : global::Java.Lang.Object, IWalletObjectsConstants {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/wobs/WalletObjectsConstants", typeof (IWalletObjectsConstantsInvoker));

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

		public static IWalletObjectsConstants GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWalletObjectsConstants> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.wobs.WalletObjectsConstants"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWalletObjectsConstantsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
