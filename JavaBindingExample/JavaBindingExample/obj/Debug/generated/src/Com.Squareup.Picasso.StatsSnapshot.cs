using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']"
	[global::Android.Runtime.Register ("com/squareup/picasso/StatsSnapshot", DoNotGenerateAcw=true)]
	public partial class StatsSnapshot : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='averageDownloadSize']"
		[Register ("averageDownloadSize")]
		public long AverageDownloadSize {
			get {
				const string __id = "averageDownloadSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "averageDownloadSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='averageOriginalBitmapSize']"
		[Register ("averageOriginalBitmapSize")]
		public long AverageOriginalBitmapSize {
			get {
				const string __id = "averageOriginalBitmapSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "averageOriginalBitmapSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='averageTransformedBitmapSize']"
		[Register ("averageTransformedBitmapSize")]
		public long AverageTransformedBitmapSize {
			get {
				const string __id = "averageTransformedBitmapSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "averageTransformedBitmapSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='cacheHits']"
		[Register ("cacheHits")]
		public long CacheHits {
			get {
				const string __id = "cacheHits.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cacheHits.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='cacheMisses']"
		[Register ("cacheMisses")]
		public long CacheMisses {
			get {
				const string __id = "cacheMisses.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cacheMisses.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='downloadCount']"
		[Register ("downloadCount")]
		public int DownloadCount {
			get {
				const string __id = "downloadCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "downloadCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='maxSize']"
		[Register ("maxSize")]
		public int MaxSize {
			get {
				const string __id = "maxSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='originalBitmapCount']"
		[Register ("originalBitmapCount")]
		public int OriginalBitmapCount {
			get {
				const string __id = "originalBitmapCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "originalBitmapCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				const string __id = "size.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "size.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='timeStamp']"
		[Register ("timeStamp")]
		public long TimeStamp {
			get {
				const string __id = "timeStamp.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timeStamp.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='totalDownloadSize']"
		[Register ("totalDownloadSize")]
		public long TotalDownloadSize {
			get {
				const string __id = "totalDownloadSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalDownloadSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='totalOriginalBitmapSize']"
		[Register ("totalOriginalBitmapSize")]
		public long TotalOriginalBitmapSize {
			get {
				const string __id = "totalOriginalBitmapSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalOriginalBitmapSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='totalTransformedBitmapSize']"
		[Register ("totalTransformedBitmapSize")]
		public long TotalTransformedBitmapSize {
			get {
				const string __id = "totalTransformedBitmapSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "totalTransformedBitmapSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/field[@name='transformedBitmapCount']"
		[Register ("transformedBitmapCount")]
		public int TransformedBitmapCount {
			get {
				const string __id = "transformedBitmapCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "transformedBitmapCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/squareup/picasso/StatsSnapshot", typeof (StatsSnapshot));
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

		protected StatsSnapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/constructor[@name='StatsSnapshot' and count(parameter)=14 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='long'] and parameter[9][@type='long'] and parameter[10][@type='long'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='int'] and parameter[14][@type='long']]"
		[Register (".ctor", "(IIJJJJJJJJIIIJ)V", "")]
		public unsafe StatsSnapshot (int maxSize, int size, long cacheHits, long cacheMisses, long totalDownloadSize, long totalOriginalBitmapSize, long totalTransformedBitmapSize, long averageDownloadSize, long averageOriginalBitmapSize, long averageTransformedBitmapSize, int downloadCount, int originalBitmapCount, int transformedBitmapCount, long timeStamp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIJJJJJJJJIIIJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue (maxSize);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue (cacheHits);
				__args [3] = new JniArgumentValue (cacheMisses);
				__args [4] = new JniArgumentValue (totalDownloadSize);
				__args [5] = new JniArgumentValue (totalOriginalBitmapSize);
				__args [6] = new JniArgumentValue (totalTransformedBitmapSize);
				__args [7] = new JniArgumentValue (averageDownloadSize);
				__args [8] = new JniArgumentValue (averageOriginalBitmapSize);
				__args [9] = new JniArgumentValue (averageTransformedBitmapSize);
				__args [10] = new JniArgumentValue (downloadCount);
				__args [11] = new JniArgumentValue (originalBitmapCount);
				__args [12] = new JniArgumentValue (transformedBitmapCount);
				__args [13] = new JniArgumentValue (timeStamp);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dump;
#pragma warning disable 0169
		static Delegate GetDumpHandler ()
		{
			if (cb_dump == null)
				cb_dump = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dump);
			return cb_dump;
		}

		static void n_Dump (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Picasso.StatsSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.StatsSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dump ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/method[@name='dump' and count(parameter)=0]"
		[Register ("dump", "()V", "GetDumpHandler")]
		public virtual unsafe void Dump ()
		{
			const string __id = "dump.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dump_Ljava_io_PrintWriter_;
#pragma warning disable 0169
		static Delegate GetDump_Ljava_io_PrintWriter_Handler ()
		{
			if (cb_dump_Ljava_io_PrintWriter_ == null)
				cb_dump_Ljava_io_PrintWriter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dump_Ljava_io_PrintWriter_);
			return cb_dump_Ljava_io_PrintWriter_;
		}

		static void n_Dump_Ljava_io_PrintWriter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_writer)
		{
			global::Com.Squareup.Picasso.StatsSnapshot __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.StatsSnapshot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PrintWriter writer = global::Java.Lang.Object.GetObject<global::Java.IO.PrintWriter> (native_writer, JniHandleOwnership.DoNotTransfer);
			__this.Dump (writer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='StatsSnapshot']/method[@name='dump' and count(parameter)=1 and parameter[1][@type='java.io.PrintWriter']]"
		[Register ("dump", "(Ljava/io/PrintWriter;)V", "GetDump_Ljava_io_PrintWriter_Handler")]
		public virtual unsafe void Dump (global::Java.IO.PrintWriter writer)
		{
			const string __id = "dump.(Ljava/io/PrintWriter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
