using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace VistaLife2.UITests
{
	public class LoginPage : BasePage
	{
		readonly Query _loginButton;
		readonly Query _passwordEntry;
		readonly Query _usernameEntry;

		public LoginPage(IApp app, Platform platform)
			: base(app, platform)
		{
			//Always initialize the UITest queries using "x.Marked" and referencing the UI ID
			//In Xamarin.Android, set the UI ID by setting the control's "ContentDescription"
			//In Xamarin.iOS, set the UI ID by setting the control's "AccessibilityIdentifiers"
			_loginButton = x => x.Marked("loginButton");
			_passwordEntry = x => x.Marked("passwordEntry");
			_usernameEntry = x => x.Marked("usernameEntry");
		}

		public void EnterUsername(string username)
		{
			app.Tap(_usernameEntry);
			app.Screenshot("Lets start by Tapping on the 'username' Text Entry Field");
			app.ClearText();
			app.EnterText(username);
			app.Screenshot("Then we entered our username");
			app.DismissKeyboard();
			app.Screenshot($"Entered Username: {username}");
		}

		public void EnterPassword(string password)
		{
			app.Tap(_passwordEntry);
			app.Screenshot("Lets start by Tapping on the 'password' Text Entry Field");
			app.ClearText();
			app.EnterText(password);
			app.Screenshot("Then we entered our password");
			app.DismissKeyboard();
			app.Screenshot($"Entered Password: {password}");
		}

		public void TapLoginButton()
		{
			app.Tap(_loginButton);
			app.Screenshot("We Tapped the 'Login' Button");
		}
	}
}