using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android']/class[@name='UstreamPlayerFactory']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/UstreamPlayerFactory", DoNotGenerateAcw=true)]
	public sealed partial class UstreamPlayerFactory : global::TV.Ustream.Player.Android.Internal.Player.UstreamPlayerFactoryBase {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/UstreamPlayerFactory", typeof (UstreamPlayerFactory));
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

		internal UstreamPlayerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
