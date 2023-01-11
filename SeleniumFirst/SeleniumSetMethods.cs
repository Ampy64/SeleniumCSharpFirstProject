using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace SeleniumFirst
{
	class SeleniumSetMethods : CriverHelper
	{
		//Enter Text
		public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

		public static void Click(IWebElement webElement) =>	webElement.Click();


		public static void SelectDropDown(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByValue(value);
		}

		public static void SelectText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			selectElement.SelectByText(text);
		}

	}
}
