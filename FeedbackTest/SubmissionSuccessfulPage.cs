﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FeedbackTest
{
    public class SubmissionSuccessfulPage
    {
        private readonly IWebDriver _driver;

        public SubmissionSuccessfulPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


    }

}
