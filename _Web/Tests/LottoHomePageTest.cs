using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SauceLabsAutomation._Web.Tests
{
    [TestClass]
    public class LottoHomePageTest : TestBase
    {
        [TestMethod]
        public void verifyLottoHomepageTest()
        {
            webDriver = createDriver("chrome", "45", "Windows 7", "verifyLottoHomepageTest");
            webDriver.Navigate().GoToUrl("https://www.google.co.nz");
        }
    }
}
