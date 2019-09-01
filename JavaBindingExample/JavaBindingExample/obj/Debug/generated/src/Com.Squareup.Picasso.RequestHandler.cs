using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']"
	[global::Android.Runtime.Register ("com/squareup/picasso/RequestHandler", DoNotGenerateAcw=true)]
	public abstract partial class RequestHandler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']"
		[global::Android.Runtime.Register ("com/squareup/picasso/RequestHandler$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/RequestHandler$Result", typeof (Result));
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

			internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']/constructor[@name='RequestHandler.Result' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.squareup.picasso.Picasso.LoadedFrom']]"
			[Register (".ctor", "(Landroid/graphics/Bitmap;Lcom/squareup/picasso/Picasso$LoadedFrom;)V", "")]
			public unsafe Result (global::Android.Graphics.Bitmap bitmap, global::Com.Squareup.Picasso.Picasso.LoadedFrom loadedFrom)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/graphics/Bitmap;Lcom/squareup/picasso/Picasso$LoadedFrom;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
					__args [1] = new JniArgumentValue ((loadedFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadedFrom).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']/constructor[@name='RequestHandler.Result' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.squareup.picasso.Picasso.LoadedFrom']]"
			[Register (".ctor", "(Ljava/io/InputStream;Lcom/squareup/picasso/Picasso$LoadedFrom;)V", "")]
			public unsafe Result (global::System.IO.Stream stream, global::Com.Squareup.Picasso.Picasso.LoadedFrom loadedFrom)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/InputStream;Lcom/squareup/picasso/Picasso$LoadedFrom;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_stream);
					__args [1] = new JniArgumentValue ((loadedFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loadedFrom).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_stream);
				}
			}

			public unsafe global::Android.Graphics.Bitmap Bitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']/method[@name='getBitmap' and count(parameter)=0]"
				[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
				get {
					const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Squareup.Picasso.Picasso.LoadedFrom LoadedFrom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']/method[@name='getLoadedFrom' and count(parameter)=0]"
				[Register ("getLoadedFrom", "()Lcom/squareup/picasso/Picasso$LoadedFrom;", "GetGetLoadedFromHandler")]
				get {
					const string __id = "getLoadedFrom.()Lcom/squareup/picasso/Picasso$LoadedFrom;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Picasso.LoadedFrom> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.IO.Stream Stream {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler.Result']/method[@name='getStream' and count(parameter)=0]"
				[Register ("getStream", "()Ljava/io/InputStream;", "GetGetStreamHandler")]
				get {
					const string __id = "getStream.()Ljava/io/InputStream;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/RequestHandler", typeof (RequestHandler));
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

		protected RequestHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']/constructor[@name='RequestHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_canHandleRequest_Lcom_squareup_picasso_Request_;
#pragma warning disable 0169
		static Delegate GetCanHandleRequest_Lcom_squareup_picasso_Request_Handler ()
		{
			if (cb_canHandleRequest_Lcom_squareup_picasso_Request_ == null)
				cb_canHandleRequest_Lcom_squareup_picasso_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanHandleRequest_Lcom_squareup_picasso_Request_);
			return cb_canHandleRequest_Lcom_squareup_picasso_Request_;
		}

		static bool n_CanHandleRequest_Lcom_squareup_picasso_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Picasso.RequestHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanHandleRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']/method[@name='canHandleRequest' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Request']]"
		[Register ("canHandleRequest", "(Lcom/squareup/picasso/Request;)Z", "GetCanHandleRequest_Lcom_squareup_picasso_Request_Handler")]
		public abstract bool CanHandleRequest (global::Com.Squareup.Picasso.Request p0);

		static Delegate cb_load_Lcom_squareup_picasso_Request_I;
#pragma warning disable 0169
		static Delegate GetLoad_Lcom_squareup_picasso_Request_IHandler ()
		{
			if (cb_load_Lcom_squareup_picasso_Request_I == null)
				cb_load_Lcom_squareup_picasso_Request_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Load_Lcom_squareup_picasso_Request_I);
			return cb_load_Lcom_squareup_picasso_Request_I;
		}

		static IntPtr n_Load_Lcom_squareup_picasso_Request_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Squareup.Picasso.RequestHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Picasso.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Load (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']/method[@name='load' and count(parameter)=2 and parameter[1][@type='com.squareup.picasso.Request'] and parameter[2][@type='int']]"
		[Register ("load", "(Lcom/squareup/picasso/Request;I)Lcom/squareup/picasso/RequestHandler$Result;", "GetLoad_Lcom_squareup_picasso_Request_IHandler")]
		public abstract global::Com.Squareup.Picasso.RequestHandler.Result Load (global::Com.Squareup.Picasso.Request p0, int p1);

	}

	[global::Android.Runtime.Register ("com/squareup/picasso/RequestHandler", DoNotGenerateAcw=true)]
	internal partial class RequestHandlerInvoker : RequestHandler {

		public RequestHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/squareup/picasso/RequestHandler", typeof (RequestHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']/method[@name='canHandleRequest' and count(parameter)=1 and parameter[1][@type='com.squareup.picasso.Request']]"
		[Register ("canHandleRequest", "(Lcom/squareup/picasso/Request;)Z", "GetCanHandleRequest_Lcom_squareup_picasso_Request_Handler")]
		public override unsafe bool CanHandleRequest (global::Com.Squareup.Picasso.Request p0)
		{
			const string __id = "canHandleRequest.(Lcom/squareup/picasso/Request;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='RequestHandler']/method[@name='load' and count(parameter)=2 and parameter[1][@type='com.squareup.picasso.Request'] and parameter[2][@type='int']]"
		[Register ("load", "(Lcom/squareup/picasso/Request;I)Lcom/squareup/picasso/RequestHandler$Result;", "GetLoad_Lcom_squareup_picasso_Request_IHandler")]
		public override unsafe global::Com.Squareup.Picasso.RequestHandler.Result Load (global::Com.Squareup.Picasso.Request p0, int p1)
		{
			const string __id = "load.(Lcom/squareup/picasso/Request;I)Lcom/squareup/picasso/RequestHandler$Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.RequestHandler.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
