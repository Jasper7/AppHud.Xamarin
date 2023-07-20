using System;
using Foundation;
using ObjCRuntime;
using StoreKit;
using UIKit;

namespace ApphudSDK
{
    // @protocol ApphudDelegate
    //[Mac(10, 14, 4)]
    [Protocol(Name = "_TtP9ApphudSDK14ApphudDelegate_"), Model(AutoGeneratedName = true)]
    interface IApphudDelegate
    {
        // @optional -(void)apphudSubscriptionsUpdated:(id)subscriptions;
        [Export("apphudSubscriptionsUpdated:")]
        void ApphudSubscriptionsUpdated(NSObject subscriptions);

        // @optional -(void)apphudNonRenewingPurchasesUpdated:(id)purchases;
        [Export("apphudNonRenewingPurchasesUpdated:")]
        void ApphudNonRenewingPurchasesUpdated(NSObject purchases);

        // @optional -(void)apphudDidChangeUserID:(NSString * _Nonnull)userID;
        [Export("apphudDidChangeUserID:")]
        void ApphudDidChangeUserID(string userID);

        // @optional -(void)apphudDidFetchStoreKitProducts:(id)products :(id)error;
        [Export("apphudDidFetchStoreKitProducts::")]
        void ApphudDidFetchStoreKitProducts(NSObject products, NSObject error);

        // @optional -(void)apphudDidFetchStoreKitProducts:(id)products;
        [Export("apphudDidFetchStoreKitProducts:")]
        void ApphudDidFetchStoreKitProducts(NSObject products);

        // @optional -(void (^ _Nullable)(ApphudPurchaseResult * _Nonnull))apphudShouldStartAppStoreDirectPurchase:(SKProduct * _Nonnull)product __attribute__((warn_unused_result("")));
        [Export("apphudShouldStartAppStoreDirectPurchase:")]
        [return: NullAllowed]
        Action<ApphudPurchaseResult> ApphudShouldStartAppStoreDirectPurchase(SKProduct product);

        // @optional -(id)apphudProductIdentifiers __attribute__((warn_unused_result("")));
        [Export("apphudProductIdentifiers")]
        NSObject ApphudProductIdentifiers { get; }

        // @optional -(BOOL)apphudDidObservePurchaseWithResult:(ApphudPurchaseResult * _Nonnull)result __attribute__((warn_unused_result("")));
        [Export("apphudDidObservePurchaseWithResult:")]
        bool ApphudDidObservePurchaseWithResult(ApphudPurchaseResult result);

        // @optional -(void)handleDeferredTransactionWithTransaction:(SKPaymentTransaction * _Nonnull)transaction;
        [Export("handleDeferredTransactionWithTransaction:")]
        void HandleDeferredTransactionWithTransaction(SKPaymentTransaction transaction);

        // @optional -(void)userDidLoadWithRawPaywalls:(id)rawPaywalls;
        [Export("userDidLoadWithRawPaywalls:")]
        void UserDidLoadWithRawPaywalls(NSObject rawPaywalls);

        // @optional -(void)paywallsDidFullyLoadWithPaywalls:(id)paywalls;
        [Export("paywallsDidFullyLoadWithPaywalls:")]
        void PaywallsDidFullyLoadWithPaywalls(NSObject paywalls);
    }

