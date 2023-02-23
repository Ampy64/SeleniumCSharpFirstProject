using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using SeleniumFirst.Pages;

namespace SeleniumFirst
{
	[TestFixture]
	public class Program : CriverHelper
	{

		static void Main(string[] args)
		{


		}

		[SetUp]
		public void Initialize()
		{
			driver = new ChromeDriver();

			 
		}

		[Test]
		public void ExecuteTest()
		{

			driver.Navigate().GoToUrl("https://www.boston.com");
					
			SeleniumSetMethods.Click(driver.FindElement(By.Id("js-panel-navigation-trigger")));
			IWebElement click = driver.FindElement(By.Id("menu-item-22359876"));
			Actions Action = new Actions(driver);
			Action.Click(click);
			Action.Perform();
			



			Console.WriteLine("finished");




		}
		[Test]
		public void NavigationTest()
		{
			driver.Navigate().GoToUrl("https://www.boston.com");
			driver.Manage().Window.Maximize();
			Actions Action = new Actions(driver);
			Homepage homepage = new Homepage();

			homepage.ClickWeather();
			//homepage.ClickIcon();
			Console.WriteLine("finished");

		}


		[TearDown]
		public void CleanUp()
		{
			driver.Close();

			Console.WriteLine("Closed Browser");

		}
	}
}
