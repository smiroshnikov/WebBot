using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void Button1_Click(object sender, EventArgs e)
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
            //SearchBox.Click();
            SearchBox.SendKeys("Dildo Extra Large");
            SearchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Browser.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Browser = new ChromeDriver();
//            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.yandex.ru");


            IWebElement YandexPictureLink = Browser.FindElement(By.LinkText("//yandex.ru/images/"));
            YandexPictureLink.Click();

//            var yandexSearchBox = Browser.FindElement(By.ClassName("textinput__control"));
//            yandexSearchBox.SendKeys("Луна" + OpenQA.Selenium.Keys.Enter);
        }
    }
}