using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SauceLabsAutomation._Android.Tests
{
    [TestClass]
    public class AndroidLottoHomePageTest : AndroidTestBase
    {
        //Webview Test
        [TestMethod]
        public void verifyAndroidLottoHomepageTest()
        {
            createDriver("1.5.3", "Android Emulator",
                "phone", "portrait", "4.4", "Android", "Browser", "", "verifyAndroidLottoHomepageTest");
            androidDriver.Navigate().GoToUrl("https://m.mylotto.co.nz/");
        }

        //App Test
        public void verifyAndroidAppTest()
        {
            createDriver("1.5.3", "Android Emulator",
                "phone", "portrait", "4.4", "Android", "", "sauce-storage:mylotto-cat1.apk", "verifyAndroidLottoHomepageTest");
            //androidDriver.Navigate().GoToUrl("https://m.mylotto.co.nz/");
        }

    }
}
