using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/squareup/picasso/Request", DoNotGenerateAcw=true)]
	public sealed partial class Request : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='centerCrop']"
		[Register ("centerCrop")]
		public bool CenterCrop {
			get {
				const string __id = "centerCrop.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "centerCrop.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='centerInside']"
		[Register ("centerInside")]
		public bool CenterInside {
			get {
				const string __id = "centerInside.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "centerInside.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='config']"
		[Register ("config")]
		public global::Android.Graphics.Bitmap.Config Config {
			get {
				const string __id = "config.Landroid/graphics/Bitmap$Config;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "config.Landroid/graphics/Bitmap$Config;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='hasRotationPivot']"
		[Register ("hasRotationPivot")]
		public bool HasRotationPivot {
			get {
				const string __id = "hasRotationPivot.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "hasRotationPivot.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='onlyScaleDown']"
		[Register ("onlyScaleDown")]
		public bool OnlyScaleDown {
			get {
				const string __id = "onlyScaleDown.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "onlyScaleDown.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='priority']"
		[Register ("priority")]
		public global::Com.Squareup.Picasso.Picasso.Priority Priority {
			get {
				const string __id = "priority.Lcom/squareup/picasso/Picasso$Priority;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "priority.Lcom/squareup/picasso/Picasso$Priority;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='resourceId']"
		[Register ("resourceId")]
		public int ResourceId {
			get {
				const string __id = "resourceId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "resourceId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='rotationDegrees']"
		[Register ("rotationDegrees")]
		public float RotationDegrees {
			get {
				const string __id = "rotationDegrees.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rotationDegrees.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='rotationPivotX']"
		[Register ("rotationPivotX")]
		public float RotationPivotX {
			get {
				const string __id = "rotationPivotX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rotationPivotX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='rotationPivotY']"
		[Register ("rotationPivotY")]
		public float RotationPivotY {
			get {
				const string __id = "rotationPivotY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rotationPivotY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='stableKey']"
		[Register ("stableKey")]
		public string StableKey {
			get {
				const string __id = "stableKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stableKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='targetHeight']"
		[Register ("targetHeight")]
		public int TargetHeight {
			get {
				const string __id = "targetHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "targetHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='targetWidth']"
		[Register ("targetWidth")]
		public int TargetWidth {
			get {
				const string __id = "targetWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "targetWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='transformations']"
		[Register ("transformations")]
		public global::System.Collections.IList Transformations {
			get {
				const string __id = "transformations.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transformations.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/field[@name='uri']"
		[Register ("uri")]
		public global::Android.Net.Uri Uri {
			get {
				const string __id = "uri.Landroid/net/Uri;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Landroid/net/Uri;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']"
		[global::Android.Runtime.Register ("com/squareup/picasso/Request$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Request$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/constructor[@name='Request.Builder' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register (".ctor", "(Landroid/net/Uri;)V", "")]
			public unsafe Builder (global::Android.Net.Uri uri)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/net/Uri;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/constructor[@name='Request.Builder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Builder (int resourceId)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resourceId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/squareup/picasso/Request;", "")]
			public unsafe global::Com.Squareup.Picasso.Request Build ()
			{
				const string __id = "build.()Lcom/squareup/picasso/Request;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='centerCrop' and count(parameter)=0]"
			[Register ("centerCrop", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder CenterCrop ()
			{
				const string __id = "centerCrop.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='centerInside' and count(parameter)=0]"
			[Register ("centerInside", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder CenterInside ()
			{
				const string __id = "centerInside.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='clearCenterCrop' and count(parameter)=0]"
			[Register ("clearCenterCrop", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder ClearCenterCrop ()
			{
				const string __id = "clearCenterCrop.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='clearCenterInside' and count(parameter)=0]"
			[Register ("clearCenterInside", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder ClearCenterInside ()
			{
				const string __id = "clearCenterInside.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='clearOnlyScaleDown' and count(parameter)=0]"
			[Register ("clearOnlyScaleDown", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder ClearOnlyScaleDown ()
			{
				const string __id = "clearOnlyScaleDown.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='clearResize' and count(parameter)=0]"
			[Register ("clearResize", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder ClearResize ()
			{
				const string __id = "clearResize.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='clearRotation' and count(parameter)=0]"
			[Register ("clearRotation", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder ClearRotation ()
			{
				const string __id = "clearRotation.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='config' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
			[Register ("config", "(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Config (global::Android.Graphics.Bitmap.Config config)
			{
				const string __id = "config.(Landroid/graphics/Bitmap$Config;)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='onlyScaleDown' and count(parameter)=0]"
			[Register ("onlyScaleDown", "()Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder OnlyScaleDown ()
			{
				const string __id = "onlyScaleDown.()Lcom/squareup/picasso/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='priority' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Picasso.Priority']]"
			[Register ("priority", "(Lcom/squareup/picasso/Picasso$Priority;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Priority (global::Com.Squareup.Picasso.Picasso.Priority priority)
			{
				const string __id = "priority.(Lcom/squareup/picasso/Picasso$Priority;)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((priority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priority).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='resize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("resize", "(II)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Resize (int targetWidth, int targetHeight)
			{
				const string __id = "resize.(II)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (targetWidth);
					__args [1] = new JniArgumentValue (targetHeight);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("rotate", "(F)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Rotate (float degrees)
			{
				const string __id = "rotate.(F)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (degrees);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='rotate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("rotate", "(FFF)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Rotate (float degrees, float pivotX, float pivotY)
			{
				const string __id = "rotate.(FFF)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (degrees);
					__args [1] = new JniArgumentValue (pivotX);
					__args [2] = new JniArgumentValue (pivotY);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='setResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResourceId", "(I)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder SetResourceId (int resourceId)
			{
				const string __id = "setResourceId.(I)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resourceId);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setUri", "(Landroid/net/Uri;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder SetUri (global::Android.Net.Uri uri)
			{
				const string __id = "setUri.(Landroid/net/Uri;)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='stableKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("stableKey", "(Ljava/lang/String;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder StableKey (string stableKey)
			{
				const string __id = "stableKey.(Ljava/lang/String;)Lcom/squareup/picasso/Request$Builder;";
				IntPtr native_stableKey = JNIEnv.NewString (stableKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_stableKey);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_stableKey);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Transformation']]"
			[Register ("transform", "(Lcom/squareup/picasso/Transformation;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Transform (global::Com.Squareup.Picasso.ITransformation transformation)
			{
				const string __id = "transform.(Lcom/squareup/picasso/Transformation;)Lcom/squareup/picasso/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((transformation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformation).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request.Builder']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.squareup.picasso.Transformation&gt;']]"
			[Register ("transform", "(Ljava/util/List;)Lcom/squareup/picasso/Request$Builder;", "")]
			public unsafe global::Com.Squareup.Picasso.Request.Builder Transform (global::System.Collections.Generic.IList<global::Com.Squareup.Picasso.ITransformation> transformations)
			{
				const string __id = "transform.(Ljava/util/List;)Lcom/squareup/picasso/Request$Builder;";
				IntPtr native_transformations = global::Android.Runtime.JavaList<global::Com.Squareup.Picasso.ITransformation>.ToLocalJniHandle (transformations);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_transformations);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_transformations);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/Request", typeof (Request));
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

		internal Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool HasSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/method[@name='hasSize' and count(parameter)=0]"
			[Register ("hasSize", "()Z", "GetHasSizeHandler")]
			get {
				const string __id = "hasSize.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Request']/method[@name='buildUpon' and count(parameter)=0]"
		[Register ("buildUpon", "()Lcom/squareup/picasso/Request$Builder;", "")]
		public unsafe global::Com.Squareup.Picasso.Request.Builder BuildUpon ()
		{
			const string __id = "buildUpon.()Lcom/squareup/picasso/Request$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
