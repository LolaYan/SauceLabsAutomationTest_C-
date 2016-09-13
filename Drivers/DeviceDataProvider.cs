using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabsAutomation.Drivers
{
    public class DeviceDataProvider
    {
        //Data provider for website browser testing
        public static Object[][] sauceWebBrowserDataProvider()
        {
            return new Object[][] {
		// new Object[] { "internet explorer", "11", "Windows 8.1" },
		// new Object[] { "chrome", "41", "Windows XP" },
		// new Object[] { "safari", "7", "OS X 10.9" },
		// new Object[] { "firefox", "35", "Windows 7" },
		// new Object[] { "opera", "12.12", "Windows 7" },
		new Object[] { "chrome", "45", "Windows 7" } };
        }

        public static Object[][] sauceAndroidBrowserDataProvider()
        {
            return new Object[][] { new Object[] { "1.5.3", "Android Emulator",
				"phone", "portrait", "4.4", "Android", "Browser", null } };
        }

        public static Object[][] sauceAndroidAppDataProvider()
        {
            return new Object[][] { new Object[] { "1.5.1", "Android Emulator",
				null, "portrait", "5.1", "Android", "",
				"sauce-storage:mylotto-sit.apk" } };
        }

        public static Object[][] sauceIOSBrowserDataProvider()
        {
            return new Object[][] { new Object[] { "1.5.3", "iPhone 6 Plus", null,
				"portrait", "9.3", "iOS", "Safari", null } };
        }

        public static Object[][] sauceIOSAppDataProvider()
        {
            return new Object[][] { new Object[] { "1.5.1", "iPhone 6 Plus", null,
				"portrait", "9.2", "iOS", "", "sauce-storage:LottoNZ.zip" } };
        }

    }
}
