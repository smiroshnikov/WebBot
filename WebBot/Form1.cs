﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebBot
{
    public partial class Form1 : Form
    {
        private IWebDriver Browser;


        public Form1()
        {
            InitializeComponent();
        }

        private void AliExpressTestButton(object sender, EventArgs e)
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.aliexpress.com");
            IWebElement closeCoupon = Browser.FindElement(By.ClassName("close-layer"));
            // just in case that coupon commercial is not displayed 
            if (closeCoupon.Displayed == true)
            {
                closeCoupon.Click();
            }

            IWebElement SearchBox = Browser.FindElement(By.Id("search-key"));
            SearchBox.SendKeys("Dildo Extra Large");
            SearchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        private void CloseBrowserButton(object sender, EventArgs e)
        {
            Browser.Close();
        }

        private void YandexPictureSearchButton(object sender, EventArgs e)
        {
            Browser = new ChromeDriver();
//            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.yandex.ru");

//            IList<IWebElement> searchByPictureElements =
//                Browser.FindElements(By.XPath("//*[contains(text(),'Картинки')]"));
//
//            IWebElement YandexPictureLink = searchByPictureElements[0];
//            YandexPictureLink.Click();

            IWebElement element;
            element = Browser.FindElement(By.LinkText("Картинки"));
            element.Click();


            var yandexSearchBox = Browser.FindElement(By.ClassName("textinput__control"));
            yandexSearchBox.SendKeys("Луна" + OpenQA.Selenium.Keys.Enter);
        }
    }
}