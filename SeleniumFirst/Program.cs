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
					

			driver.FindElement(By.Id("js-panel-navigation-trigger")).Click();
			IWebElement click = driver.FindElement(By.Id("menu-item-22359876"));
			Actions Action = new Actions(driver);
			Action.Click(click);
			Action.Perform();



			Console.WriteLine("finished");

			//SeleniumSetMethods.EnterText(driver, "q", "Can't Defy The Lonely Girl", "Name");
			
			//wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='dense-manga-container']"))); 
			//driver.FindElement(By.XPath("/html/body/div/div[3]/div[2]/div/div[2]/div/div[2]/a/div/div[2]/div[1]")).Click();
			//driver.FindElement(By.XPath("//html[@title='Cant't Defy The Lonely Girl]")).Click();
			//Console.WriteLine("clicked on page");



		}


		[TearDown]
		public void CleanUp()
		{
			driver.Close();

			Console.WriteLine("Closed Browser");

		}
	}
}
