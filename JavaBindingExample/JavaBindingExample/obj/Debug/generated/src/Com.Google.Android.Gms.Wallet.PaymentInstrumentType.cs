using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']"
	[global::Android.Runtime.Register ("com/google/android/gms/wallet/PaymentInstrumentType", DoNotGenerateAcw=true)]
	public sealed partial class PaymentInstrumentType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/field[@name='AMEX']"
		[Register ("AMEX")]
		public const int Amex = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/field[@name='DISCOVER']"
		[Register ("DISCOVER")]
		public const int Discover = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/field[@name='JCB']"
		[Register ("JCB")]
		public const int Jcb = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/field[@name='MASTER_CARD']"
		[Register ("MASTER_CARD")]
		public const int MasterCard = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/field[@name='VISA']"
		[Register ("VISA")]
		public const int Visa = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/PaymentInstrumentType", typeof (PaymentInstrumentType));
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

		internal PaymentInstrumentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/constructor[@name='PaymentInstrumentType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentInstrumentType ()
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

		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='PaymentInstrumentType']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/ArrayList;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