    // @interface Apphud : NSObject
    //[Mac(10, 14, 4), iOS(11, 2)]
    [BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK6Apphud")]
	interface Apphud
	{
		// +(void)startWithApiKey:(NSString * _Nonnull)apiKey userID:(NSString * _Nullable)userID observerMode:(BOOL)observerMode;
		[Static]
		[Export("startWithApiKey:userID:observerMode:")]
		void StartWithApiKey(string apiKey, [NullAllowed] string userID, bool observerMode);

		// +(void)startManuallyWithApiKey:(NSString * _Nonnull)apiKey userID:(NSString * _Nullable)userID deviceID:(NSString * _Nullable)deviceID observerMode:(BOOL)observerMode;
		[Static]
		[Export("startManuallyWithApiKey:userID:deviceID:observerMode:")]
		void StartManuallyWithApiKey(string apiKey, [NullAllowed] string userID, [NullAllowed] string deviceID, bool observerMode);

		// +(void)updateUserID:(NSString * _Nonnull)userID;
		[Static]
		[Export("updateUserID:")]
		void UpdateUserID(string userID);

		// +(NSString * _Nonnull)userID __attribute__((warn_unused_result("")));
		[Static]
		[Export("userID")]
		string UserID { get; }

		// +(NSString * _Nonnull)deviceID __attribute__((warn_unused_result("")));
		[Static]
		[Export("deviceID")]
		string DeviceID { get; }

		// +(void)logout;
		[Static]
		[Export("logout")]
		void Logout();


		// +(void)setDelegate:(id<ApphudDelegate> _Nonnull)delegate;
		//TODO Not found in compile time
		//[Static]
		//[Export("setDelegate:")]
		//void SetDelegate(IApphudDelegate apphudDelegate);

		// +(void)setUIDelegate:(id<ApphudUIDelegate> _Nonnull)delegate;
		//TODO Not found in compile time
		//[Static]
		//[Export("setUIDelegate:")]
		//void SetUIDelegate(ApphudUIDelegate apphudDelegate);

		// +(id)paywalls __attribute__((warn_unused_result("")));
		[Static]
		[Export("paywalls")]
		NSObject Paywalls { get; }

		// +(void)paywallsDidLoadCallback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("paywallsDidLoadCallback:")]
		void PaywallsDidLoadCallback(Action<ApphudPaywall[]> callback);

		// +(void)getPaywallsWithCallback:(void (^ _Nonnull)(int))callback __attribute__((deprecated("Use `func paywallsDidLoadCallback` method instead.")));
		[Static]
		[Export("getPaywallsWithCallback:")]
		void GetPaywallsWithCallback(Action<ApphudPaywall[]> callback);

		// +(void)willPurchaseProductFromPaywall:(NSString * _Nonnull)identifier;
		[Static]
		[Export("willPurchaseProductFromPaywall:")]
		void WillPurchaseProductFromPaywall(string identifier);

		// +(id)didFetchProductsNotification __attribute__((warn_unused_result("")));
		[Static]
		[Export("didFetchProductsNotification")]
		NSObject DidFetchProductsNotification { get; }

		// +(void)productsDidFetchCallback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("productsDidFetchCallback:")]
		void ProductsDidFetchCallback(Action<int> callback);

		// +(void)refreshStoreKitProducts:(void (^ _Nullable)(int))callback;
		[Static]
		[Export("refreshStoreKitProducts:")]
		void RefreshStoreKitProducts([NullAllowed] Action<int> callback);

		// +(id)storeKitProducts __attribute__((warn_unused_result("")));
		[Static]
		[Export("storeKitProducts")]
		NSObject StoreKitProducts { get; }

		// +(SKProduct * _Nullable)productWithProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
		[Static]
		[Export("productWithProductIdentifier:")]
		[return: NullAllowed]
		SKProduct ProductWithProductIdentifier(string productIdentifier);

		// +(void)purchaseApphudProduct:(ApphudProduct * _Nonnull)product callback:(void (^ _Nullable)(ApphudPurchaseResult * _Nonnull))callback;
		[Static]
		[Export("purchaseApphudProduct:callback:")]
		void PurchaseApphudProduct(ApphudProduct product, [NullAllowed] Action<ApphudPurchaseResult> callback);

		// +(void)purchaseById:(NSString * _Nonnull)productId callback:(void (^ _Nullable)(ApphudPurchaseResult * _Nonnull))callback;
		[Static]
		[Export("purchaseById:callback:")]
		void PurchaseById(string productId, [NullAllowed] Action<ApphudPurchaseResult> callback);

		// +(void)purchaseWithoutValidationById:(NSString * _Nonnull)productId callback:(void (^ _Nullable)(ApphudPurchaseResult * _Nonnull))callback;
		[Static]
		[Export("purchaseWithoutValidationById:callback:")]
		void PurchaseWithoutValidationById(string productId, [NullAllowed] Action<ApphudPurchaseResult> callback);

		// +(void)purchasePromo:(SKProduct * _Nonnull)product discountID:(NSString * _Nonnull)discountID :(void (^ _Nullable)(ApphudPurchaseResult * _Nonnull))callback __attribute__((availability(ios, introduced=12.2)));
		//[iOS(12, 2)]
		[Static]
		[Export("purchasePromo:discountID::")]
		void PurchasePromo(SKProduct product, string discountID, [NullAllowed] Action<ApphudPurchaseResult> callback);

		// +(void)presentOfferCodeRedemptionSheet __attribute__((availability(ios, introduced=14.0)));
		//[iOS(14, 0)]
		[Static]
		[Export("presentOfferCodeRedemptionSheet")]
		void PresentOfferCodeRedemptionSheet();

		// +(void)grantPromotionalWithDaysCount:(NSInteger)daysCount productId:(NSString * _Nullable)productId permissionGroup:(ApphudGroup * _Nullable)permissionGroup callback:(void (^ _Nullable)(BOOL))callback;
		[Static]
		[Export("grantPromotionalWithDaysCount:productId:permissionGroup:callback:")]
		void GrantPromotionalWithDaysCount(nint daysCount, [NullAllowed] string productId, [NullAllowed] ApphudGroup permissionGroup, [NullAllowed] Action<bool> callback);

		// +(void)paywallShown:(ApphudPaywall * _Nonnull)paywall;
		[Static]
		[Export("paywallShown:")]
		void PaywallShown(ApphudPaywall paywall);

		// +(void)paywallClosed:(ApphudPaywall * _Nonnull)paywall;
		[Static]
		[Export("paywallClosed:")]
		void PaywallClosed(ApphudPaywall paywall);

		// +(BOOL)hasPremiumAccess __attribute__((warn_unused_result("")));
		[Static]
		[Export("hasPremiumAccess")]
		bool HasPremiumAccess { get; }

		// +(BOOL)hasActiveSubscription __attribute__((warn_unused_result("")));
		[Static]
		[Export("hasActiveSubscription")]
		bool HasActiveSubscription { get; }

		// +(id)permissionGroups __attribute__((warn_unused_result("")));
		[Static]
		[Export("permissionGroups")]
		NSObject PermissionGroups { get; }

		// +(ApphudSubscription * _Nullable)subscription __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export("subscription")]
		ApphudSubscription Subscription { get; }

		// +(id)subscriptions __attribute__((warn_unused_result("")));
		[Static]
		[Export("subscriptions")]
		NSObject Subscriptions { get; }

		// +(id)nonRenewingPurchases __attribute__((warn_unused_result("")));
		[Static]
		[Export("nonRenewingPurchases")]
		NSObject NonRenewingPurchases { get; }

		// +(BOOL)isNonRenewingPurchaseActiveWithProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
		[Static]
		[Export("isNonRenewingPurchaseActiveWithProductIdentifier:")]
		bool IsNonRenewingPurchaseActiveWithProductIdentifier(string productIdentifier);

		// +(void)validateReceiptWithCallback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("validateReceiptWithCallback:")]
		void ValidateReceiptWithCallback(Action<ApphudSubscription[], ApphudNonRenewingPurchase[], NSObject> callback);

		// +(void)restorePurchasesWithCallback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("restorePurchasesWithCallback:")]
		void RestorePurchasesWithCallback(Action<ApphudSubscription[], ApphudNonRenewingPurchase[], NSObject> callback);

		// +(void)migratePurchasesIfNeededWithCallback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("migratePurchasesIfNeededWithCallback:")]
		void MigratePurchasesIfNeededWithCallback(Action<ApphudSubscription[], ApphudNonRenewingPurchase[], NSObject> callback);

		// +(NSString * _Nullable)appStoreReceipt __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export("appStoreReceipt")]
		string AppStoreReceipt { get; }

		// +(void)fetchRawReceiptInfo:(void (^ _Nonnull)(ApphudReceipt * _Nullable))completion;
		[Static]
		[Export("fetchRawReceiptInfo:")]
		void FetchRawReceiptInfo(Action<ApphudReceipt> completion);

		// +(void)setUserPropertyWithKey:(ApphudUserPropertyKey * _Nonnull)key value:(id _Nullable)value setOnce:(BOOL)setOnce;
		[Static]
		[Export("setUserPropertyWithKey:value:setOnce:")]
		void SetUserPropertyWithKey(ApphudUserPropertyKey key, [NullAllowed] NSObject value, bool setOnce);

		// +(void)incrementUserPropertyWithKey:(ApphudUserPropertyKey * _Nonnull)key by:(id _Nonnull)by;
		[Static]
		[Export("incrementUserPropertyWithKey:by:")]
		void IncrementUserPropertyWithKey(ApphudUserPropertyKey key, NSObject by);

		// +(void)showPendingScreen;
		[Static]
		[Export("showPendingScreen")]
		void ShowPendingScreen();

		// +(UIViewController * _Nullable)pendingScreenController __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export("pendingScreenController")]
		UIViewController PendingScreenController { get; }

		// +(ApphudRule * _Nullable)pendingRule __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export("pendingRule")]
		ApphudRule PendingRule { get; }

		// +(void)submitPushNotificationsTokenWithToken:(NSData * _Nonnull)token callback:(void (^ _Nullable)(BOOL))callback;
		[Static]
		[Export("submitPushNotificationsTokenWithToken:callback:")]
		void SubmitPushNotificationsTokenWithToken(NSData token, [NullAllowed] Action<bool> callback);

		// +(BOOL)handlePushNotificationWithApsInfo:(id)apsInfo;
		[Static]
		[Export("handlePushNotificationWithApsInfo:")]
		bool HandlePushNotificationWithApsInfo(NSObject apsInfo);

		// +(void)setAdvertisingIdentifier:(NSString * _Nonnull)idfa;
		[Static]
		[Export("setAdvertisingIdentifier:")]
		void SetAdvertisingIdentifier(string idfa);

		// +(void)addAttributionWithData:(id)data from:(enum ApphudAttributionProvider)provider identifer:(NSString * _Nullable)identifer callback:(void (^ _Nullable)(BOOL))callback;
		[Static]
		[Export("addAttributionWithData:from:identifer:callback:")]
		void AddAttributionWithData(NSObject data, ApphudAttributionProvider provider, [NullAllowed] string identifer, [NullAllowed] Action<bool> callback);

		// +(void)checkEligibilityForIntroductoryOfferWithProduct:(SKProduct * _Nonnull)product callback:(void (^ _Nonnull)(BOOL))callback;
		[Static]
		[Export("checkEligibilityForIntroductoryOfferWithProduct:callback:")]
		void CheckEligibilityForIntroductoryOfferWithProduct(SKProduct product, Action<bool> callback);

		// +(void)checkEligibilityForPromotionalOfferWithProduct:(SKProduct * _Nonnull)product callback:(void (^ _Nonnull)(BOOL))callback __attribute__((availability(ios, introduced=12.2)));
		//[iOS(12, 2)]
		[Static]
		[Export("checkEligibilityForPromotionalOfferWithProduct:callback:")]
		void CheckEligibilityForPromotionalOfferWithProduct(SKProduct product, Action<bool> callback);

		// +(void)checkEligibilitiesForPromotionalOffersWithProducts:(id)products callback:(void (^ _Nonnull)(int))callback __attribute__((availability(ios, introduced=12.2)));
		//[iOS(12, 2)]
		[Static]
		[Export("checkEligibilitiesForPromotionalOffersWithProducts:callback:")]
		void CheckEligibilitiesForPromotionalOffersWithProducts(NSObject products, Action<int> callback);

		// +(void)checkEligibilitiesForIntroductoryOffersWithProducts:(id)products callback:(void (^ _Nonnull)(int))callback;
		[Static]
		[Export("checkEligibilitiesForIntroductoryOffersWithProducts:callback:")]
		void CheckEligibilitiesForIntroductoryOffersWithProducts(NSObject products, Action<int> callback);

		// +(void)enableDebugLogs;
		[Static]
		[Export("enableDebugLogs")]
		void EnableDebugLogs();

		// +(BOOL)isSandbox __attribute__((warn_unused_result("")));
		[Static]
		[Export("isSandbox")]
		bool IsSandbox { get; }
	}

	// @interface ApphudError
	interface ApphudError
	{
	}

	// @interface ApphudGroup : NSObject
	//[Mac(10, 14, 4)]
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK11ApphudGroup")]
	[DisableDefaultCtor]
	interface ApphudGroup
	{
	}

	// @interface ApphudKeychain : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK14ApphudKeychain")]
	interface ApphudKeychain
	{
	}

	// @interface ApphudNonRenewingPurchase : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK25ApphudNonRenewingPurchase")]
	[DisableDefaultCtor]
	interface ApphudNonRenewingPurchase
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull productId;
		[Export("productId")]
		string ProductId { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchasedAt;
		[Export("purchasedAt", ArgumentSemantic.Copy)]
		NSDate PurchasedAt { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable canceledAt;
		[NullAllowed, Export("canceledAt", ArgumentSemantic.Copy)]
		NSDate CanceledAt { get; }

		// @property (readonly, nonatomic) BOOL isSandbox;
		[Export("isSandbox")]
		bool IsSandbox { get; }

		// @property (readonly, nonatomic) BOOL isLocal;
		[Export("isLocal")]
		bool IsLocal { get; }

		// -(BOOL)isActive __attribute__((warn_unused_result("")));
		[Export("isActive")]
		bool IsActive { get; }
	}

	// @interface ApphudPaywall : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK13ApphudPaywall")]
	[DisableDefaultCtor]
	interface ApphudPaywall
	{
		//@objc public internal (set) var products: [ApphudProduct]
		[Export("products")]
		ApphudProduct[] Products { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) BOOL isDefault;
		[Export("isDefault")]
		bool IsDefault { get; }

		// @property (copy, nonatomic) NSString * _Nullable experimentName;
		[NullAllowed, Export("experimentName")]
		string ExperimentName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable variationName;
		[NullAllowed, Export("variationName")]
		string VariationName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable fromPaywall;
		[NullAllowed, Export("fromPaywall")]
		string FromPaywall { get; set; }
	}

	// @interface ApphudProduct : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK13ApphudProduct")]
	[DisableDefaultCtor]
	interface ApphudProduct
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull productId;
		[Export("productId")]
		string ProductId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull store;
		[Export("store")]
		string Store { get; }

		// @property (readonly, nonatomic, strong) SKProduct * _Nullable skProduct;
		[NullAllowed, Export("skProduct", ArgumentSemantic.Strong)]
		SKProduct SkProduct { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paywallIdentifier;
		[NullAllowed, Export("paywallIdentifier")]
		string PaywallIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paywallId;
		[NullAllowed, Export("paywallId")]
		string PaywallId { get; }
	}

	// @interface ApphudPurchaseResult : NSObject
	//[Mac(10, 14, 4)]
	[BaseType(typeof(NSObject), Name = "_TtC9ApphudSDK20ApphudPurchaseResult")]
	[DisableDefaultCtor]
	interface ApphudPurchaseResult
	{
		// @property (readonly, nonatomic, strong) ApphudSubscription * _Nullable subscription;
		[NullAllowed, Export ("subscription", ArgumentSemantic.Strong)]
		ApphudSubscription Subscription { get; }

		// @property (readonly, nonatomic, strong) ApphudNonRenewingPurchase * _Nullable nonRenewingPurchase;
		[NullAllowed, Export ("nonRenewingPurchase", ArgumentSemantic.Strong)]
		ApphudNonRenewingPurchase NonRenewingPurchase { get; }

		// @property (readonly, nonatomic, strong) SKPaymentTransaction * _Nullable transaction;
		[NullAllowed, Export ("transaction", ArgumentSemantic.Strong)]
		SKPaymentTransaction Transaction { get; }

		// @property (readonly, nonatomic) int * _Nullable error;
		//TODO Fix error
		//[NullAllowed, Export ("error")]
		//unsafe int? Error { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface ApphudReceipt : NSObject
	//[Mac (10,14,4)]
	[BaseType (typeof(NSObject), Name = "_TtC9ApphudSDK13ApphudReceipt")]
	interface ApphudReceipt
	{
		// @property (copy, nonatomic) NSString * _Nullable originalApplicationVersion;
		[NullAllowed, Export ("originalApplicationVersion")]
		string OriginalApplicationVersion { get; set; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
		[NullAllowed, Export ("originalPurchaseDate", ArgumentSemantic.Copy)]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable receiptCreationDate;
		[NullAllowed, Export ("receiptCreationDate", ArgumentSemantic.Copy)]
		NSDate ReceiptCreationDate { get; }

		// @property (copy, nonatomic) NSString * _Nonnull applicationVersion;
		[Export ("applicationVersion")]
		string ApplicationVersion { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull bundleId;
		[Export ("bundleId")]
		string BundleId { get; set; }
	}

	// @interface ApphudRule : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC9ApphudSDK10ApphudRule")]
	[DisableDefaultCtor]
	interface ApphudRule
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull rule_name;
		[Export ("rule_name")]
		string Rule_name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull screen_name;
		[Export ("screen_name")]
		string Screen_name { get; }
	}

	// @interface ApphudSubscription : NSObject
	//[Mac (10,14,4)]
	[BaseType (typeof(NSObject), Name = "_TtC9ApphudSDK18ApphudSubscription")]
	[DisableDefaultCtor]
	interface ApphudSubscription
	{
		// -(BOOL)isActive __attribute__((warn_unused_result("")));
		[Export ("isActive")]
		bool IsActive { get; }

		// @property (nonatomic) enum ApphudSubscriptionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		ApphudSubscriptionStatus Status { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull productId;
		[Export ("productId")]
		string ProductId { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresDate;
		[Export ("expiresDate", ArgumentSemantic.Copy)]
		NSDate ExpiresDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull startedAt;
		[Export ("startedAt", ArgumentSemantic.Copy)]
		NSDate StartedAt { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable canceledAt;
		[NullAllowed, Export ("canceledAt", ArgumentSemantic.Copy)]
		NSDate CanceledAt { get; }

		// @property (readonly, nonatomic) BOOL isSandbox;
		[Export ("isSandbox")]
		bool IsSandbox { get; }

		// @property (readonly, nonatomic) BOOL isLocal;
		[Export ("isLocal")]
		bool IsLocal { get; }

		// @property (readonly, nonatomic) BOOL isInRetryBilling;
		[Export ("isInRetryBilling")]
		bool IsInRetryBilling { get; }

		// @property (readonly, nonatomic) BOOL isAutorenewEnabled;
		[Export ("isAutorenewEnabled")]
		bool IsAutorenewEnabled { get; }

		// @property (readonly, nonatomic) BOOL isIntroductoryActivated;
		[Export ("isIntroductoryActivated")]
		bool IsIntroductoryActivated { get; }
	}

	// @protocol ApphudUIDelegate
	[Protocol (Name = "_TtP9ApphudSDK16ApphudUIDelegate_"), Model (AutoGeneratedName = true)]
	interface ApphudUIDelegate
	{
		// @optional -(BOOL)apphudShouldPerformRuleWithRule:(ApphudRule * _Nonnull)rule __attribute__((warn_unused_result("")));
		[Export ("apphudShouldPerformRuleWithRule:")]
		bool ApphudShouldPerformRuleWithRule (ApphudRule rule);

		// @optional -(BOOL)apphudShouldShowScreenWithScreenName:(NSString * _Nonnull)screenName __attribute__((warn_unused_result("")));
		[Export ("apphudShouldShowScreenWithScreenName:")]
		bool ApphudShouldShowScreenWithScreenName (string screenName);

		// @optional -(UIViewController * _Nonnull)apphudParentViewControllerWithController:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("apphudParentViewControllerWithController:")]
		UIViewController ApphudParentViewControllerWithController (UIViewController controller);

		// @optional -(id)apphudScreenPresentationStyleWithController:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("apphudScreenPresentationStyleWithController:")]
		NSObject ApphudScreenPresentationStyleWithController (UIViewController controller);

		// @optional -(void)apphudWillPurchaseWithProduct:(SKProduct * _Nonnull)product offerID:(NSString * _Nullable)offerID screenName:(NSString * _Nonnull)screenName;
		[Export ("apphudWillPurchaseWithProduct:offerID:screenName:")]
		void ApphudWillPurchaseWithProduct (SKProduct product, [NullAllowed] string offerID, string screenName);

		// @optional -(void)apphudDidPurchaseWithProduct:(SKProduct * _Nonnull)product offerID:(NSString * _Nullable)offerID screenName:(NSString * _Nonnull)screenName;
		[Export ("apphudDidPurchaseWithProduct:offerID:screenName:")]
		void ApphudDidPurchaseWithProduct (SKProduct product, [NullAllowed] string offerID, string screenName);

		// @optional -(void)apphudDidFailPurchaseWithProduct:(SKProduct * _Nonnull)product offerID:(NSString * _Nullable)offerID errorCode:(enum SKErrorCode)errorCode screenName:(NSString * _Nonnull)screenName;
		[Export ("apphudDidFailPurchaseWithProduct:offerID:errorCode:screenName:")]
		void ApphudDidFailPurchaseWithProduct (SKProduct product, [NullAllowed] string offerID, long errorCode, string screenName);

		// @optional -(void)apphudScreenDidAppearWithScreenName:(NSString * _Nonnull)screenName;
		[Export ("apphudScreenDidAppearWithScreenName:")]
		void ApphudScreenDidAppearWithScreenName (string screenName);

		// @optional -(void)apphudScreenWillDismissWithScreenName:(NSString * _Nonnull)screenName error:(id)error;
		[Export ("apphudScreenWillDismissWithScreenName:error:")]
		void ApphudScreenWillDismissWithScreenName (string screenName, NSObject error);

		// @optional -(void)apphudDidDismissScreenWithController:(UIViewController * _Nonnull)controller;
		[Export ("apphudDidDismissScreenWithController:")]
		void ApphudDidDismissScreenWithController (UIViewController controller);

		// @optional -(enum ApphudScreenDismissAction)apphudScreenDismissActionWithScreenName:(NSString * _Nonnull)screenName controller:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("apphudScreenDismissActionWithScreenName:controller:")]
		ApphudScreenDismissAction ApphudScreenDismissActionWithScreenName (string screenName, UIViewController controller);

		// @optional -(void)apphudDidSelectSurveyAnswerWithQuestion:(NSString * _Nonnull)question answer:(NSString * _Nonnull)answer screenName:(NSString * _Nonnull)screenName;
		[Export ("apphudDidSelectSurveyAnswerWithQuestion:answer:screenName:")]
		void ApphudDidSelectSurveyAnswerWithQuestion (string question, string answer, string screenName);
	}

	// @interface ApphudUserPropertyKey : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC9ApphudSDK21ApphudUserPropertyKey")]
	[DisableDefaultCtor]
	interface ApphudUserPropertyKey
	{
		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull email;
		[Static]
		[Export ("email", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Email { get; }

		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull age;
		[Static]
		[Export ("age", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Age { get; }

		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull phone;
		[Static]
		[Export ("phone", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Phone { get; }

		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull name;
		[Static]
		[Export ("name", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Name { get; }

		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull gender;
		[Static]
		[Export ("gender", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Gender { get; }

		// @property (readonly, nonatomic, strong, class) ApphudUserPropertyKey * _Nonnull cohort;
		[Static]
		[Export ("cohort", ArgumentSemantic.Strong)]
		ApphudUserPropertyKey Cohort { get; }

		// -(instancetype _Nonnull)init:(NSString * _Nonnull)key __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (string key);
	}

	// @interface ApphudUtils : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC9ApphudSDK11ApphudUtils")]
	interface ApphudUtils
	{
		// +(void)enableDebugLogs;
		[Static]
		[Export ("enableDebugLogs")]
		void EnableDebugLogs ();

		// +(void)enableAllLogs;
		[Static]
		[Export ("enableAllLogs")]
		void EnableAllLogs ();
	}
}
