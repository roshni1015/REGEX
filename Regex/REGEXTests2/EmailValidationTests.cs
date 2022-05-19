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
    public class EmailValidationTests
    {
        [TestMethod()]
        public void EmailTest()
        {

            EmailValidation Email1 = new EmailValidation();
            Email1.Email("abc-100@yahoo.com");
            Assert.AreEqual(true, Email1.Email("abc-100@yahoo.com"));
        }
        [TestMethod()]
        public void EmailTest1()
        {

            EmailValidation Email1 = new EmailValidation();
            Email1.Email("abc.100@yahoo.com");
            Assert.AreEqual(true, Email1.Email("abc.100@yahoo.com"));
        }
        [TestMethod()]
        public void EmailTest2()
        {

            EmailValidation Email2 = new EmailValidation();
            Email2.Email("abc@gmail.com");
            Assert.AreEqual(true, Email2.Email("abc@gmail.com"));
        }
        [TestMethod()]
        public void EmailTest3()
        {

            EmailValidation Email3 = new EmailValidation();
            Email3.Email("abc111@abc.com");
            Assert.AreEqual(true, Email3.Email("abc111@abc.com"));
        }
        [TestMethod()]
        public void EmailTest4()
        {

            EmailValidation Email4 = new EmailValidation();
            Email4.Email("abc-100@abc.net");
            Assert.AreEqual(true, Email4.Email("abc-100@abc.net"));
        }
        [TestMethod()]
        public void EmailTest5()
        {

            EmailValidation Email5 = new EmailValidation();
            Email5.Email("abc.100@abc.com.au");
            Assert.AreEqual(true, Email5.Email("abc.100@abc.com.au"));
        }
        [TestMethod()]
        public void EmailTest6()
        {

            EmailValidation Email6 = new EmailValidation();
            Email6.Email("abc@1.com");
            Assert.AreEqual(true, Email6.Email("abc@1.com"));
        }
        [TestMethod()]
        public void EmailTest7()
        {

            EmailValidation Email7 = new EmailValidation();
            Email7.Email("abc.100@gmail.com.com");
            Assert.AreEqual(true, Email7.Email("abc.100@gmail.com.com"));
        }
        [TestMethod()]
        public void EmailTest8()
        {

            EmailValidation Email8 = new EmailValidation();
            Email8.Email("abc+100@gmail.com");
            Assert.AreEqual(true, Email8.Email("abc+100@gmail.com"));
        }

    }
}
   