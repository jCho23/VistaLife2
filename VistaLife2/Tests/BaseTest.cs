using NUnit.Framework;
using Xamarin.UITest;

namespace VistaLife2.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]

	public abstract class BaseTest
	{
		protected IApp app;
		protected Platform platform;

		protected LoginPage LoginPage;
		protected FirstPage FirstPage;

		protected BaseTest(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		virtual public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Initialized");

			LoginPage = new LoginPage(app, platform);
			FirstPage = new FirstPage(app, platform);
		}
	}
}

