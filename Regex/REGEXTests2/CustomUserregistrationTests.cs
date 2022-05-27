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
    public class CustomUserregistrationTests
    {
        [TestMethod()]
        public void CustomException_FirstNameTest()
        {
            string expected = "FirstName is Valid ";
            CustomUserregistration customUserregistration = new CustomUserregistration();
            string result = customUserregistration.CustomException_FirstName("Viysniu");
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CustomException_LastNameTest()
        {
            string expected = "LastName is Valid ";
            CustomUserregistration customUserregistration = new CustomUserregistration();
            string result = customUserregistration.CustomException_LastName("Viysniu");
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CustomException_EmailIDTest()
        {
            string expected = "EmailID is Valid ";
            CustomUserregistration customUserregistration = new CustomUserregistration();
            string result = customUserregistration.CustomException_EmailID("abc.xyz@gmail.co.in");
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CustomException_MobileNumberTest()
        {
            string expected = "MobileNumber is Valid ";
            CustomUserregistration customUserregistration = new CustomUserregistration();
            string result = customUserregistration.CustomException_MobileNumber("+91 1234567890");
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CustomException_InvalidPasswordRuleTest()
        {
            string expected = "Password is Valid ";
            CustomUserregistration customUserregistration = new CustomUserregistration();
            string result = customUserregistration.CustomException_InvalidPasswordRule("Abc#6537");
            Assert.AreEqual(expected, result);
        }
    }
}