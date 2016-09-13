using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using SauceLabsAutomation.Drivers;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;

namespace SauceLabsAutomation._Android.Tests
{
    /// <summary>
    /// Summary description for AndroidTestBase
    /// </summary>
    [TestClass]
    public class AndroidTestBase
    {
        // Sauce Labs Credential Parameters.
        public static string seleniumURI;
        public static string buildTag;
        public static string username;
        public static string accesskey;
        public static string SUrl;
        public static string appName;
        public static string appPackage;
        public static string appActivity;

        public static AppiumDriver<AndroidElement> androidDriver;
        public static string sessionId;


        public AndroidTestBase()
        {
            // TODO: Add constructor logic here
            setupSauceParameters();
        }

        private TestContext testContextInstance;


        public static void setupSauceParameters()
        {
            username = SauceLabHelper.getSauceUsername();
            accesskey = SauceLabHelper.getSauceUserkey();
            buildTag = SauceLabHelper.getBuildTag();
            SUrl = SauceLabHelper.buildSauceUri();

            appName = SauceLabHelper.getApkName();
            appPackage = SauceLabHelper.getApkPackage();
            appActivity = SauceLabHelper.getApkActivity();
        }

        protected AppiumDriver<AndroidElement> createDriver(String appiumVersion,
            String deviceName, String deviceType, String deviceOrientation,
            String platformVersion, String platformName, String browserName, String app, String methodName)
        {
            setupSauceParameters();
            AndroidDriver<AndroidElement> driver = DriverHelper.createAndroidDriver(appiumVersion, deviceName, deviceType, deviceOrientation,
                platformVersion, platformName, browserName, app, appPackage,
                appActivity, SUrl, username, accesskey, buildTag, methodName);

            long timeWaitInSeconds = 30;
            // global time wait setting
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeWaitInSeconds));

            androidDriver = driver;
            sessionId = ((RemoteWebDriver)androidDriver).SessionId.ToString();
            return androidDriver;

        }

        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            androidDriver.Close();
        }
    }
}
