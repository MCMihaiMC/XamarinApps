using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.Trackselection {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo.trackselection']/class[@name='ExoTrackGroupBinder']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/mediaplayer/exo/trackselection/ExoTrackGroupBinder", DoNotGenerateAcw=true)]
	public partial class ExoTrackGroupBinder : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/mediaplayer/exo/trackselection/ExoTrackGroupBinder", typeof (ExoTrackGroupBinder));
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

		protected ExoTrackGroupBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo.trackselection']/class[@name='ExoTrackGroupBinder']/constructor[@name='ExoTrackGroupBinder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExoTrackGroupBinder ()
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

	}
}
