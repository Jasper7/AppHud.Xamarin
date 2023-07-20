using ObjCRuntime;

namespace AppHud.Xamarin.iOS
{
	[Native]
	public enum ApphudAttributionProvider : long
	{
		AppsFlyer = 0,
		Adjust = 1,
		AppleSearchAds = 2,
		AppleAdsAttribution = 3,
		Firebase = 4,
		Facebook = 5
	}

	[Native]
	public enum ApphudScreenDismissAction : long
	{
		ThankAndClose = 0,
		CloseOnly = 1,
		None = 2
	}

	[Native]
	public enum ApphudSubscriptionStatus : long
	{
		Trial = 0,
		Intro = 1,
		Promo = 2,
		Regular = 3,
		Grace = 4,
		Refunded = 5,
		Expired = 6
	}
}
