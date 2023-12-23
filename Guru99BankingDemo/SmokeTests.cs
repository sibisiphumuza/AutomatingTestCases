using BankingTestFramework;
using BankingTestFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99BankingDemo
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void CanLogIn()
        {
            Pages.Login.LogIn();
            Assert.That(Pages.Login.IsLoggedIn(), Is.True);
        }
    }
}
