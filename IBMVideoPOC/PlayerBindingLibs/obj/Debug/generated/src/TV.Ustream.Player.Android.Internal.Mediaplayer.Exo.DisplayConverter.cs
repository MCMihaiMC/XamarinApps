using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.Mediaplayer.Exo {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter", DoNotGenerateAcw=true)]
	public partial class DisplayConverter : global::Java.Lang.Object, global::Android.Views.ISurfaceHolderCallback, global::Android.Views.TextureView.ISurfaceTextureListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/interface[@name='DisplayConverter.Listener']"
		[Register ("tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter$Listener", "", "TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/interface[@name='DisplayConverter.Listener']/method[@name='onTextOutputDestroyed' and count(parameter)=0]"
			[Register ("onTextOutputDestroyed", "()V", "GetOnTextOutputDestroyedHandler:TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter/IListenerInvoker, PlayerBindingLibs")]
			void OnTextOutputDestroyed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/interface[@name='DisplayConverter.Listener']/method[@name='onVideoOutputAvailable' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
			[Register ("onVideoOutputAvailable", "(Landroid/view/Surface;)V", "GetOnVideoOutputAvailable_Landroid_view_Surface_Handler:TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter/IListenerInvoker, PlayerBindingLibs")]
			void OnVideoOutputAvailable (global::Android.Views.Surface p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/interface[@name='DisplayConverter.Listener']/method[@name='onVideoOutputDestroyed' and count(parameter)=0]"
			[Register ("onVideoOutputDestroyed", "()V", "GetOnVideoOutputDestroyedHandler:TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter/IListenerInvoker, PlayerBindingLibs")]
			void OnVideoOutputDestroyed ();

		}

		[global::Android.Runtime.Register ("tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter$Listener", typeof (IListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "tv.ustream.player.android.internal.mediaplayer.exo.DisplayConverter.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTextOutputDestroyed;
#pragma warning disable 0169
			static Delegate GetOnTextOutputDestroyedHandler ()
			{
				if (cb_onTextOutputDestroyed == null)
					cb_onTextOutputDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTextOutputDestroyed);
				return cb_onTextOutputDestroyed;
			}

			static void n_OnTextOutputDestroyed (IntPtr jnienv, IntPtr native__this)
			{
				global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTextOutputDestroyed ();
			}
#pragma warning restore 0169

			IntPtr id_onTextOutputDestroyed;
			public unsafe void OnTextOutputDestroyed ()
			{
				if (id_onTextOutputDestroyed == IntPtr.Zero)
					id_onTextOutputDestroyed = JNIEnv.GetMethodID (class_ref, "onTextOutputDestroyed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextOutputDestroyed);
			}

			static Delegate cb_onVideoOutputAvailable_Landroid_view_Surface_;
#pragma warning disable 0169
			static Delegate GetOnVideoOutputAvailable_Landroid_view_Surface_Handler ()
			{
				if (cb_onVideoOutputAvailable_Landroid_view_Surface_ == null)
					cb_onVideoOutputAvailable_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnVideoOutputAvailable_Landroid_view_Surface_);
				return cb_onVideoOutputAvailable_Landroid_view_Surface_;
			}

			static void n_OnVideoOutputAvailable_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoOutputAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVideoOutputAvailable_Landroid_view_Surface_;
			public unsafe void OnVideoOutputAvailable (global::Android.Views.Surface p0)
			{
				if (id_onVideoOutputAvailable_Landroid_view_Surface_ == IntPtr.Zero)
					id_onVideoOutputAvailable_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "onVideoOutputAvailable", "(Landroid/view/Surface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoOutputAvailable_Landroid_view_Surface_, __args);
			}

			static Delegate cb_onVideoOutputDestroyed;
#pragma warning disable 0169
			static Delegate GetOnVideoOutputDestroyedHandler ()
			{
				if (cb_onVideoOutputDestroyed == null)
					cb_onVideoOutputDestroyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoOutputDestroyed);
				return cb_onVideoOutputDestroyed;
			}

			static void n_OnVideoOutputDestroyed (IntPtr jnienv, IntPtr native__this)
			{
				global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoOutputDestroyed ();
			}
#pragma warning restore 0169

			IntPtr id_onVideoOutputDestroyed;
			public unsafe void OnVideoOutputDestroyed ()
			{
				if (id_onVideoOutputDestroyed == IntPtr.Zero)
					id_onVideoOutputDestroyed = JNIEnv.GetMethodID (class_ref, "onVideoOutputDestroyed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoOutputDestroyed);
			}

		}

		// event args for tv.ustream.player.android.internal.mediaplayer.exo.DisplayConverter.Listener.onVideoOutputAvailable
		public partial class VideoOutputAvailableEventArgs : global::System.EventArgs {

			public VideoOutputAvailableEventArgs (global::Android.Views.Surface p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.Surface p0;
			public global::Android.Views.Surface P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnTextOutputDestroyedHandler;
#pragma warning restore 0649

			public void OnTextOutputDestroyed ()
			{
				var __h = OnTextOutputDestroyedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<VideoOutputAvailableEventArgs> OnVideoOutputAvailableHandler;
#pragma warning restore 0649

			public void OnVideoOutputAvailable (global::Android.Views.Surface p0)
			{
				var __h = OnVideoOutputAvailableHandler;
				if (__h != null)
					__h (sender, new VideoOutputAvailableEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnVideoOutputDestroyedHandler;
#pragma warning restore 0649

			public void OnVideoOutputDestroyed ()
			{
				var __h = OnVideoOutputDestroyedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnTextOutputDestroyedHandler == null && value.OnVideoOutputAvailableHandler == null && value.OnVideoOutputDestroyedHandler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/mediaplayer/exo/DisplayConverter", typeof (DisplayConverter));
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

		protected DisplayConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/constructor[@name='DisplayConverter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DisplayConverter (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='onSurfaceTextureAvailable' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureAvailable (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			const string __id = "onSurfaceTextureAvailable.(Landroid/graphics/SurfaceTexture;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		}

		static bool n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSurfaceTextureDestroyed (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='onSurfaceTextureDestroyed' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", "GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe bool OnSurfaceTextureDestroyed (global::Android.Graphics.SurfaceTexture p0)
		{
			const string __id = "onSurfaceTextureDestroyed.(Landroid/graphics/SurfaceTexture;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='onSurfaceTextureSizeChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureSizeChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			const string __id = "onSurfaceTextureSizeChanged.(Landroid/graphics/SurfaceTexture;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureUpdated (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='onSurfaceTextureUpdated' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", "GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnSurfaceTextureUpdated (global::Android.Graphics.SurfaceTexture p0)
		{
			const string __id = "onSurfaceTextureUpdated.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			const string __id = "surfaceChanged.(Landroid/view/SurfaceHolder;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			const string __id = "surfaceCreated.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.Mediaplayer.Exo.DisplayConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.mediaplayer.exo']/class[@name='DisplayConverter']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			const string __id = "surfaceDestroyed.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
