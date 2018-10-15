using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using static Logic.GreetingLogic;

namespace Logic.Tests
{
    [TestClass]
    public class GreetingLogicTests
    {
        [TestMethod]
        public void GetGreetingMessage_HelloConcatWithVasya_HelloVasya()
        {
            string source = "Vasya";
            string expected = "Hello, Vasya!";
            string actual = GetGreetingMessage(source);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGreetingMessage1()
        {
            string userName = string.Empty;
            string expected = "Hello, User!";
            string actual = GetGreetingMessage(userName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetGreetingMessage2()
        {
            string userName = null;
            string actual = GetGreetingMessage(userName);
        }

    }
}
