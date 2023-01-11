using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirst.Pages
{
	class Homepage : CriverHelper
	{

		IWebElement lnkWeather => driver.FindElement(By.XPath("//div[@class='o-site-header__menu']//li[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22359876']"));

		public void ClickWeather() => lnkWeather.Click();

	}




	//"//*[@id='menu-bdc-main']" +
	//		"//a[@class='menu-item menu-item-type-taxonomy menu-item-object-category menu-item-has-children menu-item-22359876'][contains(text(),'Weather')]"
}
