using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']"
	[global::Android.Runtime.Register ("com/squareup/picasso/RequestCreator", DoNotGenerateAcw=true)]
	public partial class RequestCreator : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/RequestCreator", typeof (RequestCreator));
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

		protected RequestCreator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_centerCrop;
#pragma warning disable 0169
		static Delegate GetCenterCropHandler ()
		{
			if (cb_centerCrop == null)
				cb_centerCrop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CenterCrop);
			return cb_centerCrop;
		}

		static IntPtr n_CenterCrop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterCrop ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='centerCrop' and count(parameter)=0]"
		[Register ("centerCrop", "()Lcom/squareup/picasso/RequestCreator;", "GetCenterCropHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator CenterCrop ()
		{
			const string __id = "centerCrop.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_centerInside;
#pragma warning disable 0169
		static Delegate GetCenterInsideHandler ()
		{
			if (cb_centerInside == null)
				cb_centerInside = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CenterInside);
			return cb_centerInside;
		}

		static IntPtr n_CenterInside (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterInside ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='centerInside' and count(parameter)=0]"
		[Register ("centerInside", "()Lcom/squareup/picasso/RequestCreator;", "GetCenterInsideHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator CenterInside ()
		{
			const string __id = "centerInside.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_config_Landroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetConfig_Landroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_config_Landroid_graphics_Bitmap_Config_ == null)
				cb_config_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Landroid_graphics_Bitmap_Config_);
			return cb_config_Landroid_graphics_Bitmap_Config_;
		}

		static IntPtr n_Config_Landroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config config = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Config (config));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='config' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
		[Register ("config", "(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/RequestCreator;", "GetConfig_Landroid_graphics_Bitmap_Config_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Config (global::Android.Graphics.Bitmap.Config config)
		{
			const string __id = "config.(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_error_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetError_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_error_Landroid_graphics_drawable_Drawable_ == null)
				cb_error_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Error_Landroid_graphics_drawable_Drawable_);
			return cb_error_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Error_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorDrawable)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable errorDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_errorDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Error (errorDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='error' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("error", "(Landroid/graphics/drawable/Drawable;)Lcom/squareup/picasso/RequestCreator;", "GetError_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Error (global::Android.Graphics.Drawables.Drawable errorDrawable)
		{
			const string __id = "error.(Landroid/graphics/drawable/Drawable;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_error_I;
#pragma warning disable 0169
		static Delegate GetError_IHandler ()
		{
			if (cb_error_I == null)
				cb_error_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Error_I);
			return cb_error_I;
		}

		static IntPtr n_Error_I (IntPtr jnienv, IntPtr native__this, int errorResId)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error (errorResId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='error' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("error", "(I)Lcom/squareup/picasso/RequestCreator;", "GetError_IHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Error (int errorResId)
		{
			const string __id = "error.(I)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (errorResId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fetch;
#pragma warning disable 0169
		static Delegate GetFetchHandler ()
		{
			if (cb_fetch == null)
				cb_fetch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Fetch);
			return cb_fetch;
		}

		static void n_Fetch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fetch ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='fetch' and count(parameter)=0]"
		[Register ("fetch", "()V", "GetFetchHandler")]
		public virtual unsafe void Fetch ()
		{
			const string __id = "fetch.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fetch_Lcom_squareup_picasso_Callback_;
#pragma warning disable 0169
		static Delegate GetFetch_Lcom_squareup_picasso_Callback_Handler ()
		{
			if (cb_fetch_Lcom_squareup_picasso_Callback_ == null)
				cb_fetch_Lcom_squareup_picasso_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fetch_Lcom_squareup_picasso_Callback_);
			return cb_fetch_Lcom_squareup_picasso_Callback_;
		}

		static void n_Fetch_Lcom_squareup_picasso_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.ICallback @callback = (global::Com.Squareup.Picasso.ICallback)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='fetch' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Callback']]"
		[Register ("fetch", "(Lcom/squareup/picasso/Callback;)V", "GetFetch_Lcom_squareup_picasso_Callback_Handler")]
		public virtual unsafe void Fetch (global::Com.Squareup.Picasso.ICallback @callback)
		{
			const string __id = "fetch.(Lcom/squareup/picasso/Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fit;
#pragma warning disable 0169
		static Delegate GetFitHandler ()
		{
			if (cb_fit == null)
				cb_fit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Fit);
			return cb_fit;
		}

		static IntPtr n_Fit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fit ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='fit' and count(parameter)=0]"
		[Register ("fit", "()Lcom/squareup/picasso/RequestCreator;", "GetFitHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Fit ()
		{
			const string __id = "fit.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Landroid/graphics/Bitmap;", "GetGetHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap Get ()
		{
			const string __id = "get.()Landroid/graphics/Bitmap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_into_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetInto_Landroid_widget_ImageView_Handler ()
		{
			if (cb_into_Landroid_widget_ImageView_ == null)
				cb_into_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Into_Landroid_widget_ImageView_);
			return cb_into_Landroid_widget_ImageView_;
		}

		static void n_Into_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView target = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Into (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='into' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("into", "(Landroid/widget/ImageView;)V", "GetInto_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void Into (global::Android.Widget.ImageView target)
		{
			const string __id = "into.(Landroid/widget/ImageView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_;
#pragma warning disable 0169
		static Delegate GetInto_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_Handler ()
		{
			if (cb_into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_ == null)
				cb_into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_);
			return cb_into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_;
		}

		static void n_Into_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target, IntPtr native__callback)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView target = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_target, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.ICallback @callback = (global::Com.Squareup.Picasso.ICallback)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Into (target, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='into' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='com.squareup.picasso.Callback']]"
		[Register ("into", "(Landroid/widget/ImageView;Lcom/squareup/picasso/Callback;)V", "GetInto_Landroid_widget_ImageView_Lcom_squareup_picasso_Callback_Handler")]
		public virtual unsafe void Into (global::Android.Widget.ImageView target, global::Com.Squareup.Picasso.ICallback @callback)
		{
			const string __id = "into.(Landroid/widget/ImageView;Lcom/squareup/picasso/Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_into_Landroid_widget_RemoteViews_IILandroid_app_Notification_;
#pragma warning disable 0169
		static Delegate GetInto_Landroid_widget_RemoteViews_IILandroid_app_Notification_Handler ()
		{
			if (cb_into_Landroid_widget_RemoteViews_IILandroid_app_Notification_ == null)
				cb_into_Landroid_widget_RemoteViews_IILandroid_app_Notification_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Into_Landroid_widget_RemoteViews_IILandroid_app_Notification_);
			return cb_into_Landroid_widget_RemoteViews_IILandroid_app_Notification_;
		}

		static void n_Into_Landroid_widget_RemoteViews_IILandroid_app_Notification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteViews, int viewId, int notificationId, IntPtr native_notification)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.RemoteViews remoteViews = global::Java.Lang.Object.GetObject<global::Android.Widget.RemoteViews> (native_remoteViews, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Notification notification = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (native_notification, JniHandleOwnership.DoNotTransfer);
			__this.Into (remoteViews, viewId, notificationId, notification);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='into' and count(parameter)=4 and parameter[1][@type='android.widget.RemoteViews'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.app.Notification']]"
		[Register ("into", "(Landroid/widget/RemoteViews;IILandroid/app/Notification;)V", "GetInto_Landroid_widget_RemoteViews_IILandroid_app_Notification_Handler")]
		public virtual unsafe void Into (global::Android.Widget.RemoteViews remoteViews, int viewId, int notificationId, global::Android.App.Notification notification)
		{
			const string __id = "into.(Landroid/widget/RemoteViews;IILandroid/app/Notification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((remoteViews == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteViews).Handle);
				__args [1] = new JniArgumentValue (viewId);
				__args [2] = new JniArgumentValue (notificationId);
				__args [3] = new JniArgumentValue ((notification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notification).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_into_Landroid_widget_RemoteViews_IarrayI;
#pragma warning disable 0169
		static Delegate GetInto_Landroid_widget_RemoteViews_IarrayIHandler ()
		{
			if (cb_into_Landroid_widget_RemoteViews_IarrayI == null)
				cb_into_Landroid_widget_RemoteViews_IarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Into_Landroid_widget_RemoteViews_IarrayI);
			return cb_into_Landroid_widget_RemoteViews_IarrayI;
		}

		static void n_Into_Landroid_widget_RemoteViews_IarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteViews, int viewId, IntPtr native_appWidgetIds)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.RemoteViews remoteViews = global::Java.Lang.Object.GetObject<global::Android.Widget.RemoteViews> (native_remoteViews, JniHandleOwnership.DoNotTransfer);
			int[] appWidgetIds = (int[]) JNIEnv.GetArray (native_appWidgetIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Into (remoteViews, viewId, appWidgetIds);
			if (appWidgetIds != null)
				JNIEnv.CopyArray (appWidgetIds, native_appWidgetIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='into' and count(parameter)=3 and parameter[1][@type='android.widget.RemoteViews'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("into", "(Landroid/widget/RemoteViews;I[I)V", "GetInto_Landroid_widget_RemoteViews_IarrayIHandler")]
		public virtual unsafe void Into (global::Android.Widget.RemoteViews remoteViews, int viewId, int[] appWidgetIds)
		{
			const string __id = "into.(Landroid/widget/RemoteViews;I[I)V";
			IntPtr native_appWidgetIds = JNIEnv.NewArray (appWidgetIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((remoteViews == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteViews).Handle);
				__args [1] = new JniArgumentValue (viewId);
				__args [2] = new JniArgumentValue (native_appWidgetIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (appWidgetIds != null) {
					JNIEnv.CopyArray (native_appWidgetIds, appWidgetIds);
					JNIEnv.DeleteLocalRef (native_appWidgetIds);
				}
			}
		}

		static Delegate cb_into_Lcom_squareup_picasso_Target_;
#pragma warning disable 0169
		static Delegate GetInto_Lcom_squareup_picasso_Target_Handler ()
		{
			if (cb_into_Lcom_squareup_picasso_Target_ == null)
				cb_into_Lcom_squareup_picasso_Target_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Into_Lcom_squareup_picasso_Target_);
			return cb_into_Lcom_squareup_picasso_Target_;
		}

		static void n_Into_Lcom_squareup_picasso_Target_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.ITarget target = (global::Com.Squareup.Picasso.ITarget)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ITarget> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Into (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='into' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Target']]"
		[Register ("into", "(Lcom/squareup/picasso/Target;)V", "GetInto_Lcom_squareup_picasso_Target_Handler")]
		public virtual unsafe void Into (global::Com.Squareup.Picasso.ITarget target)
		{
			const string __id = "into.(Lcom/squareup/picasso/Target;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_memoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_;
#pragma warning disable 0169
		static Delegate GetMemoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_Handler ()
		{
			if (cb_memoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_ == null)
				cb_memoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MemoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_);
			return cb_memoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_;
		}

		static IntPtr n_MemoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_policy, IntPtr native_additional)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.MemoryPolicy policy = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.MemoryPolicy> (native_policy, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.MemoryPolicy[] additional = (global::Com.Squareup.Picasso.MemoryPolicy[]) JNIEnv.GetArray (native_additional, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Squareup.Picasso.MemoryPolicy));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MemoryPolicy (policy, additional));
			if (additional != null)
				JNIEnv.CopyArray (additional, native_additional);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='memoryPolicy' and count(parameter)=2 and parameter[1][@type='com.squareup.picasso.MemoryPolicy'] and parameter[2][@type='com.squareup.picasso.MemoryPolicy...']]"
		[Register ("memoryPolicy", "(Lcom/squareup/picasso/MemoryPolicy;[Lcom/squareup/picasso/MemoryPolicy;)Lcom/squareup/picasso/RequestCreator;", "GetMemoryPolicy_Lcom_squareup_picasso_MemoryPolicy_arrayLcom_squareup_picasso_MemoryPolicy_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator MemoryPolicy (global::Com.Squareup.Picasso.MemoryPolicy policy, params global::Com.Squareup.Picasso.MemoryPolicy[] additional)
		{
			const string __id = "memoryPolicy.(Lcom/squareup/picasso/MemoryPolicy;[Lcom/squareup/picasso/MemoryPolicy;)Lcom/squareup/picasso/RequestCreator;";
			IntPtr native_additional = JNIEnv.NewArray (additional);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((policy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) policy).Handle);
				__args [1] = new JniArgumentValue (native_additional);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (additional != null) {
					JNIEnv.CopyArray (native_additional, additional);
					JNIEnv.DeleteLocalRef (native_additional);
				}
			}
		}

		static Delegate cb_networkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_;
#pragma warning disable 0169
		static Delegate GetNetworkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_Handler ()
		{
			if (cb_networkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_ == null)
				cb_networkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NetworkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_);
			return cb_networkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_;
		}

		static IntPtr n_NetworkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_policy, IntPtr native_additional)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.NetworkPolicy policy = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.NetworkPolicy> (native_policy, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.NetworkPolicy[] additional = (global::Com.Squareup.Picasso.NetworkPolicy[]) JNIEnv.GetArray (native_additional, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Squareup.Picasso.NetworkPolicy));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NetworkPolicy (policy, additional));
			if (additional != null)
				JNIEnv.CopyArray (additional, native_additional);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='networkPolicy' and count(parameter)=2 and parameter[1][@type='com.squareup.picasso.NetworkPolicy'] and parameter[2][@type='com.squareup.picasso.NetworkPolicy...']]"
		[Register ("networkPolicy", "(Lcom/squareup/picasso/NetworkPolicy;[Lcom/squareup/picasso/NetworkPolicy;)Lcom/squareup/picasso/RequestCreator;", "GetNetworkPolicy_Lcom_squareup_picasso_NetworkPolicy_arrayLcom_squareup_picasso_NetworkPolicy_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator NetworkPolicy (global::Com.Squareup.Picasso.NetworkPolicy policy, params global::Com.Squareup.Picasso.NetworkPolicy[] additional)
		{
			const string __id = "networkPolicy.(Lcom/squareup/picasso/NetworkPolicy;[Lcom/squareup/picasso/NetworkPolicy;)Lcom/squareup/picasso/RequestCreator;";
			IntPtr native_additional = JNIEnv.NewArray (additional);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((policy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) policy).Handle);
				__args [1] = new JniArgumentValue (native_additional);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (additional != null) {
					JNIEnv.CopyArray (native_additional, additional);
					JNIEnv.DeleteLocalRef (native_additional);
				}
			}
		}

		static Delegate cb_noFade;
#pragma warning disable 0169
		static Delegate GetNoFadeHandler ()
		{
			if (cb_noFade == null)
				cb_noFade = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NoFade);
			return cb_noFade;
		}

		static IntPtr n_NoFade (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoFade ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='noFade' and count(parameter)=0]"
		[Register ("noFade", "()Lcom/squareup/picasso/RequestCreator;", "GetNoFadeHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator NoFade ()
		{
			const string __id = "noFade.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_noPlaceholder;
#pragma warning disable 0169
		static Delegate GetNoPlaceholderHandler ()
		{
			if (cb_noPlaceholder == null)
				cb_noPlaceholder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NoPlaceholder);
			return cb_noPlaceholder;
		}

		static IntPtr n_NoPlaceholder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoPlaceholder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='noPlaceholder' and count(parameter)=0]"
		[Register ("noPlaceholder", "()Lcom/squareup/picasso/RequestCreator;", "GetNoPlaceholderHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator NoPlaceholder ()
		{
			const string __id = "noPlaceholder.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onlyScaleDown;
#pragma warning disable 0169
		static Delegate GetOnlyScaleDownHandler ()
		{
			if (cb_onlyScaleDown == null)
				cb_onlyScaleDown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnlyScaleDown);
			return cb_onlyScaleDown;
		}

		static IntPtr n_OnlyScaleDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnlyScaleDown ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='onlyScaleDown' and count(parameter)=0]"
		[Register ("onlyScaleDown", "()Lcom/squareup/picasso/RequestCreator;", "GetOnlyScaleDownHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator OnlyScaleDown ()
		{
			const string __id = "onlyScaleDown.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_placeholder_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPlaceholder_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_placeholder_Landroid_graphics_drawable_Drawable_ == null)
				cb_placeholder_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Placeholder_Landroid_graphics_drawable_Drawable_);
			return cb_placeholder_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Placeholder_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderDrawable)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable placeholderDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_placeholderDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (placeholderDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("placeholder", "(Landroid/graphics/drawable/Drawable;)Lcom/squareup/picasso/RequestCreator;", "GetPlaceholder_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Placeholder (global::Android.Graphics.Drawables.Drawable placeholderDrawable)
		{
			const string __id = "placeholder.(Landroid/graphics/drawable/Drawable;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((placeholderDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) placeholderDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_placeholder_I;
#pragma warning disable 0169
		static Delegate GetPlaceholder_IHandler ()
		{
			if (cb_placeholder_I == null)
				cb_placeholder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Placeholder_I);
			return cb_placeholder_I;
		}

		static IntPtr n_Placeholder_I (IntPtr jnienv, IntPtr native__this, int placeholderResId)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Placeholder (placeholderResId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("placeholder", "(I)Lcom/squareup/picasso/RequestCreator;", "GetPlaceholder_IHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Placeholder (int placeholderResId)
		{
			const string __id = "placeholder.(I)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (placeholderResId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_priority_Lcom_squareup_picasso_Picasso_Priority_;
#pragma warning disable 0169
		static Delegate GetPriority_Lcom_squareup_picasso_Picasso_Priority_Handler ()
		{
			if (cb_priority_Lcom_squareup_picasso_Picasso_Priority_ == null)
				cb_priority_Lcom_squareup_picasso_Picasso_Priority_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Priority_Lcom_squareup_picasso_Picasso_Priority_);
			return cb_priority_Lcom_squareup_picasso_Picasso_Priority_;
		}

		static IntPtr n_Priority_Lcom_squareup_picasso_Picasso_Priority_ (IntPtr jnienv, IntPtr native__this, IntPtr native_priority)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.Picasso.Priority priority = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (native_priority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Priority (priority));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='priority' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Picasso.Priority']]"
		[Register ("priority", "(Lcom/squareup/picasso/Picasso$Priority;)Lcom/squareup/picasso/RequestCreator;", "GetPriority_Lcom_squareup_picasso_Picasso_Priority_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Priority (global::Com.Squareup.Picasso.Picasso.Priority priority)
		{
			const string __id = "priority.(Lcom/squareup/picasso/Picasso$Priority;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((priority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priority).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resize_II;
#pragma warning disable 0169
		static Delegate GetResize_IIHandler ()
		{
			if (cb_resize_II == null)
				cb_resize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Resize_II);
			return cb_resize_II;
		}

		static IntPtr n_Resize_II (IntPtr jnienv, IntPtr native__this, int targetWidth, int targetHeight)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resize (targetWidth, targetHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='resize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("resize", "(II)Lcom/squareup/picasso/RequestCreator;", "GetResize_IIHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Resize (int targetWidth, int targetHeight)
		{
			const string __id = "resize.(II)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (targetWidth);
				__args [1] = new JniArgumentValue (targetHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resizeDimen_II;
#pragma warning disable 0169
		static Delegate GetResizeDimen_IIHandler ()
		{
			if (cb_resizeDimen_II == null)
				cb_resizeDimen_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_ResizeDimen_II);
			return cb_resizeDimen_II;
		}

		static IntPtr n_ResizeDimen_II (IntPtr jnienv, IntPtr native__this, int targetWidthResId, int targetHeightResId)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResizeDimen (targetWidthResId, targetHeightResId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='resizeDimen' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("resizeDimen", "(II)Lcom/squareup/picasso/RequestCreator;", "GetResizeDimen_IIHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator ResizeDimen (int targetWidthResId, int targetHeightResId)
		{
			const string __id = "resizeDimen.(II)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (targetWidthResId);
				__args [1] = new JniArgumentValue (targetHeightResId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotate_F;
#pragma warning disable 0169
		static Delegate GetRotate_FHandler ()
		{
			if (cb_rotate_F == null)
				cb_rotate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Rotate_F);
			return cb_rotate_F;
		}

		static IntPtr n_Rotate_F (IntPtr jnienv, IntPtr native__this, float degrees)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotate (degrees));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)Lcom/squareup/picasso/RequestCreator;", "GetRotate_FHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Rotate (float degrees)
		{
			const string __id = "rotate.(F)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (degrees);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotate_FFF;
#pragma warning disable 0169
		static Delegate GetRotate_FFFHandler ()
		{
			if (cb_rotate_FFF == null)
				cb_rotate_FFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, IntPtr>) n_Rotate_FFF);
			return cb_rotate_FFF;
		}

		static IntPtr n_Rotate_FFF (IntPtr jnienv, IntPtr native__this, float degrees, float pivotX, float pivotY)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotate (degrees, pivotX, pivotY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='rotate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("rotate", "(FFF)Lcom/squareup/picasso/RequestCreator;", "GetRotate_FFFHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Rotate (float degrees, float pivotX, float pivotY)
		{
			const string __id = "rotate.(FFF)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (degrees);
				__args [1] = new JniArgumentValue (pivotX);
				__args [2] = new JniArgumentValue (pivotY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skipMemoryCache;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSkipMemoryCacheHandler ()
		{
			if (cb_skipMemoryCache == null)
				cb_skipMemoryCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SkipMemoryCache);
			return cb_skipMemoryCache;
		}

		[Obsolete]
		static IntPtr n_SkipMemoryCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkipMemoryCache ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='skipMemoryCache' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("skipMemoryCache", "()Lcom/squareup/picasso/RequestCreator;", "GetSkipMemoryCacheHandler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator SkipMemoryCache ()
		{
			const string __id = "skipMemoryCache.()Lcom/squareup/picasso/RequestCreator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stableKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStableKey_Ljava_lang_String_Handler ()
		{
			if (cb_stableKey_Ljava_lang_String_ == null)
				cb_stableKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StableKey_Ljava_lang_String_);
			return cb_stableKey_Ljava_lang_String_;
		}

		static IntPtr n_StableKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stableKey)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string stableKey = JNIEnv.GetString (native_stableKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StableKey (stableKey));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='stableKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stableKey", "(Ljava/lang/String;)Lcom/squareup/picasso/RequestCreator;", "GetStableKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator StableKey (string stableKey)
		{
			const string __id = "stableKey.(Ljava/lang/String;)Lcom/squareup/picasso/RequestCreator;";
			IntPtr native_stableKey = JNIEnv.NewString (stableKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stableKey);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stableKey);
			}
		}

		static Delegate cb_tag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTag_Ljava_lang_Object_Handler ()
		{
			if (cb_tag_Ljava_lang_Object_ == null)
				cb_tag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Tag_Ljava_lang_Object_);
			return cb_tag_Ljava_lang_Object_;
		}

		static IntPtr n_Tag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Tag (tag));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("tag", "(Ljava/lang/Object;)Lcom/squareup/picasso/RequestCreator;", "GetTag_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Tag (global::Java.Lang.Object tag)
		{
			const string __id = "tag.(Ljava/lang/Object;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transform_Lcom_squareup_picasso_Transformation_;
#pragma warning disable 0169
		static Delegate GetTransform_Lcom_squareup_picasso_Transformation_Handler ()
		{
			if (cb_transform_Lcom_squareup_picasso_Transformation_ == null)
				cb_transform_Lcom_squareup_picasso_Transformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_Lcom_squareup_picasso_Transformation_);
			return cb_transform_Lcom_squareup_picasso_Transformation_;
		}

		static IntPtr n_Transform_Lcom_squareup_picasso_Transformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformation)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.ITransformation transformation = (global::Com.Squareup.Picasso.ITransformation)global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ITransformation> (native_transformation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (transformation));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Transformation']]"
		[Register ("transform", "(Lcom/squareup/picasso/Transformation;)Lcom/squareup/picasso/RequestCreator;", "GetTransform_Lcom_squareup_picasso_Transformation_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Transform (global::Com.Squareup.Picasso.ITransformation transformation)
		{
			const string __id = "transform.(Lcom/squareup/picasso/Transformation;)Lcom/squareup/picasso/RequestCreator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transformation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformation).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transform_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetTransform_Ljava_util_List_Handler ()
		{
			if (cb_transform_Ljava_util_List_ == null)
				cb_transform_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_Ljava_util_List_);
			return cb_transform_Ljava_util_List_;
		}

		static IntPtr n_Transform_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformations)
		{
			global::Com.Squareup.Picasso.RequestCreator __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transformations = global::Android.Runtime.JavaList<global::Com.Squareup.Picasso.ITransformation>.FromJniHandle (native_transformations, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (transformations));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestCreator']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.squareup.picasso.Transformation&gt;']]"
		[Register ("transform", "(Ljava/util/List;)Lcom/squareup/picasso/RequestCreator;", "GetTransform_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Squareup.Picasso.RequestCreator Transform (global::System.Collections.Generic.IList<global::Com.Squareup.Picasso.ITransformation> transformations)
		{
			const string __id = "transform.(Ljava/util/List;)Lcom/squareup/picasso/RequestCreator;";
			IntPtr native_transformations = global::Android.Runtime.JavaList<global::Com.Squareup.Picasso.ITransformation>.ToLocalJniHandle (transformations);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_transformations);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_transformations);
			}
		}

	}
}
