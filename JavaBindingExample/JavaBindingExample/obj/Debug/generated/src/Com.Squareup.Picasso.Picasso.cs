using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']"
	[global::Android.Runtime.Register ("com/squareup/picasso/Picasso", DoNotGenerateAcw=true)]
	public partial class Picasso : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']"
		[global::Android.Runtime.Register ("com/squareup/picasso/Picasso$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Picasso$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/constructor[@name='Picasso.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context context)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_addRequestHandler_Lcom_squareup_picasso_RequestHandler_;
#pragma warning disable 0169
			static Delegate GetAddRequestHandler_Lcom_squareup_picasso_RequestHandler_Handler ()
			{
				if (cb_addRequestHandler_Lcom_squareup_picasso_RequestHandler_ == null)
					cb_addRequestHandler_Lcom_squareup_picasso_RequestHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRequestHandler_Lcom_squareup_picasso_RequestHandler_);
				return cb_addRequestHandler_Lcom_squareup_picasso_RequestHandler_;
			}

			static IntPtr n_AddRequestHandler_Lcom_squareup_picasso_RequestHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestHandler)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.RequestHandler requestHandler = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestHandler> (native_requestHandler, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRequestHandler (requestHandler));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='addRequestHandler' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.RequestHandler']]"
			[Register ("addRequestHandler", "(Lcom/squareup/picasso/RequestHandler;)Lcom/squareup/picasso/Picasso$Builder;", "GetAddRequestHandler_Lcom_squareup_picasso_RequestHandler_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder AddRequestHandler (global::Com.Squareup.Picasso.RequestHandler requestHandler)
			{
				const string __id = "addRequestHandler.(Lcom/squareup/picasso/RequestHandler;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((requestHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestHandler).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/squareup/picasso/Picasso;", "GetBuildHandler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso Build ()
			{
				const string __id = "build.()Lcom/squareup/picasso/Picasso;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_debugging_Z;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetDebugging_ZHandler ()
			{
				if (cb_debugging_Z == null)
					cb_debugging_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Debugging_Z);
				return cb_debugging_Z;
			}

			[Obsolete]
			static IntPtr n_Debugging_Z (IntPtr jnienv, IntPtr native__this, bool debugging)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Debugging (debugging));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='debugging' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Obsolete (@"deprecated")]
			[Register ("debugging", "(Z)Lcom/squareup/picasso/Picasso$Builder;", "GetDebugging_ZHandler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder Debugging (bool debugging)
			{
				const string __id = "debugging.(Z)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (debugging);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_defaultBitmapConfig_Landroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
			static Delegate GetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler ()
			{
				if (cb_defaultBitmapConfig_Landroid_graphics_Bitmap_Config_ == null)
					cb_defaultBitmapConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DefaultBitmapConfig_Landroid_graphics_Bitmap_Config_);
				return cb_defaultBitmapConfig_Landroid_graphics_Bitmap_Config_;
			}

			static IntPtr n_DefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmapConfig)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.Config bitmapConfig = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_bitmapConfig, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DefaultBitmapConfig (bitmapConfig));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='defaultBitmapConfig' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
			[Register ("defaultBitmapConfig", "(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/Picasso$Builder;", "GetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder DefaultBitmapConfig (global::Android.Graphics.Bitmap.Config bitmapConfig)
			{
				const string __id = "defaultBitmapConfig.(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bitmapConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmapConfig).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_downloader_Lcom_squareup_picasso_Downloader_;
#pragma warning disable 0169
			static Delegate GetDownloader_Lcom_squareup_picasso_Downloader_Handler ()
			{
				if (cb_downloader_Lcom_squareup_picasso_Downloader_ == null)
					cb_downloader_Lcom_squareup_picasso_Downloader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Downloader_Lcom_squareup_picasso_Downloader_);
				return cb_downloader_Lcom_squareup_picasso_Downloader_;
			}

			static IntPtr n_Downloader_Lcom_squareup_picasso_Downloader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_downloader)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.IDownloader downloader = (global::Com.Squareup.Picasso.IDownloader)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.IDownloader> (native_downloader, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Downloader (downloader));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='downloader' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Downloader']]"
			[Register ("downloader", "(Lcom/squareup/picasso/Downloader;)Lcom/squareup/picasso/Picasso$Builder;", "GetDownloader_Lcom_squareup_picasso_Downloader_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder Downloader (global::Com.Squareup.Picasso.IDownloader downloader)
			{
				const string __id = "downloader.(Lcom/squareup/picasso/Downloader;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((downloader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downloader).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_executor_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
			static Delegate GetExecutor_Ljava_util_concurrent_ExecutorService_Handler ()
			{
				if (cb_executor_Ljava_util_concurrent_ExecutorService_ == null)
					cb_executor_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Executor_Ljava_util_concurrent_ExecutorService_);
				return cb_executor_Ljava_util_concurrent_ExecutorService_;
			}

			static IntPtr n_Executor_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_executorService)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Concurrent.IExecutorService executorService = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_executorService, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Executor (executorService));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='executor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
			[Register ("executor", "(Ljava/util/concurrent/ExecutorService;)Lcom/squareup/picasso/Picasso$Builder;", "GetExecutor_Ljava_util_concurrent_ExecutorService_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder Executor (global::Java.Util.Concurrent.IExecutorService executorService)
			{
				const string __id = "executor.(Ljava/util/concurrent/ExecutorService;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_indicatorsEnabled_Z;
#pragma warning disable 0169
			static Delegate GetIndicatorsEnabled_ZHandler ()
			{
				if (cb_indicatorsEnabled_Z == null)
					cb_indicatorsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_IndicatorsEnabled_Z);
				return cb_indicatorsEnabled_Z;
			}

			static IntPtr n_IndicatorsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IndicatorsEnabled (enabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='indicatorsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("indicatorsEnabled", "(Z)Lcom/squareup/picasso/Picasso$Builder;", "GetIndicatorsEnabled_ZHandler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder IndicatorsEnabled (bool enabled)
			{
				const string __id = "indicatorsEnabled.(Z)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_listener_Lcom_squareup_picasso_Picasso_Listener_;
#pragma warning disable 0169
			static Delegate GetListener_Lcom_squareup_picasso_Picasso_Listener_Handler ()
			{
				if (cb_listener_Lcom_squareup_picasso_Picasso_Listener_ == null)
					cb_listener_Lcom_squareup_picasso_Picasso_Listener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listener_Lcom_squareup_picasso_Picasso_Listener_);
				return cb_listener_Lcom_squareup_picasso_Picasso_Listener_;
			}

			static IntPtr n_Listener_Lcom_squareup_picasso_Picasso_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.Picasso.IListener listener = (global::Com.Squareup.Picasso.Picasso.IListener)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.IListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Picasso.Listener']]"
			[Register ("listener", "(Lcom/squareup/picasso/Picasso$Listener;)Lcom/squareup/picasso/Picasso$Builder;", "GetListener_Lcom_squareup_picasso_Picasso_Listener_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder Listener (global::Com.Squareup.Picasso.Picasso.IListener listener)
			{
				const string __id = "listener.(Lcom/squareup/picasso/Picasso$Listener;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_loggingEnabled_Z;
#pragma warning disable 0169
			static Delegate GetLoggingEnabled_ZHandler ()
			{
				if (cb_loggingEnabled_Z == null)
					cb_loggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_LoggingEnabled_Z);
				return cb_loggingEnabled_Z;
			}

			static IntPtr n_LoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.LoggingEnabled (enabled));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='loggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("loggingEnabled", "(Z)Lcom/squareup/picasso/Picasso$Builder;", "GetLoggingEnabled_ZHandler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder LoggingEnabled (bool enabled)
			{
				const string __id = "loggingEnabled.(Z)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_memoryCache_Lcom_squareup_picasso_Cache_;
#pragma warning disable 0169
			static Delegate GetMemoryCache_Lcom_squareup_picasso_Cache_Handler ()
			{
				if (cb_memoryCache_Lcom_squareup_picasso_Cache_ == null)
					cb_memoryCache_Lcom_squareup_picasso_Cache_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MemoryCache_Lcom_squareup_picasso_Cache_);
				return cb_memoryCache_Lcom_squareup_picasso_Cache_;
			}

			static IntPtr n_MemoryCache_Lcom_squareup_picasso_Cache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_memoryCache)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.ICache memoryCache = (global::Com.Squareup.Picasso.ICache)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (native_memoryCache, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MemoryCache (memoryCache));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='memoryCache' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Cache']]"
			[Register ("memoryCache", "(Lcom/squareup/picasso/Cache;)Lcom/squareup/picasso/Picasso$Builder;", "GetMemoryCache_Lcom_squareup_picasso_Cache_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder MemoryCache (global::Com.Squareup.Picasso.ICache memoryCache)
			{
				const string __id = "memoryCache.(Lcom/squareup/picasso/Cache;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((memoryCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memoryCache).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_requestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_;
#pragma warning disable 0169
			static Delegate GetRequestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_Handler ()
			{
				if (cb_requestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_ == null)
					cb_requestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_);
				return cb_requestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_;
			}

			static IntPtr n_RequestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformer)
			{
				global::Com.Squareup.Picasso.Picasso.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.Picasso.IRequestTransformer transformer = (global::Com.Squareup.Picasso.Picasso.IRequestTransformer)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.IRequestTransformer> (native_transformer, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestTransformer (transformer));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Builder']/method[@name='requestTransformer' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Picasso.RequestTransformer']]"
			[Register ("requestTransformer", "(Lcom/squareup/picasso/Picasso$RequestTransformer;)Lcom/squareup/picasso/Picasso$Builder;", "GetRequestTransformer_Lcom_squareup_picasso_Picasso_RequestTransformer_Handler")]
			public virtual unsafe global::Com.Squareup.Picasso.Picasso.Builder RequestTransformer (global::Com.Squareup.Picasso.Picasso.IRequestTransformer transformer)
			{
				const string __id = "requestTransformer.(Lcom/squareup/picasso/Picasso$RequestTransformer;)Lcom/squareup/picasso/Picasso$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((transformer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformer).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Picasso.Listener']"
		[Register ("com/squareup/picasso/Picasso$Listener", "", "Com.Squareup.Picasso.Picasso/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Picasso.Listener']/method[@name='onImageLoadFailed' and count(parameter)=3 and parameter[1][@type='com.squareup.picasso.Picasso'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("onImageLoadFailed", "(Lcom/squareup/picasso/Picasso;Landroid/net/Uri;Ljava/lang/Exception;)V", "GetOnImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_Handler:Com.Squareup.Picasso.Picasso/IListenerInvoker, JavaBindingExample")]
			void OnImageLoadFailed (global::Com.Squareup.Picasso.Picasso p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2);

		}

		[global::Android.Runtime.Register ("com/squareup/picasso/Picasso$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/picasso/Picasso$Listener", typeof (IListenerInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.squareup.picasso.Picasso.Listener"));
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

			static Delegate cb_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_Handler ()
			{
				if (cb_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_ == null)
					cb_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_);
				return cb_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_;
			}

			static void n_OnImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Squareup.Picasso.Picasso.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.Picasso p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnImageLoadFailed (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_;
			public unsafe void OnImageLoadFailed (global::Com.Squareup.Picasso.Picasso p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				if (id_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onImageLoadFailed", "(Lcom/squareup/picasso/Picasso;Landroid/net/Uri;Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageLoadFailed_Lcom_squareup_picasso_Picasso_Landroid_net_Uri_Ljava_lang_Exception_, __args);
			}

		}

		// event args for com.squareup.picasso.Picasso.Listener.onImageLoadFailed
		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Com.Squareup.Picasso.Picasso p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Squareup.Picasso.Picasso p0;
			public global::Com.Squareup.Picasso.Picasso P0 {
				get { return p0; }
			}

			global::Android.Net.Uri p1;
			public global::Android.Net.Uri P1 {
				get { return p1; }
			}

			global::Java.Lang.Exception p2;
			public global::Java.Lang.Exception P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/squareup/picasso/Picasso_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/squareup/picasso/Picasso_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnImageLoadFailed (global::Com.Squareup.Picasso.Picasso p0, global::Android.Net.Uri p1, global::Java.Lang.Exception p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']"
		[global::Android.Runtime.Register ("com/squareup/picasso/Picasso$LoadedFrom", DoNotGenerateAcw=true)]
		public sealed partial class LoadedFrom : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']/field[@name='DISK']"
			[Register ("DISK")]
			public static global::Com.Squareup.Picasso.Picasso.LoadedFrom Disk {
				get {
					const string __id = "DISK.Lcom/squareup/picasso/Picasso$LoadedFrom;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.LoadedFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']/field[@name='MEMORY']"
			[Register ("MEMORY")]
			public static global::Com.Squareup.Picasso.Picasso.LoadedFrom Memory {
				get {
					const string __id = "MEMORY.Lcom/squareup/picasso/Picasso$LoadedFrom;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.LoadedFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.Squareup.Picasso.Picasso.LoadedFrom Network {
				get {
					const string __id = "NETWORK.Lcom/squareup/picasso/Picasso$LoadedFrom;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.LoadedFrom> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Picasso$LoadedFrom", typeof (LoadedFrom));
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

			internal LoadedFrom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/squareup/picasso/Picasso$LoadedFrom;", "")]
			public static unsafe global::Com.Squareup.Picasso.Picasso.LoadedFrom ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/squareup/picasso/Picasso$LoadedFrom;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.LoadedFrom> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.LoadedFrom']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/squareup/picasso/Picasso$LoadedFrom;", "")]
			public static unsafe global::Com.Squareup.Picasso.Picasso.LoadedFrom[] Values ()
			{
				const string __id = "values.()[Lcom/squareup/picasso/Picasso$LoadedFrom;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Squareup.Picasso.Picasso.LoadedFrom[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Squareup.Picasso.Picasso.LoadedFrom));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']"
		[global::Android.Runtime.Register ("com/squareup/picasso/Picasso$Priority", DoNotGenerateAcw=true)]
		public sealed partial class Priority : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']/field[@name='HIGH']"
			[Register ("HIGH")]
			public static global::Com.Squareup.Picasso.Picasso.Priority High {
				get {
					const string __id = "HIGH.Lcom/squareup/picasso/Picasso$Priority;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']/field[@name='LOW']"
			[Register ("LOW")]
			public static global::Com.Squareup.Picasso.Picasso.Priority Low {
				get {
					const string __id = "LOW.Lcom/squareup/picasso/Picasso$Priority;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Squareup.Picasso.Picasso.Priority Normal {
				get {
					const string __id = "NORMAL.Lcom/squareup/picasso/Picasso$Priority;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Picasso$Priority", typeof (Priority));
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

			internal Priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/squareup/picasso/Picasso$Priority;", "")]
			public static unsafe global::Com.Squareup.Picasso.Picasso.Priority ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/squareup/picasso/Picasso$Priority;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso.Priority']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/squareup/picasso/Picasso$Priority;", "")]
			public static unsafe global::Com.Squareup.Picasso.Picasso.Priority[] Values ()
			{
				const string __id = "values.()[Lcom/squareup/picasso/Picasso$Priority;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Squareup.Picasso.Picasso.Priority[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Squareup.Picasso.Picasso.Priority));
				} finally {
				}
			}

		}

		[Register ("com/squareup/picasso/Picasso$RequestTransformer", DoNotGenerateAcw=true)]
		public abstract class RequestTransformer : Java.Lang.Object {

			internal RequestTransformer ()
			{
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Picasso.RequestTransformer']/field[@name='IDENTITY']"
			[Register ("IDENTITY")]
			public static global::Com.Squareup.Picasso.Picasso.IRequestTransformer Identity {
				get {
					const string __id = "IDENTITY.Lcom/squareup/picasso/Picasso$RequestTransformer;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.IRequestTransformer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			new static JniPeerMembers _members = new JniPeerMembers ("com/squareup/picasso/Picasso$RequestTransformer", typeof (RequestTransformer));
		}

		[Register ("com/squareup/picasso/Picasso$RequestTransformer", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'RequestTransformer' type. This type will be removed in a future release.")]
		public abstract class RequestTransformerConsts : RequestTransformer {

			private RequestTransformerConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Picasso.RequestTransformer']"
		[Register ("com/squareup/picasso/Picasso$RequestTransformer", "", "Com.Squareup.Picasso.Picasso/IRequestTransformerInvoker")]
		public partial interface IRequestTransformer : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Picasso.RequestTransformer']/method[@name='transformRequest' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Request']]"
			[Register ("transformRequest", "(Lcom/squareup/picasso/Request;)Lcom/squareup/picasso/Request;", "GetTransformRequest_Lcom_squareup_picasso_Request_Handler:Com.Squareup.Picasso.Picasso/IRequestTransformerInvoker, JavaBindingExample")]
			global::Com.Squareup.Picasso.Request TransformRequest (global::Com.Squareup.Picasso.Request p0);

		}

		[global::Android.Runtime.Register ("com/squareup/picasso/Picasso$RequestTransformer", DoNotGenerateAcw=true)]
		internal class IRequestTransformerInvoker : global::Java.Lang.Object, IRequestTransformer {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/picasso/Picasso$RequestTransformer", typeof (IRequestTransformerInvoker));

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

			public static IRequestTransformer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRequestTransformer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.squareup.picasso.Picasso.RequestTransformer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRequestTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_transformRequest_Lcom_squareup_picasso_Request_;
#pragma warning disable 0169
			static Delegate GetTransformRequest_Lcom_squareup_picasso_Request_Handler ()
			{
				if (cb_transformRequest_Lcom_squareup_picasso_Request_ == null)
					cb_transformRequest_Lcom_squareup_picasso_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformRequest_Lcom_squareup_picasso_Request_);
				return cb_transformRequest_Lcom_squareup_picasso_Request_;
			}

			static IntPtr n_TransformRequest_Lcom_squareup_picasso_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Squareup.Picasso.Picasso.IRequestTransformer __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.IRequestTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Picasso.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransformRequest (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_transformRequest_Lcom_squareup_picasso_Request_;
			public unsafe global::Com.Squareup.Picasso.Request TransformRequest (global::Com.Squareup.Picasso.Request p0)
			{
				if (id_transformRequest_Lcom_squareup_picasso_Request_ == IntPtr.Zero)
					id_transformRequest_Lcom_squareup_picasso_Request_ = JNIEnv.GetMethodID (class_ref, "transformRequest", "(Lcom/squareup/picasso/Request;)Lcom/squareup/picasso/Request;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Com.Squareup.Picasso.Request __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transformRequest_Lcom_squareup_picasso_Request_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Picasso", typeof (Picasso));
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

		protected Picasso (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isDebugging;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsDebuggingHandler ()
		{
			if (cb_isDebugging == null)
				cb_isDebugging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugging);
			return cb_isDebugging;
		}

		[Obsolete]
		static bool n_IsDebugging (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Debugging;
		}
#pragma warning restore 0169

		static Delegate cb_setDebugging_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDebugging_ZHandler ()
		{
			if (cb_setDebugging_Z == null)
				cb_setDebugging_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugging_Z);
			return cb_setDebugging_Z;
		}

		[Obsolete]
		static void n_SetDebugging_Z (IntPtr jnienv, IntPtr native__this, bool debugging)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Debugging = debugging;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool Debugging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='isDebugging' and count(parameter)=0]"
			[Register ("isDebugging", "()Z", "GetIsDebuggingHandler")]
			get {
				const string __id = "isDebugging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='setDebugging' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugging", "(Z)V", "GetSetDebugging_ZHandler")]
			set {
				const string __id = "setDebugging.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isLoggingEnabled;
#pragma warning disable 0169
		static Delegate GetIsLoggingEnabledHandler ()
		{
			if (cb_isLoggingEnabled == null)
				cb_isLoggingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoggingEnabled);
			return cb_isLoggingEnabled;
		}

		static bool n_IsLoggingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoggingEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLoggingEnabled_ZHandler ()
		{
			if (cb_setLoggingEnabled_Z == null)
				cb_setLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLoggingEnabled_Z);
			return cb_setLoggingEnabled_Z;
		}

		static void n_SetLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoggingEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool LoggingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='isLoggingEnabled' and count(parameter)=0]"
			[Register ("isLoggingEnabled", "()Z", "GetIsLoggingEnabledHandler")]
			get {
				const string __id = "isLoggingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='setLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoggingEnabled", "(Z)V", "GetSetLoggingEnabled_ZHandler")]
			set {
				const string __id = "setLoggingEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSnapshot;
#pragma warning disable 0169
		static Delegate GetGetSnapshotHandler ()
		{
			if (cb_getSnapshot == null)
				cb_getSnapshot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnapshot);
			return cb_getSnapshot;
		}

		static IntPtr n_GetSnapshot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Snapshot);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Squareup.Picasso.StatsSnapshot Snapshot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='getSnapshot' and count(parameter)=0]"
			[Register ("getSnapshot", "()Lcom/squareup/picasso/StatsSnapshot;", "GetGetSnapshotHandler")]
			get {
				const string __id = "getSnapshot.()Lcom/squareup/picasso/StatsSnapshot;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.StatsSnapshot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_areIndicatorsEnabled;
#pragma warning disable 0169
		static Delegate GetAreIndicatorsEnabledHandler ()
		{
			if (cb_areIndicatorsEnabled == null)
				cb_areIndicatorsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreIndicatorsEnabled);
			return cb_areIndicatorsEnabled;
		}

		static bool n_AreIndicatorsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreIndicatorsEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='areIndicatorsEnabled' and count(parameter)=0]"
		[Register ("areIndicatorsEnabled", "()Z", "GetAreIndicatorsEnabledHandler")]
		public virtual unsafe bool AreIndicatorsEnabled ()
		{
			const string __id = "areIndicatorsEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_cancelRequest_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetCancelRequest_Landroid_widget_ImageView_Handler ()
		{
			if (cb_cancelRequest_Landroid_widget_ImageView_ == null)
				cb_cancelRequest_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelRequest_Landroid_widget_ImageView_);
			return cb_cancelRequest_Landroid_widget_ImageView_;
		}

		static void n_CancelRequest_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView view = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='cancelRequest' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("cancelRequest", "(Landroid/widget/ImageView;)V", "GetCancelRequest_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void CancelRequest (global::Android.Widget.ImageView view)
		{
			const string __id = "cancelRequest.(Landroid/widget/ImageView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cancelRequest_Landroid_widget_RemoteViews_I;
#pragma warning disable 0169
		static Delegate GetCancelRequest_Landroid_widget_RemoteViews_IHandler ()
		{
			if (cb_cancelRequest_Landroid_widget_RemoteViews_I == null)
				cb_cancelRequest_Landroid_widget_RemoteViews_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_CancelRequest_Landroid_widget_RemoteViews_I);
			return cb_cancelRequest_Landroid_widget_RemoteViews_I;
		}

		static void n_CancelRequest_Landroid_widget_RemoteViews_I (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteViews, int viewId)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.RemoteViews remoteViews = global::Java.Lang.Object.GetObject<global::Android.Widget.RemoteViews> (native_remoteViews, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest (remoteViews, viewId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='cancelRequest' and count(parameter)=2 and parameter[1][@type='android.widget.RemoteViews'] and parameter[2][@type='int']]"
		[Register ("cancelRequest", "(Landroid/widget/RemoteViews;I)V", "GetCancelRequest_Landroid_widget_RemoteViews_IHandler")]
		public virtual unsafe void CancelRequest (global::Android.Widget.RemoteViews remoteViews, int viewId)
		{
			const string __id = "cancelRequest.(Landroid/widget/RemoteViews;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((remoteViews == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteViews).Handle);
				__args [1] = new JniArgumentValue (viewId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cancelRequest_Lcom_squareup_picasso_Target_;
#pragma warning disable 0169
		static Delegate GetCancelRequest_Lcom_squareup_picasso_Target_Handler ()
		{
			if (cb_cancelRequest_Lcom_squareup_picasso_Target_ == null)
				cb_cancelRequest_Lcom_squareup_picasso_Target_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelRequest_Lcom_squareup_picasso_Target_);
			return cb_cancelRequest_Lcom_squareup_picasso_Target_;
		}

		static void n_CancelRequest_Lcom_squareup_picasso_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.ITarget target = (global::Com.Squareup.Picasso.ITarget)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ITarget> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='cancelRequest' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Target']]"
		[Register ("cancelRequest", "(Lcom/squareup/picasso/Target;)V", "GetCancelRequest_Lcom_squareup_picasso_Target_Handler")]
		public virtual unsafe void CancelRequest (global::Com.Squareup.Picasso.ITarget target)
		{
			const string __id = "cancelRequest.(Lcom/squareup/picasso/Target;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cancelTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCancelTag_Ljava_lang_Object_Handler ()
		{
			if (cb_cancelTag_Ljava_lang_Object_ == null)
				cb_cancelTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelTag_Ljava_lang_Object_);
			return cb_cancelTag_Ljava_lang_Object_;
		}

		static void n_CancelTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
			__this.CancelTag (tag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='cancelTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("cancelTag", "(Ljava/lang/Object;)V", "GetCancelTag_Ljava_lang_Object_Handler")]
		public virtual unsafe void CancelTag (global::Java.Lang.Object tag)
		{
			const string __id = "cancelTag.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidate_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetInvalidate_Landroid_net_Uri_Handler ()
		{
			if (cb_invalidate_Landroid_net_Uri_ == null)
				cb_invalidate_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invalidate_Landroid_net_Uri_);
			return cb_invalidate_Landroid_net_Uri_;
		}

		static void n_Invalidate_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (uri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='invalidate' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("invalidate", "(Landroid/net/Uri;)V", "GetInvalidate_Landroid_net_Uri_Handler")]
		public virtual unsafe void Invalidate (global::Android.Net.Uri uri)
		{
			const string __id = "invalidate.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidate_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetInvalidate_Ljava_io_File_Handler ()
		{
			if (cb_invalidate_Ljava_io_File_ == null)
				cb_invalidate_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invalidate_Ljava_io_File_);
			return cb_invalidate_Ljava_io_File_;
		}

		static void n_Invalidate_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (file);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='invalidate' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("invalidate", "(Ljava/io/File;)V", "GetInvalidate_Ljava_io_File_Handler")]
		public virtual unsafe void Invalidate (global::Java.IO.File file)
		{
			const string __id = "invalidate.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_invalidate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvalidate_Ljava_lang_String_Handler ()
		{
			if (cb_invalidate_Ljava_lang_String_ == null)
				cb_invalidate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invalidate_Ljava_lang_String_);
			return cb_invalidate_Ljava_lang_String_;
		}

		static void n_Invalidate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='invalidate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invalidate", "(Ljava/lang/String;)V", "GetInvalidate_Ljava_lang_String_Handler")]
		public virtual unsafe void Invalidate (string path)
		{
			const string __id = "invalidate.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_load_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLoad_Landroid_net_Uri_Handler ()
		{
			if (cb_load_Landroid_net_Uri_ == null)
				cb_load_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Landroid_net_Uri_);
			return cb_load_Landroid_net_Uri_;
		}

		static IntPtr n_Load_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='load' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("load", "(Landroid/net/Uri;)Lcom/squareup/picasso/RequestCreator;", "GetLoad_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Load (global::Android.Net.Uri uri)
		{
			const string __id = "load.(Landroid/net/Uri;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load_I;
#pragma warning disable 0169
		static Delegate GetLoad_IHandler ()
		{
			if (cb_load_I == null)
				cb_load_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Load_I);
			return cb_load_I;
		}

		static IntPtr n_Load_I (IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Load (resourceId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='load' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("load", "(I)Lcom/squareup/picasso/RequestCreator;", "GetLoad_IHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Load (int resourceId)
		{
			const string __id = "load.(I)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resourceId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_io_File_Handler ()
		{
			if (cb_load_Ljava_io_File_ == null)
				cb_load_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_io_File_);
			return cb_load_Ljava_io_File_;
		}

		static IntPtr n_Load_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (file));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("load", "(Ljava/io/File;)Lcom/squareup/picasso/RequestCreator;", "GetLoad_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Load (global::Java.IO.File file)
		{
			const string __id = "load.(Ljava/io/File;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static IntPtr n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Lcom/squareup/picasso/RequestCreator;", "GetLoad_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Load (string path)
		{
			const string __id = "load.(Ljava/lang/String;)Lcom/squareup/picasso/RequestCreator;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_pauseTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPauseTag_Ljava_lang_Object_Handler ()
		{
			if (cb_pauseTag_Ljava_lang_Object_ == null)
				cb_pauseTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PauseTag_Ljava_lang_Object_);
			return cb_pauseTag_Ljava_lang_Object_;
		}

		static void n_PauseTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
			__this.PauseTag (tag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='pauseTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("pauseTag", "(Ljava/lang/Object;)V", "GetPauseTag_Ljava_lang_Object_Handler")]
		public virtual unsafe void PauseTag (global::Java.Lang.Object tag)
		{
			const string __id = "pauseTag.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resumeTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetResumeTag_Ljava_lang_Object_Handler ()
		{
			if (cb_resumeTag_Ljava_lang_Object_ == null)
				cb_resumeTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResumeTag_Ljava_lang_Object_);
			return cb_resumeTag_Ljava_lang_Object_;
		}

		static void n_ResumeTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
			__this.ResumeTag (tag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='resumeTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("resumeTag", "(Ljava/lang/Object;)V", "GetResumeTag_Ljava_lang_Object_Handler")]
		public virtual unsafe void ResumeTag (global::Java.Lang.Object tag)
		{
			const string __id = "resumeTag.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicatorsEnabled_ZHandler ()
		{
			if (cb_setIndicatorsEnabled_Z == null)
				cb_setIndicatorsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIndicatorsEnabled_Z);
			return cb_setIndicatorsEnabled_Z;
		}

		static void n_SetIndicatorsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorsEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='setIndicatorsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicatorsEnabled", "(Z)V", "GetSetIndicatorsEnabled_ZHandler")]
		public virtual unsafe void SetIndicatorsEnabled (bool enabled)
		{
			const string __id = "setIndicatorsEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='setSingletonInstance' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Picasso']]"
		[Register ("setSingletonInstance", "(Lcom/squareup/picasso/Picasso;)V", "")]
		public static unsafe void SetSingletonInstance (global::Com.Squareup.Picasso.Picasso picasso)
		{
			const string __id = "setSingletonInstance.(Lcom/squareup/picasso/Picasso;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((picasso == null) ? IntPtr.Zero : ((global::Java.Lang.Object) picasso).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
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
			global::Com.Squareup.Picasso.Picasso __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			const string __id = "shutdown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Picasso']/method[@name='with' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("with", "(Landroid/content/Context;)Lcom/squareup/picasso/Picasso;", "")]
		public static unsafe global::Com.Squareup.Picasso.Picasso With (global::Android.Content.Context context)
		{
			const string __id = "with.(Landroid/content/Context;)Lcom/squareup/picasso/Picasso;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
