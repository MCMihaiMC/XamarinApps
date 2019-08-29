using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='AutoResolveHelper']"
	[global::Android.Runtime.Register ("com/google/android/gms/wallet/AutoResolveHelper", DoNotGenerateAcw=true)]
	public partial class AutoResolveHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='AutoResolveHelper']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/AutoResolveHelper", typeof (AutoResolveHelper));
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

		protected AutoResolveHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
