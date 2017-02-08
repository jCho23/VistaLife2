using System;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace VistaLife2.UITests
{
	public class FirstPage : BasePage
	{
		public FirstPage(IApp app, Platform platform) : base(app, platform)
		{

			if (OnAndroid)
			{

			}
			else if (OniOS)
			{

			}

		}

		public string GetTitle(int timeoutInSeconds = 60)
		{
			var title = "First Page";
			AppResult[] titleQuery;

			app.WaitForElement(title, "First Page Did Not Appear", TimeSpan.FromSeconds(timeoutInSeconds));

			//For an assertion, we don't want to use a string because it is not unique
			//Thus, 'Vista Africa Brand Header' should not be used as an assertion because it is repeated from the Login Page and First Page
			if (OniOS)
				titleQuery = app.Query(x => x.Marked("Vista Africa Brand Header"));
			else
				titleQuery = app.Query(x => x.Marked("Vista Africa Brand Header"));

			return titleQuery?.FirstOrDefault()?.Text;
		}
	}
}