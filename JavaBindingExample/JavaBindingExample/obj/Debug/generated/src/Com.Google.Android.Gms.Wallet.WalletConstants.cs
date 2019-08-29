using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']"
	[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants", DoNotGenerateAcw=true)]
	public sealed partial class WalletConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ACTION_ENABLE_WALLET_OPTIMIZATION']"
		[Register ("ACTION_ENABLE_WALLET_OPTIMIZATION")]
		[Obsolete ("deprecated")]
		public const string ActionEnableWalletOptimization = (string) "com.google.android.gms.wallet.ENABLE_WALLET_OPTIMIZATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='BILLING_ADDRESS_FORMAT_FULL']"
		[Register ("BILLING_ADDRESS_FORMAT_FULL")]
		public const int BillingAddressFormatFull = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='BILLING_ADDRESS_FORMAT_MIN']"
		[Register ("BILLING_ADDRESS_FORMAT_MIN")]
		public const int BillingAddressFormatMin = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_CLASS_CREDIT']"
		[Register ("CARD_CLASS_CREDIT")]
		public const int CardClassCredit = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_CLASS_DEBIT']"
		[Register ("CARD_CLASS_DEBIT")]
		public const int CardClassDebit = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_CLASS_PREPAID']"
		[Register ("CARD_CLASS_PREPAID")]
		public const int CardClassPrepaid = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_CLASS_UNKNOWN']"
		[Register ("CARD_CLASS_UNKNOWN")]
		public const int CardClassUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_AMEX']"
		[Register ("CARD_NETWORK_AMEX")]
		public const int CardNetworkAmex = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_DISCOVER']"
		[Register ("CARD_NETWORK_DISCOVER")]
		public const int CardNetworkDiscover = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_INTERAC']"
		[Register ("CARD_NETWORK_INTERAC")]
		public const int CardNetworkInterac = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_JCB']"
		[Register ("CARD_NETWORK_JCB")]
		public const int CardNetworkJcb = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_MASTERCARD']"
		[Register ("CARD_NETWORK_MASTERCARD")]
		public const int CardNetworkMastercard = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_OTHER']"
		[Register ("CARD_NETWORK_OTHER")]
		public const int CardNetworkOther = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='CARD_NETWORK_VISA']"
		[Register ("CARD_NETWORK_VISA")]
		public const int CardNetworkVisa = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ENVIRONMENT_PRODUCTION']"
		[Register ("ENVIRONMENT_PRODUCTION")]
		public const int EnvironmentProduction = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ENVIRONMENT_SANDBOX']"
		[Register ("ENVIRONMENT_SANDBOX")]
		[Obsolete ("deprecated")]
		public const int EnvironmentSandbox = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ENVIRONMENT_STRICT_SANDBOX']"
		[Register ("ENVIRONMENT_STRICT_SANDBOX")]
		[Obsolete ("deprecated")]
		public const int EnvironmentStrictSandbox = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ENVIRONMENT_TEST']"
		[Register ("ENVIRONMENT_TEST")]
		public const int EnvironmentTest = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_AUTHENTICATION_FAILURE']"
		[Register ("ERROR_CODE_AUTHENTICATION_FAILURE")]
		public const int ErrorCodeAuthenticationFailure = (int) 411;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_BUYER_ACCOUNT_ERROR']"
		[Register ("ERROR_CODE_BUYER_ACCOUNT_ERROR")]
		public const int ErrorCodeBuyerAccountError = (int) 409;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_DEVELOPER_ERROR']"
		[Register ("ERROR_CODE_DEVELOPER_ERROR")]
		public const int ErrorCodeDeveloperError = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_INTERNAL_ERROR']"
		[Register ("ERROR_CODE_INTERNAL_ERROR")]
		public const int ErrorCodeInternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_INVALID_PARAMETERS']"
		[Register ("ERROR_CODE_INVALID_PARAMETERS")]
		public const int ErrorCodeInvalidParameters = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_INVALID_TRANSACTION']"
		[Register ("ERROR_CODE_INVALID_TRANSACTION")]
		public const int ErrorCodeInvalidTransaction = (int) 410;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_MERCHANT_ACCOUNT_ERROR']"
		[Register ("ERROR_CODE_MERCHANT_ACCOUNT_ERROR")]
		public const int ErrorCodeMerchantAccountError = (int) 405;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_SERVICE_UNAVAILABLE']"
		[Register ("ERROR_CODE_SERVICE_UNAVAILABLE")]
		public const int ErrorCodeServiceUnavailable = (int) 402;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_SPENDING_LIMIT_EXCEEDED']"
		[Register ("ERROR_CODE_SPENDING_LIMIT_EXCEEDED")]
		[Obsolete ("deprecated")]
		public const int ErrorCodeSpendingLimitExceeded = (int) 406;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_UNKNOWN']"
		[Register ("ERROR_CODE_UNKNOWN")]
		public const int ErrorCodeUnknown = (int) 413;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='ERROR_CODE_UNSUPPORTED_API_VERSION']"
		[Register ("ERROR_CODE_UNSUPPORTED_API_VERSION")]
		public const int ErrorCodeUnsupportedApiVersion = (int) 412;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='EXTRA_ERROR_CODE']"
		[Register ("EXTRA_ERROR_CODE")]
		public const string ExtraErrorCode = (string) "com.google.android.gms.wallet.EXTRA_ERROR_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='EXTRA_IS_READY_TO_PAY']"
		[Register ("EXTRA_IS_READY_TO_PAY")]
		public const string ExtraIsReadyToPay = (string) "com.google.android.gms.wallet.EXTRA_IS_READY_TO_PAY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='EXTRA_IS_USER_PREAUTHORIZED']"
		[Register ("EXTRA_IS_USER_PREAUTHORIZED")]
		public const string ExtraIsUserPreauthorized = (string) "com.google.android.gm.wallet.EXTRA_IS_USER_PREAUTHORIZED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='METADATA_TAG_WALLET_API_ENABLED']"
		[Register ("METADATA_TAG_WALLET_API_ENABLED")]
		public const string MetadataTagWalletApiEnabled = (string) "com.google.android.gms.wallet.api.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_CARD']"
		[Register ("PAYMENT_METHOD_CARD")]
		public const int PaymentMethodCard = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_TOKENIZATION_TYPE_DIRECT']"
		[Register ("PAYMENT_METHOD_TOKENIZATION_TYPE_DIRECT")]
		public const int PaymentMethodTokenizationTypeDirect = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_TOKENIZATION_TYPE_NETWORK_TOKEN']"
		[Register ("PAYMENT_METHOD_TOKENIZATION_TYPE_NETWORK_TOKEN")]
		[Obsolete ("deprecated")]
		public const int PaymentMethodTokenizationTypeNetworkToken = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_TOKENIZATION_TYPE_PAYMENT_GATEWAY']"
		[Register ("PAYMENT_METHOD_TOKENIZATION_TYPE_PAYMENT_GATEWAY")]
		public const int PaymentMethodTokenizationTypePaymentGateway = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_TOKENIZED_CARD']"
		[Register ("PAYMENT_METHOD_TOKENIZED_CARD")]
		public const int PaymentMethodTokenizedCard = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='PAYMENT_METHOD_UNKNOWN']"
		[Register ("PAYMENT_METHOD_UNKNOWN")]
		public const int PaymentMethodUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='THEME_DARK']"
		[Register ("THEME_DARK")]
		[Obsolete ("deprecated")]
		public const int ThemeDark = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='THEME_HOLO_DARK']"
		[Register ("THEME_HOLO_DARK")]
		[Obsolete ("deprecated")]
		public const int ThemeHoloDark = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='THEME_HOLO_LIGHT']"
		[Register ("THEME_HOLO_LIGHT")]
		[Obsolete ("deprecated")]
		public const int ThemeHoloLight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='THEME_LIGHT']"
		[Register ("THEME_LIGHT")]
		public const int ThemeLight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='TOTAL_PRICE_STATUS_ESTIMATED']"
		[Register ("TOTAL_PRICE_STATUS_ESTIMATED")]
		public const int TotalPriceStatusEstimated = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='TOTAL_PRICE_STATUS_FINAL']"
		[Register ("TOTAL_PRICE_STATUS_FINAL")]
		public const int TotalPriceStatusFinal = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/class[@name='WalletConstants']/field[@name='TOTAL_PRICE_STATUS_NOT_CURRENTLY_KNOWN']"
		[Register ("TOTAL_PRICE_STATUS_NOT_CURRENTLY_KNOWN")]
		public const int TotalPriceStatusNotCurrentlyKnown = (int) 1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.BillingAddressFormat']"
		[Register ("com/google/android/gms/wallet/WalletConstants$BillingAddressFormat", "", "Com.Google.Android.Gms.Wallet.WalletConstants/IBillingAddressFormatInvoker")]
		public partial interface IBillingAddressFormat : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$BillingAddressFormat", DoNotGenerateAcw=true)]
		internal class IBillingAddressFormatInvoker : global::Java.Lang.Object, IBillingAddressFormat {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$BillingAddressFormat", typeof (IBillingAddressFormatInvoker));

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

			public static IBillingAddressFormat GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBillingAddressFormat> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.BillingAddressFormat"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBillingAddressFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IBillingAddressFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardClass']"
		[Register ("com/google/android/gms/wallet/WalletConstants$CardClass", "", "Com.Google.Android.Gms.Wallet.WalletConstants/ICardClassInvoker")]
		public partial interface ICardClass : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$CardClass", DoNotGenerateAcw=true)]
		internal class ICardClassInvoker : global::Java.Lang.Object, ICardClass {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$CardClass", typeof (ICardClassInvoker));

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

			public static ICardClass GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICardClass> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.CardClass"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICardClassInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardClass> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		[Register ("com/google/android/gms/wallet/WalletConstants$CardNetwork", DoNotGenerateAcw=true)]
		public abstract class CardNetwork : Java.Lang.Object {

			internal CardNetwork ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='AMEX']"
			[Register ("AMEX")]
			[Obsolete ("deprecated")]
			public const int Amex = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='DISCOVER']"
			[Register ("DISCOVER")]
			[Obsolete ("deprecated")]
			public const int Discover = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='INTERAC']"
			[Register ("INTERAC")]
			[Obsolete ("deprecated")]
			public const int Interac = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='JCB']"
			[Register ("JCB")]
			[Obsolete ("deprecated")]
			public const int Jcb = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='MASTERCARD']"
			[Register ("MASTERCARD")]
			[Obsolete ("deprecated")]
			public const int Mastercard = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='OTHER']"
			[Register ("OTHER")]
			[Obsolete ("deprecated")]
			public const int Other = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']/field[@name='VISA']"
			[Register ("VISA")]
			[Obsolete ("deprecated")]
			public const int Visa = (int) 5;

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable
		}

		[Register ("com/google/android/gms/wallet/WalletConstants$CardNetwork", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'CardNetwork' type. This type will be removed in a future release.")]
		public abstract class CardNetworkConsts : CardNetwork {

			private CardNetworkConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.CardNetwork']"
		[Register ("com/google/android/gms/wallet/WalletConstants$CardNetwork", "", "Com.Google.Android.Gms.Wallet.WalletConstants/ICardNetworkInvoker")]
		public partial interface ICardNetwork : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$CardNetwork", DoNotGenerateAcw=true)]
		internal class ICardNetworkInvoker : global::Java.Lang.Object, ICardNetwork {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$CardNetwork", typeof (ICardNetworkInvoker));

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

			public static ICardNetwork GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICardNetwork> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.CardNetwork"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICardNetworkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ICardNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.PaymentMethod']"
		[Register ("com/google/android/gms/wallet/WalletConstants$PaymentMethod", "", "Com.Google.Android.Gms.Wallet.WalletConstants/IPaymentMethodInvoker")]
		public partial interface IPaymentMethod : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$PaymentMethod", DoNotGenerateAcw=true)]
		internal class IPaymentMethodInvoker : global::Java.Lang.Object, IPaymentMethod {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$PaymentMethod", typeof (IPaymentMethodInvoker));

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

			public static IPaymentMethod GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPaymentMethod> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.PaymentMethod"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPaymentMethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.PaymentMethodTokenizationType']"
		[Register ("com/google/android/gms/wallet/WalletConstants$PaymentMethodTokenizationType", "", "Com.Google.Android.Gms.Wallet.WalletConstants/IPaymentMethodTokenizationTypeInvoker")]
		public partial interface IPaymentMethodTokenizationType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$PaymentMethodTokenizationType", DoNotGenerateAcw=true)]
		internal class IPaymentMethodTokenizationTypeInvoker : global::Java.Lang.Object, IPaymentMethodTokenizationType {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$PaymentMethodTokenizationType", typeof (IPaymentMethodTokenizationTypeInvoker));

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

			public static IPaymentMethodTokenizationType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPaymentMethodTokenizationType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.PaymentMethodTokenizationType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPaymentMethodTokenizationTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.IPaymentMethodTokenizationType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.wallet']/interface[@name='WalletConstants.TotalPriceStatus']"
		[Register ("com/google/android/gms/wallet/WalletConstants$TotalPriceStatus", "", "Com.Google.Android.Gms.Wallet.WalletConstants/ITotalPriceStatusInvoker")]
		public partial interface ITotalPriceStatus : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/gms/wallet/WalletConstants$TotalPriceStatus", DoNotGenerateAcw=true)]
		internal class ITotalPriceStatusInvoker : global::Java.Lang.Object, ITotalPriceStatus {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/google/android/gms/wallet/WalletConstants$TotalPriceStatus", typeof (ITotalPriceStatusInvoker));

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

			public static ITotalPriceStatus GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITotalPriceStatus> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.wallet.WalletConstants.TotalPriceStatus"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITotalPriceStatusInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Wallet.WalletConstants.ITotalPriceStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/android/gms/wallet/WalletConstants", typeof (WalletConstants));
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

		internal WalletConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
