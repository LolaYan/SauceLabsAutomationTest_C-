using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SauceLabsAutomation.Drivers;
using OpenQA.Selenium.Remote;

namespace SauceLabsAutomation._Web.Tests
{
    [TestClass]
    public class TestBase
    {
        // Sauce Labs Credential Parameters.
        public static string seleniumURI;
        public static string buildTag;
        public static string username;
        public static string accesskey;
        public static string SUrl;

        public static IWebDriver webDriver;
        public static string sessionId;

        public static void setupSauceParameters()
        {
            username = SauceLabHelper.getSauceUsername();
            accesskey = SauceLabHelper.getSauceUserkey();
            buildTag = SauceLabHelper.getBuildTag();
            SUrl = SauceLabHelper.buildSauceUri();

        }
        
        protected IWebDriver createDriver(String browser, String version, String os, String methodName) 
        {
            setupSauceParameters();
            IWebDriver driver = DriverHelper.createWebDriver(browser, version, os, SUrl, username, accesskey, buildTag, methodName);

		    long timeWaitInSeconds = 30;
		    // global time wait setting
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeWaitInSeconds));

		    webDriver = driver;
            sessionId = ((RemoteWebDriver)webDriver).SessionId.ToString();
            return webDriver;

	    }

        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            webDriver.Close();
        }

    }
}
