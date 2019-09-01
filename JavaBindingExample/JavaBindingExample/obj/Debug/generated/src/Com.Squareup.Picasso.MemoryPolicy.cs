using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='MemoryPolicy']"
	[global::Android.Runtime.Register ("com/squareup/picasso/MemoryPolicy", DoNotGenerateAcw=true)]
	public sealed partial class MemoryPolicy : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='MemoryPolicy']/field[@name='NO_CACHE']"
		[Register ("NO_CACHE")]
		public static global::Com.Squareup.Picasso.MemoryPolicy NoCache {
			get {
				const string __id = "NO_CACHE.Lcom/squareup/picasso/MemoryPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.MemoryPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='MemoryPolicy']/field[@name='NO_STORE']"
		[Register ("NO_STORE")]
		public static global::Com.Squareup.Picasso.MemoryPolicy NoStore {
			get {
				const string __id = "NO_STORE.Lcom/squareup/picasso/MemoryPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.MemoryPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/MemoryPolicy", typeof (MemoryPolicy));
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

		internal MemoryPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='MemoryPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/squareup/picasso/MemoryPolicy;", "")]
		public static unsafe global::Com.Squareup.Picasso.MemoryPolicy ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/squareup/picasso/MemoryPolicy;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.MemoryPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='MemoryPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/squareup/picasso/MemoryPolicy;", "")]
		public static unsafe global::Com.Squareup.Picasso.MemoryPolicy[] Values ()
		{
			const string __id = "values.()[Lcom/squareup/picasso/MemoryPolicy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Squareup.Picasso.MemoryPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Squareup.Picasso.MemoryPolicy));
			} finally {
			}
		}

	}
}
