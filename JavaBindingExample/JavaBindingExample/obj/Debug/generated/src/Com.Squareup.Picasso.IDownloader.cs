using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']"
	[global::Android.Runtime.Register ("com/squareup/picasso/Downloader$Response", DoNotGenerateAcw=true)]
	public partial class DownloaderResponse : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Downloader$Response", typeof (DownloaderResponse));
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

		protected DownloaderResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/constructor[@name='Downloader.Response' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Z)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DownloaderResponse (global::Android.Graphics.Bitmap bitmap, bool loadedFromCache)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/Bitmap;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (loadedFromCache);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/constructor[@name='Downloader.Response' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;ZJ)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DownloaderResponse (global::Android.Graphics.Bitmap bitmap, bool loadedFromCache, long contentLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/Bitmap;ZJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (loadedFromCache);
				__args [2] = new JniArgumentValue (contentLength);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/constructor[@name='Downloader.Response' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/InputStream;Z)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe DownloaderResponse (global::System.IO.Stream stream, bool loadedFromCache)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_stream);
				__args [1] = new JniArgumentValue (loadedFromCache);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/constructor[@name='Downloader.Response' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/io/InputStream;ZJ)V", "")]
		public unsafe DownloaderResponse (global::System.IO.Stream stream, bool loadedFromCache, long contentLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;ZJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_stream);
				__args [1] = new JniArgumentValue (loadedFromCache);
				__args [2] = new JniArgumentValue (contentLength);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		[Obsolete]
		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.DownloaderResponse __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.DownloaderResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.DownloaderResponse __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.DownloaderResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				const string __id = "getContentLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.DownloaderResponse __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.DownloaderResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.Response']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.ResponseException']"
	[global::Android.Runtime.Register ("com/squareup/picasso/Downloader$ResponseException", DoNotGenerateAcw=true)]
	public partial class DownloaderResponseException : global::Java.IO.IOException {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Downloader$ResponseException", typeof (DownloaderResponseException));
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

		protected DownloaderResponseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Downloader.ResponseException']/constructor[@name='Downloader.ResponseException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;II)V", "")]
		public unsafe DownloaderResponseException (string message, int networkPolicy, int responseCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;II)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (networkPolicy);
				__args [2] = new JniArgumentValue (responseCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Downloader']"
	[Register ("com/squareup/picasso/Downloader", "", "Com.Squareup.Picasso.IDownloaderInvoker")]
	public partial interface IDownloader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Downloader']/method[@name='load' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("load", "(Landroid/net/Uri;I)Lcom/squareup/picasso/Downloader$Response;", "GetLoad_Landroid_net_Uri_IHandler:Com.Squareup.Picasso.IDownloaderInvoker, JavaBindingExample")]
		global::Com.Squareup.Picasso.DownloaderResponse Load (global::Android.Net.Uri p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Downloader']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler:Com.Squareup.Picasso.IDownloaderInvoker, JavaBindingExample")]
		void Shutdown ();

	}

	[global::Android.Runtime.Register ("com/squareup/picasso/Downloader", DoNotGenerateAcw=true)]
	internal class IDownloaderInvoker : global::Java.Lang.Object, IDownloader {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/picasso/Downloader", typeof (IDownloaderInvoker));

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

		public static IDownloader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDownloader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.picasso.Downloader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDownloaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_load_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetLoad_Landroid_net_Uri_IHandler ()
		{
			if (cb_load_Landroid_net_Uri_I == null)
				cb_load_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Load_Landroid_net_Uri_I);
			return cb_load_Landroid_net_Uri_I;
		}

		static IntPtr n_Load_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Squareup.Picasso.IDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.IDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_load_Landroid_net_Uri_I;
		public unsafe global::Com.Squareup.Picasso.DownloaderResponse Load (global::Android.Net.Uri p0, int p1)
		{
			if (id_load_Landroid_net_Uri_I == IntPtr.Zero)
				id_load_Landroid_net_Uri_I = JNIEnv.GetMethodID (class_ref, "load", "(Landroid/net/Uri;I)Lcom/squareup/picasso/Downloader$Response;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			global::Com.Squareup.Picasso.DownloaderResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.DownloaderResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_load_Landroid_net_Uri_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.IDownloader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.IDownloader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
		}

	}

}
