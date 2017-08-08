using Xamarin.UITest;
using NUnit.Framework;
using System.Configuration;

namespace VistaLife2.UITests
{
	[Category("LoginTests")]
	public class LoginTests : BaseTest
	{
		const string _username = "test";
		const string _password = "test";

		public LoginTests(Platform platform)
			: base(platform)
		{
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void SuccessfulLoginTest()
		{
			//Arrange
			var username = _username;
			var password = _password;
			var expectedFirstPageTitle = "Vista Africa Brand Header";

			//Act
			LoginPage.EnterUsername(username);
			LoginPage.EnterPassword(password);
			LoginPage.TapLoginButton();

			//Assert
			var actualFirstPageTitle = FirstPage.GetTitle();
			Assert.AreEqual(expectedFirstPageTitle, actualFirstPageTitle);
		}


	}
}
