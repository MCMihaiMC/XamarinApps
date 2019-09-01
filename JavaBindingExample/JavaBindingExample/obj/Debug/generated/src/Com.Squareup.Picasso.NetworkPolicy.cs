using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']"
	[global::Android.Runtime.Register ("com/squareup/picasso/NetworkPolicy", DoNotGenerateAcw=true)]
	public sealed partial class NetworkPolicy : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/field[@name='NO_CACHE']"
		[Register ("NO_CACHE")]
		public static global::Com.Squareup.Picasso.NetworkPolicy NoCache {
			get {
				const string __id = "NO_CACHE.Lcom/squareup/picasso/NetworkPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.NetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/field[@name='NO_STORE']"
		[Register ("NO_STORE")]
		public static global::Com.Squareup.Picasso.NetworkPolicy NoStore {
			get {
				const string __id = "NO_STORE.Lcom/squareup/picasso/NetworkPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.NetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/field[@name='OFFLINE']"
		[Register ("OFFLINE")]
		public static global::Com.Squareup.Picasso.NetworkPolicy Offline {
			get {
				const string __id = "OFFLINE.Lcom/squareup/picasso/NetworkPolicy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.NetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/NetworkPolicy", typeof (NetworkPolicy));
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

		internal NetworkPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/method[@name='isOfflineOnly' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isOfflineOnly", "(I)Z", "")]
		public static unsafe bool IsOfflineOnly (int networkPolicy)
		{
			const string __id = "isOfflineOnly.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (networkPolicy);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/method[@name='shouldReadFromDiskCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shouldReadFromDiskCache", "(I)Z", "")]
		public static unsafe bool ShouldReadFromDiskCache (int networkPolicy)
		{
			const string __id = "shouldReadFromDiskCache.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (networkPolicy);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/method[@name='shouldWriteToDiskCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shouldWriteToDiskCache", "(I)Z", "")]
		public static unsafe bool ShouldWriteToDiskCache (int networkPolicy)
		{
			const string __id = "shouldWriteToDiskCache.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (networkPolicy);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/squareup/picasso/NetworkPolicy;", "")]
		public static unsafe global::Com.Squareup.Picasso.NetworkPolicy ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/squareup/picasso/NetworkPolicy;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.NetworkPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='NetworkPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/squareup/picasso/NetworkPolicy;", "")]
		public static unsafe global::Com.Squareup.Picasso.NetworkPolicy[] Values ()
		{
			const string __id = "values.()[Lcom/squareup/picasso/NetworkPolicy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Squareup.Picasso.NetworkPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Squareup.Picasso.NetworkPolicy));
			} finally {
			}
		}

	}
}
