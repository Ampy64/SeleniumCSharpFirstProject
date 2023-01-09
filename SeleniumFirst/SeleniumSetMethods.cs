using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
	class SeleniumSetMethods
	{
		//Enter Text
		public static void EnterText(IWebDriver driver, string Element, string value, string elementtype)
		{
			if(elementtype == "Id")
			driver.FindElement(By.Id(Element)).SendKeys(value);
			if (elementtype == "Name")
				driver.FindElement(By.Name(Element)).SendKeys(value);
		}

		//click into a button, checkbox, option etc

		public static void Click(IWebDriver driver, string Element, string elementtype)
		{
			if (elementtype == "Id")
				driver.FindElement(By.Id(Element)).Click();
			if (elementtype == "Name")
				driver.FindElement(By.Name(Element)).Click();

		}

		//select drop down control

		public static void SelectDropDown(IWebDriver driver, string Element, string value, string elementtype)
		{
			if (elementtype == "Id")
				new SelectElement(driver.FindElement(By.Id(Element))).SelectByText(value);
			if (elementtype == "Name")
				new SelectElement(driver.FindElement(By.Name(Element))).SelectByText(value);
		}

	}
}
