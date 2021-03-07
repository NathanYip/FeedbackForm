using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace FeedbackTest
{
    [Binding]
    public class FeedbackFormSteps
    {
        private IWebDriver _driver;
        private IAlert _alert;

        private string _alertText = "";
        private FeedbackPage _feedbackPage;

        [Given(@"I am on the feedback form page")]
        public void GivenIAmOnTheFeedbackFormPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _feedbackPage = FeedbackPage.NavigateTo(_driver);


        }


        [Given(@"I have entered my name (.*)")]
        public void GivenIHaveEnteredMyName(string name)
        {
            _feedbackPage.Name = name;
        }
        
        [Given(@"I have entered my address (.*)")]
        public void GivenIHaveEnteredMyAddress(string address)
        {
            _feedbackPage.Address = address;
        }
        
        [Given(@"I have entered my email (.*)")]
        public void GivenIHaveEnteredMyEmail(string email)
        {
            _feedbackPage.Email = email;
        }
        
        [Given(@"I have entered my comments (.*)")]
        public void GivenIHaveEnteredMyComments(string comments)
        {
            _feedbackPage.Comment = comments;
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            _feedbackPage.ClickSubmit();
        }
        
        [Then(@"the form should say i have submitted my feedback")]
        public void ThenTheFormShouldSayIHaveSubmittedMyFeedback()
        {
            string title = _driver.Title;
            NUnit.Framework.Assert.AreEqual("Submission Sent!", title);

        }


        [Then(@"the form should say i have not entered a field")]
        public void ThenTheFormShouldSayIHaveNotEnteredTheField()
        {
            _alert = _driver.SwitchTo().Alert();
            _alertText = _alert.Text;
            NUnit.Framework.Assert.AreEqual("Some fields are empty", _alertText);
            _alert.Accept();

        }



        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }


}
