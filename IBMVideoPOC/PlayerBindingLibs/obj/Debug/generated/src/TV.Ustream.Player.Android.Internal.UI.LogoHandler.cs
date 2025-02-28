using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoHandler']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/ui/LogoHandler", DoNotGenerateAcw=true)]
	public partial class LogoHandler : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/ui/LogoHandler", typeof (LogoHandler));
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

		protected LogoHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoHandler']/constructor[@name='LogoHandler' and count(parameter)=1 and parameter[1][@type='tv.ustream.player.android.internal.ui.LogoLayout']]"
		[Register (".ctor", "(Ltv/ustream/player/android/internal/ui/LogoLayout;)V", "")]
		public unsafe LogoHandler (global::TV.Ustream.Player.Android.Internal.UI.LogoLayout p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ltv/ustream/player/android/internal/ui/LogoLayout;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
