using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabsAutomation.Drivers
{
    public class SauceLabHelper
    {
        // Sauce Labs Credential Parameters.
        public static string seleniumURI;
        public static string buildTag;
        public static string username;
        public static string accesskey;
        public static string AppName;
        public static string AppPackage;
        public static string AppActivity;

        public static string SLUrl;

        public static string buildSauceUri()
        {
            String seleniumURI = "@ondemand.saucelabs.com:80";

            // load property from ./config/ipConfig.properties
            String defaultSeleniumURI = Properties.Settings.Default.seleniumURI;
            String vmSeleniumURI = Properties.Settings.Default.vmSeleniumURI;
            String localSeleniumURI = Properties.Settings.Default.localSeleniumURI;
            String SauceConnectCmdRelayType = Properties.Settings.Default.SauceConnectCmdRelayType.ToUpper();

            if (SauceConnectCmdRelayType.Equals("VM") && vmSeleniumURI != null)
            {
                seleniumURI = vmSeleniumURI;
            }
            else if (SauceConnectCmdRelayType.Equals("LOCAL")
                  && localSeleniumURI != null)
            {
                seleniumURI = localSeleniumURI;
            }
            else if (SauceConnectCmdRelayType == "No" && localSeleniumURI != null)
            {
                seleniumURI = defaultSeleniumURI;
            }
            SLUrl = "http://" + getSauceUsername() + ":" + getSauceUserkey() + seleniumURI + "/wd/hub";
            return SLUrl;
        }

        // Get Sauce User name from settings
        public static string getSauceUsername()
        {
            //username = System.Environment.GetEnvironmentVariable("SAUCE_USERNAME");
            string sauceUnameFromConfig = Properties.Settings.Default.sauceUname;
            if (sauceUnameFromConfig != null)
            {
                username = sauceUnameFromConfig;
            }
            return username;
        }

        // Get Sauce User Key from settings
        public static string getSauceUserkey()
        {
            //accesskey = System.Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY");
            string sauceUkeyFromConfig = Properties.Settings.Default.sauceUkay;
            if (sauceUkeyFromConfig != null)
            {
                accesskey = sauceUkeyFromConfig;
            }
            return accesskey;
        }

        // Get build Tag Name from System Env
        public static String getBuildTag()
        {
            buildTag = System.Environment.GetEnvironmentVariable("BUILD_TAG");
            return buildTag;
        }

        // Get Sauce APK App Name from ./config/ipConfig.properties
        public static String getApkName()
        {
            AppName = Properties.Settings.Default.sauce_AndroidAPK_filename;
            return AppName;
        }

        // Get Sauce APK App Package from ./config/ipConfig.properties
        public static String getApkPackage()
        {
            AppPackage = Properties.Settings.Default.sauce_AndroidAPK_appPackage;
            return AppPackage;
        }

        // Get Sauce APK App Activity from ./config/ipConfig.properties
        public static String getApkActivity()
        {
            AppActivity = Properties.Settings.Default.sauce_AndroidAPK_appActivity;
            return AppActivity;
        }

        // Get Sauce IPA App Name from ./config/ipConfig.properties
        public static String getIpaName()
        {
            String AppName = Properties.Settings.Default.sauce_IOSIPA_filename;
            return AppName;
        }

    }
}
