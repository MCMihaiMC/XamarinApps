using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.Mediaplayer.Exo {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='ExoLoggingUtil']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/mediaplayer/exo/ExoLoggingUtil", DoNotGenerateAcw=true)]
	public sealed partial class ExoLoggingUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/mediaplayer/exo/ExoLoggingUtil", typeof (ExoLoggingUtil));
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

		internal ExoLoggingUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
