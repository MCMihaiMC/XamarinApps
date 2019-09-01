using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']"
	[global::Android.Runtime.Register ("com/squareup/picasso/LruCache", DoNotGenerateAcw=true)]
	public partial class LruCache : global::Java.Lang.Object, global::Com.Squareup.Picasso.ICache {


		public static class InterfaceConsts {

			// The following are fields from: com.squareup.picasso.Cache


			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Squareup.Picasso.ICache None {
				get {
					const string __id = "NONE.Lcom/squareup/picasso/Cache;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/LruCache", typeof (LruCache));
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

		protected LruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/constructor[@name='LruCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LruCache (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/constructor[@name='LruCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LruCache (int maxSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='clearKeyUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearKeyUri", "(Ljava/lang/String;)V", "")]
		public unsafe void ClearKeyUri (string uri)
		{
			const string __id = "clearKeyUri.(Ljava/lang/String;)V";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			const string __id = "evictAll.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='evictionCount' and count(parameter)=0]"
		[Register ("evictionCount", "()I", "")]
		public unsafe int EvictionCount ()
		{
			const string __id = "evictionCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Squareup.Picasso.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='hitCount' and count(parameter)=0]"
		[Register ("hitCount", "()I", "")]
		public unsafe int HitCount ()
		{
			const string __id = "hitCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='maxSize' and count(parameter)=0]"
		[Register ("maxSize", "()I", "")]
		public unsafe int MaxSize ()
		{
			const string __id = "maxSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='missCount' and count(parameter)=0]"
		[Register ("missCount", "()I", "")]
		public unsafe int MissCount ()
		{
			const string __id = "missCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='putCount' and count(parameter)=0]"
		[Register ("putCount", "()I", "")]
		public unsafe int PutCount ()
		{
			const string __id = "putCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_bitmap)
		{
			global::Com.Squareup.Picasso.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Set (string key, global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "set.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
