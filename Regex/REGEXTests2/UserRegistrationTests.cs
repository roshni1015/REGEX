using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEX.Tests
{
    [TestClass()]
    public class UserRegistrationTests
    {
        [TestMethod()]
        public void FirstNameTest()
        {
            UserRegistration First = new UserRegistration();
            First.FirstName("Roshni");
            Assert.AreEqual(true, First.FirstName("Roshni"));

        }

        [TestMethod()]
        public void LastNameTest()
        {
            UserRegistration Last = new UserRegistration();
            Last.LastName("Adatrao");
            Assert.AreEqual(true, Last.LastName("Adatrao"));
        }

        [TestMethod()]
        public void EmailTest()
        {
            UserRegistration Email = new UserRegistration();
            Email.Email("abc@gmail.com");
            Assert.AreEqual(true, Email.Email("abc@gmail.com"));
        }

        [TestMethod()]
        public void MobileNumberTest()
        {
            UserRegistration Mobile = new UserRegistration();
            Mobile.MobileNumber("+91 1234567890");
            Assert.AreEqual(true, Mobile.MobileNumber("+91 1234567890"));
        }

        [TestMethod()]
        public void Rule1Test()
        {
            UserRegistration Password1 = new UserRegistration();
            Password1.Rule1("abcdefghij");
            Assert.AreEqual(true, Password1.Rule1("abcdefghij"));
        }

        [TestMethod()]
        public void Rule2Test()
        {
            UserRegistration Password2 = new UserRegistration();
            Password2.Rule2("Abcdefghij");
            Assert.AreEqual(true, Password2.Rule2("Abcdefghij"));
        }

        [TestMethod()]
        public void Rule3Test()
        {
            UserRegistration Password3 = new UserRegistration();
            Password3.Rule3("Abcdefghij11");
            Assert.AreEqual(true, Password3.Rule3("Abcdefghij11"));
        }

        [TestMethod()]
        public void Rule4Test()
        {
            UserRegistration Password4 = new UserRegistration();
            Password4.Rule4("Abcdefghij11@");
            Assert.AreEqual(true, Password4.Rule4("Abcdefghij11@"));
        }
    }
}