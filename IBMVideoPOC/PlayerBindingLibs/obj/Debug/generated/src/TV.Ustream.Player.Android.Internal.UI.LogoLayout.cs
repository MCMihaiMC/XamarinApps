using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace TV.Ustream.Player.Android.Internal.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']"
	[global::Android.Runtime.Register ("tv/ustream/player/android/internal/ui/LogoLayout", DoNotGenerateAcw=true)]
	public partial class LogoLayout : global::Android.Widget.RelativeLayout, global::Android.Views.ViewGroup.IOnHierarchyChangeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("tv/ustream/player/android/internal/ui/LogoLayout", typeof (LogoLayout));
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

		protected LogoLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/constructor[@name='LogoLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LogoLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_alignLogo_IIII;
#pragma warning disable 0169
		static Delegate GetAlignLogo_IIIIHandler ()
		{
			if (cb_alignLogo_IIII == null)
				cb_alignLogo_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_AlignLogo_IIII);
			return cb_alignLogo_IIII;
		}

		static void n_AlignLogo_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AlignLogo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='alignLogo' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("alignLogo", "(IIII)V", "GetAlignLogo_IIIIHandler")]
		public virtual unsafe void AlignLogo (int p0, int p1, int p2, int p3)
		{
			const string __id = "alignLogo.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler ()
		{
			if (cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == null)
				cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_);
			return cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
		}

		static void n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChildViewAdded (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='onChildViewAdded' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
		[Register ("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler")]
		public virtual unsafe void OnChildViewAdded (global::Android.Views.View p0, global::Android.Views.View p1)
		{
			const string __id = "onChildViewAdded.(Landroid/view/View;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler ()
		{
			if (cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == null)
				cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_);
			return cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
		}

		static void n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChildViewRemoved (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='onChildViewRemoved' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
		[Register ("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler")]
		public virtual unsafe void OnChildViewRemoved (global::Android.Views.View p0, global::Android.Views.View p1)
		{
			const string __id = "onChildViewRemoved.(Landroid/view/View;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLogoImage_ILandroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetLogoImage_ILandroid_graphics_Bitmap_Handler ()
		{
			if (cb_setLogoImage_ILandroid_graphics_Bitmap_ == null)
				cb_setLogoImage_ILandroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetLogoImage_ILandroid_graphics_Bitmap_);
			return cb_setLogoImage_ILandroid_graphics_Bitmap_;
		}

		static void n_SetLogoImage_ILandroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLogoImage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='setLogoImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("setLogoImage", "(ILandroid/graphics/Bitmap;)V", "GetSetLogoImage_ILandroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetLogoImage (int p0, global::Android.Graphics.Bitmap p1)
		{
			const string __id = "setLogoImage.(ILandroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnLogoClickListener_ILandroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLogoClickListener_ILandroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setOnLogoClickListener_ILandroid_view_View_OnClickListener_ == null)
				cb_setOnLogoClickListener_ILandroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnLogoClickListener_ILandroid_view_View_OnClickListener_);
			return cb_setOnLogoClickListener_ILandroid_view_View_OnClickListener_;
		}

		static void n_SetOnLogoClickListener_ILandroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p1 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLogoClickListener (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='setOnLogoClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View.OnClickListener']]"
		[Register ("setOnLogoClickListener", "(ILandroid/view/View$OnClickListener;)V", "GetSetOnLogoClickListener_ILandroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetOnLogoClickListener (int p0, global::Android.Views.View.IOnClickListener p1)
		{
			const string __id = "setOnLogoClickListener.(ILandroid/view/View$OnClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toggleLogo_IZ;
#pragma warning disable 0169
		static Delegate GetToggleLogo_IZHandler ()
		{
			if (cb_toggleLogo_IZ == null)
				cb_toggleLogo_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_ToggleLogo_IZ);
			return cb_toggleLogo_IZ;
		}

		static void n_ToggleLogo_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::TV.Ustream.Player.Android.Internal.UI.LogoLayout __this = global::Java.Lang.Object.GetObject<global::TV.Ustream.Player.Android.Internal.UI.LogoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleLogo (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.ustream.player.android.internal.ui']/class[@name='LogoLayout']/method[@name='toggleLogo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("toggleLogo", "(IZ)V", "GetToggleLogo_IZHandler")]
		public virtual unsafe void ToggleLogo (int p0, bool p1)
		{
			const string __id = "toggleLogo.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
