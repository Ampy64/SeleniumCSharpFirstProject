using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirst.Pages
{
	public class Homepage : CriverHelper
	{
		
		public IWebElement lnkWeather => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22359876']"));
		IWebElement lnkNews => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22274386']"));
		IWebElement lnkSports => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22274480']"));
		IWebElement lnkCommunity => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-24270121']"));
		IWebElement lnkCulture => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22274485']"));
		IWebElement lnkFood => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22274495']"));
		IWebElement lnkTravel => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22360356']"));
		IWebElement lnkThingsToDo => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-custom menu-item-object-custom menu-item-has-children menu-item-23474810']"));
		IWebElement lnkRealEstate => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-25890194']"));
		IWebElement lnkPrivacyPolicy => driver.FindElement(By.XPath("//div[@class='menu-footer-container']//li[@class='menu-item menu-item-type-custom menu-item-object-custom menu-item-22362921']"));




		 
		public void ClickWeather() => lnkWeather.Click();
		public void ClickNews() => lnkNews.Click();
		public void ClickSports() => lnkSports.Click(); 
		public void ClickCommunity() => lnkCommunity.Click(); 
		public void ClickCulture() => lnkCulture.Click(); 
		public void ClickFood() => lnkFood.Click(); 
		public void ClickTravel() => lnkTravel.Click(); 
		public void ClickThingsToDo() => lnkThingsToDo.Click(); 
		public void ClickRealEstate() => lnkRealEstate.Click();
		public void ClickPrivacyPolicy() => lnkPrivacyPolicy.Click();


	}




	//"//*[@id='menu-bdc-main']" +
	//		"//a[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22359876'][contains(text(),'Weather')]"
}
 