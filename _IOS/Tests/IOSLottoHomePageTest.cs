using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SauceLabsAutomation._IOS.Tests
{
    [TestClass]
    public class IOSLottoHomePageTest : IOSTestBase
    {
        //Web Test
        [TestMethod]
        public void verifyIOSLottoHomepageTest()
        {
            IOSDriver = createDriver("1.5.3", "iPhone 6 Plus", null,
                "portrait", "9.3", "iOS", "Safari", null, "");
            IOSDriver.Navigate().GoToUrl("https://m.mylotto.co.nz/");
        }

        //APP Test
        [TestMethod]
        public void verifyIOSAppTest()
        {
            IOSDriver = createDriver("1.5.3", "iPhone 6 Simulator", null,
                "portrait", "9.3", "iOS", "", "sauce-storage:SampleApp.zip", "verifyIOSSampleAppTest");
        }

    }
}
