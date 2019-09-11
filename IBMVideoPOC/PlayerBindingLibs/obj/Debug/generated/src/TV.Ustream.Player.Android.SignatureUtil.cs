using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android']/class[@name='SignatureUtil']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/SignatureUtil", DoNotGenerateAcw=true)]
	public sealed partial class SignatureUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/SignatureUtil", typeof (SignatureUtil));
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

		internal SignatureUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.ustream.player.android']/class[@name='SignatureUtil']/constructor[@name='SignatureUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SignatureUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android']/class[@name='SignatureUtil']/method[@name='keyHashFromContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("keyHashFromContext", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string KeyHashFromContext (global::Android.Content.Context p0)
		{
			const string __id = "keyHashFromContext.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
