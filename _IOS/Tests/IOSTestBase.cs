using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using SauceLabsAutomation.Drivers;
using OpenQA.Selenium.Remote;

namespace SauceLabsAutomation._IOS.Tests
{
    /// <summary>
    /// Summary description for IOSTestBase
    /// </summary>
    [TestClass]
    public class IOSTestBase
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

        public static IOSDriver<IOSElement> IOSDriver;
        public static string sessionId;


        public IOSTestBase()
        {
            // TODO: Add constructor logic here
            setupSauceParameters();
        }
        
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

        protected IOSDriver<IOSElement> createDriver(String appiumVersion,
            String deviceName, String deviceType, String deviceOrientation,
            String platformVersion, String platformName, String browserName, String app, String methodName)
        {
            IOSDriver<IOSElement> driver = DriverHelper.createIOSDriver(appiumVersion,
                deviceName, deviceType, deviceOrientation, platformVersion,
                platformName, browserName, app, SUrl, username, accesskey, buildTag, methodName);

            long timeWaitInSeconds = 30;
            // global time wait setting
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeWaitInSeconds));

            IOSDriver = driver;
            sessionId = ((RemoteWebDriver)IOSDriver).SessionId.ToString();
            return IOSDriver;

        }

        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            IOSDriver.Close();
        }
    }
}
