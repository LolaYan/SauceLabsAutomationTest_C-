using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabsAutomation.Drivers
{
    public class DriverHelper
    {
        public static IWebDriver webDriver;
        public static AndroidDriver<AndroidElement> androidDriver;
        //public static AppiumDriver<AndroidElement> androidDriver;
        public static IOSDriver<IOSElement> IOSDriver;
        //public static AppiumDriver<IOSElement> IOSDriver;

        public static IWebDriver createWebDriver(string browser, string version,
            string os, string slUrl, string slUName, string slUAccessKey, string buildTag,
            string methodName)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();

		    // set desired capabilities to launch appropriate browser on Sauce
		    capabilities.SetCapability(CapabilityType.BrowserName, browser);
		    capabilities.SetCapability(CapabilityType.Version, version);
		    capabilities.SetCapability(CapabilityType.Platform, os);
            capabilities.SetCapability("username", slUName); // supply sauce labs username
            capabilities.SetCapability("accessKey", slUAccessKey);  // supply sauce labs account key
            capabilities.SetCapability("name", methodName);// give the test a name

		    if (buildTag != null) {
			    capabilities.SetCapability("build", buildTag);
		    }

            webDriver = new RemoteWebDriver(new Uri(slUrl), capabilities, TimeSpan.FromSeconds(600));
            return webDriver;
        }

        /** Create Appium Driver for Android Testing **/
        public static AndroidDriver<AndroidElement> createAndroidDriver(string appiumVersion,
            string deviceName, string deviceType, string deviceOrientation,
            string platformVersion, string platformName, string browserName,
            string appName, string appPackage, string appActivity, string slUrl, string slUName, string slUAccessKey, 
            string buildTag, string methodName)
        {
            DesiredCapabilities capabilities = DesiredCapabilities.Android();

		    // set desired capabilities to launch appropriate browser on Sauce
		    if (appiumVersion != null) {
			    capabilities.SetCapability("appiumVersion", appiumVersion);
		    }

		    if (deviceName != null) {
			    capabilities.SetCapability("deviceName", deviceName);
		    }

		    if (deviceOrientation != null) {
			    capabilities.SetCapability("deviceOrientation", deviceOrientation);
		    }
		    if (deviceType != null) {
			    capabilities.SetCapability("deviceType", deviceType);
		    }
		    if (platformVersion != null) {
			    capabilities.SetCapability("platformVersion", platformVersion);
		    }
		    if (platformName != null) {
			    capabilities.SetCapability("platformName", platformName);
		    }
		    if (browserName != null) {
			    capabilities.SetCapability("browserName", browserName);
		    }
		    if (appName != null) {
			    capabilities.SetCapability("app", appName);
			    capabilities.SetCapability("appPackage", appPackage);
			    capabilities.SetCapability("appActivity", appActivity);
		    }

		    if (buildTag != null) {
                capabilities.SetCapability("build", buildTag);
		    }

            capabilities.SetCapability("username", slUName); // supply sauce labs username
            capabilities.SetCapability("accessKey", slUAccessKey);  // supply sauce labs account key
            capabilities.SetCapability("name", methodName);// give the test a name

            androidDriver = new AndroidDriver<AndroidElement>(new Uri(slUrl), capabilities, TimeSpan.FromSeconds(600));

            return androidDriver;
        }

        /** Create Appium Driver for IOS Testing **/
        public static IOSDriver<IOSElement> createIOSDriver(string appiumVersion,
            string deviceName, string deviceType, string deviceOrientation,
            string platformVersion, string platformName, string browserName,
            string app, string slUrl, string slUName, string slUAccessKey, 
            string buildTag, string methodName)
        {
            DesiredCapabilities capabilities = DesiredCapabilities.IPhone();

		    // set desired capabilities to launch appropriate browser on Sauce
		    if (appiumVersion != null) {
			    capabilities.SetCapability("appiumVersion", appiumVersion);
            }
            if (deviceName != null) {
			capabilities.SetCapability("deviceName", deviceName);
		    }

		    if (deviceOrientation != null) {
			    capabilities.SetCapability("deviceOrientation", deviceOrientation);
		    }
		    if (deviceType != null) {
			    capabilities.SetCapability("deviceType", deviceType);
		    }
		    
            if (platformVersion != null) {
			    capabilities.SetCapability("platformVersion", platformVersion);
		    }
		    if (platformName != null) {
			    capabilities.SetCapability("platformName", platformName);
		    }
		    if (browserName != null) {
			    capabilities.SetCapability("browserName", browserName);
		    }
		    if (app != null) {
			    capabilities.SetCapability("app", app);
		    }

		    if (buildTag != null) {
			    capabilities.SetCapability("build", buildTag);
            }
            capabilities.SetCapability("username", slUName); // supply sauce labs username
            capabilities.SetCapability("accessKey", slUAccessKey);  // supply sauce labs account key
            capabilities.SetCapability("name", methodName);// give the test a name

            IOSDriver = new IOSDriver<IOSElement>(new Uri(slUrl), capabilities, TimeSpan.FromSeconds(600));


            return IOSDriver;
        }

    }
}
