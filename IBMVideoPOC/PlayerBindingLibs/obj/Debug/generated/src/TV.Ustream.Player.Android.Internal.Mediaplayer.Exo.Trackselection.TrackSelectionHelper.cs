using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.Trackselection {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo.trackselection']/class[@name='TrackSelectionHelper']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/mediaplayer/exo/trackselection/TrackSelectionHelper", DoNotGenerateAcw=true)]
	public partial class TrackSelectionHelper : global::Java.Lang.Object, global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.Trackselection.ITrackInfoProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/mediaplayer/exo/trackselection/TrackSelectionHelper", typeof (TrackSelectionHelper));
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

		protected TrackSelectionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTrackFormatSupport_III;
#pragma warning disable 0169
		static Delegate GetGetTrackFormatSupport_IIIHandler ()
		{
			if (cb_getTrackFormatSupport_III == null)
				cb_getTrackFormatSupport_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int>) n_GetTrackFormatSupport_III);
			return cb_getTrackFormatSupport_III;
		}

		static int n_GetTrackFormatSupport_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.Trackselection.TrackSelectionHelper __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.Trackselection.TrackSelectionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTrackFormatSupport (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo.trackselection']/class[@name='TrackSelectionHelper']/method[@name='getTrackFormatSupport' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTrackFormatSupport", "(III)I", "GetGetTrackFormatSupport_IIIHandler")]
		public virtual unsafe int GetTrackFormatSupport (int p0, int p1, int p2)
		{
			const string __id = "getTrackFormatSupport.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
