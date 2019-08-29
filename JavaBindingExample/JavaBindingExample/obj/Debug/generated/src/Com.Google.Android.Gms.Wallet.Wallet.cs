using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet']"
	[global::Android.Runtime.Register ("com/google/android/gms/wallet/Wallet", DoNotGenerateAcw=true)]
	public sealed partial class Wallet : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet.WalletOptions.Builder']"
		[global::Android.Runtime.Register ("com/google/android/gms/wallet/Wallet$WalletOptions$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/Wallet$WalletOptions$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet.WalletOptions.Builder']/constructor[@name='Wallet.WalletOptions.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet.WalletOptions.Builder']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEnvironment", "(I)Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;", "")]
			public unsafe global::Com.Google.Android.Gms.Wallet.Wallet.Builder SetEnvironment (int p0)
			{
				const string __id = "setEnvironment.(I)Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.Wallet.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet.WalletOptions.Builder']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTheme", "(I)Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;", "")]
			public unsafe global::Com.Google.Android.Gms.Wallet.Wallet.Builder SetTheme (int p0)
			{
				const string __id = "setTheme.(I)Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.Wallet.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='Wallet.WalletOptions.Builder']/method[@name='useGoogleWallet' and count(parameter)=0]"
			[Obsolete (@"deprecated")]
			[Register ("useGoogleWallet", "()Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;", "")]
			public unsafe global::Com.Google.Android.Gms.Wallet.Wallet.Builder UseGoogleWallet ()
			{
				const string __id = "useGoogleWallet.()Lcom/google/android/gms/wallet/Wallet$WalletOptions$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.Wallet.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/Wallet", typeof (Wallet));
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

		internal Wallet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
