using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.player']/class[@name='UstreamPlayerFactoryBase']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/player/UstreamPlayerFactoryBase", DoNotGenerateAcw=true)]
	public abstract partial class UstreamPlayerFactoryBase : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/player/UstreamPlayerFactoryBase", typeof (UstreamPlayerFactoryBase));
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

		protected UstreamPlayerFactoryBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/player/UstreamPlayerFactoryBase", DoNotGenerateAcw=true)]
	internal partial class UstreamPlayerFactoryBaseInvoker : UstreamPlayerFactoryBase {

		public UstreamPlayerFactoryBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("tv/ustream/player/android/internal/player/UstreamPlayerFactoryBase", typeof (UstreamPlayerFactoryBaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
