using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoWebApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWebApp.Components.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void ToCamelTest()
        {
            Assert.AreEqual(
                "Test",
                StringUtils.ToCamel("test")
                );
        }
        [TestMethod()]
        public void ToCamelTestUpper()
        {
            Assert.AreEqual(
                "Test",
                StringUtils.ToCamel("TEST")
                );
        }
        [TestMethod()]
        public void ToCamelTestSentence()
        {
            Assert.AreEqual(
                "My Simple Test Scenario, More Text.",
                StringUtils.ToCamel("my simple test sceNArio, more text.")
                );
        }
        [TestMethod()]
        public void ToCamelTestEmpty()
        {
            Assert.AreEqual(
                "",
                StringUtils.ToCamel("")
                );
        }
        [TestMethod()]
        public void ToCamelTestOneLeter()
        {
            Assert.AreEqual(
                "A",
                StringUtils.ToCamel("a")
                );
        }
    }
}