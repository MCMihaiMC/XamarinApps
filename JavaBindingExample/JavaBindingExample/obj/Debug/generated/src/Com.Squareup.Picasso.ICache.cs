using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	[Register ("com/squareup/picasso/Cache", DoNotGenerateAcw=true)]
	public abstract class Cache : Java.Lang.Object {

		internal Cache ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Squareup.Picasso.ICache None {
			get {
				const string __id = "NONE.Lcom/squareup/picasso/Cache;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		new static JniPeerMembers _members = new JniPeerMembers ("com/squareup/picasso/Cache", typeof (Cache));
	}

	[Register ("com/squareup/picasso/Cache", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Cache' type. This type will be removed in a future release.")]
	public abstract class CacheConsts : Cache {

		private CacheConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']"
	[Register ("com/squareup/picasso/Cache", "", "Com.Squareup.Picasso.ICacheInvoker")]
	public partial interface ICache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='clearKeyUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearKeyUri", "(Ljava/lang/String;)V", "GetClearKeyUri_Ljava_lang_String_Handler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		void ClearKeyUri (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGet_Ljava_lang_String_Handler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		global::Android.Graphics.Bitmap Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='maxSize' and count(parameter)=0]"
		[Register ("maxSize", "()I", "GetMaxSizeHandler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		int MaxSize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		void Set (string p0, global::Android.Graphics.Bitmap p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler:Com.Squareup.Picasso.ICacheInvoker, JavaBindingExample")]
		int Size ();

	}

	[global::Android.Runtime.Register ("com/squareup/picasso/Cache", DoNotGenerateAcw=true)]
	internal class ICacheInvoker : global::Java.Lang.Object, ICache {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/picasso/Cache", typeof (ICacheInvoker));

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

		public static ICache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.picasso.Cache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_clearKeyUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearKeyUri_Ljava_lang_String_Handler ()
		{
			if (cb_clearKeyUri_Ljava_lang_String_ == null)
				cb_clearKeyUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearKeyUri_Ljava_lang_String_);
			return cb_clearKeyUri_Ljava_lang_String_;
		}

		static void n_ClearKeyUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearKeyUri (p0);
		}
#pragma warning restore 0169

		IntPtr id_clearKeyUri_Ljava_lang_String_;
		public unsafe void ClearKeyUri (string p0)
		{
			if (id_clearKeyUri_Ljava_lang_String_ == IntPtr.Zero)
				id_clearKeyUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearKeyUri", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearKeyUri_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Android.Graphics.Bitmap Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_maxSize;
#pragma warning disable 0169
		static Delegate GetMaxSizeHandler ()
		{
			if (cb_maxSize == null)
				cb_maxSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxSize);
			return cb_maxSize;
		}

		static int n_MaxSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize ();
		}
#pragma warning restore 0169

		IntPtr id_maxSize;
		public unsafe int MaxSize ()
		{
			if (id_maxSize == IntPtr.Zero)
				id_maxSize = JNIEnv.GetMethodID (class_ref, "maxSize", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxSize);
		}

		static Delegate cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
		public unsafe void Set (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_set_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
		}

	}

}
