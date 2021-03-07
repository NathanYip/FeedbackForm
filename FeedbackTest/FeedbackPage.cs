using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FeedbackTest
{
    public class FeedbackPage
    {
        private readonly IWebDriver _driver;
        private IAlert _alert;
        private const string PageURI = @"https://localhost:44320/Feedback.aspx";

        private string _alertText = "";

        [FindsBy(How = How.Id, Using = "txtName")]
        private IWebElement _name;

        [FindsBy(How = How.Id, Using = "txtAddress")]
        private IWebElement _address;

        [FindsBy(How = How.Id, Using = "txtEmail")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "txtComment")]
        private IWebElement _comment;

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        private IWebElement _btnSubmit;


        public FeedbackPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public static FeedbackPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageURI);

            return new FeedbackPage(driver);
        }

        public string Name
        {
            set
            {
                _name.SendKeys(value);
            }
        }        
        public string Address
        {
            set
            {
               _address.SendKeys(value);
            }
        }        
        public string Email
        {
            set
            {
                _email.SendKeys(value);
            }
        }        
        public string Comment
        {
            set
            {
                _comment.SendKeys(value);
            }
        }

        public void AcceptAlertBox()
        {
            _alert = _driver.SwitchTo().Alert();
            _alertText = _alert.Text;
            



        }

        public void ClickSubmit()
        {
            _btnSubmit.Click();
        }

        //public SubmissionSuccessful ClickGoBack()
        //{
        //    _driver.FindElement(By.Id("Button1")).Click();
        //}


    }


}