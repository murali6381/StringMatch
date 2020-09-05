using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringMatch.Tests.Services
{
    using System.Runtime.CompilerServices;
    using StringMatch.Services;

    [TestClass]
    public class StringMatchServiceTest
    {
        private string _inputString = "Murali went out, murali went to the market, Murali went there to buy vegetables";

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "inputString")]
        public void FindInputNullMatch()
        {
            var subString = "Murali";
            var service = new StringMatchService();
            var expected = string.Empty;
            var actual = service.FindStartingIndex(null, subString);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "subString")]
        public void FindSubStringNullMatch()
        {
            var service = new StringMatchService();
            var expected = string.Empty;
            var actual = service.FindStartingIndex(_inputString, null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "subString")]
        public void FindBothNullMatch()
        {
            var service = new StringMatchService();
            var expected = string.Empty;
            var actual = service.FindStartingIndex(null, null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindInputEmptyMatch()
        {
            var subString = "Murali";
            var service = new StringMatchService();
            var expected = string.Empty;
            var actual = service.FindStartingIndex(string.Empty, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSubStringEmptyMatch()
        {
            var service = new StringMatchService();
            var expected = string.Empty;
            var actual = service.FindStartingIndex(_inputString, "");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubStringWordMatch()
        {
            var subString = "Murali";
            var service = new StringMatchService();
            var expected = "1,18,45";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubStringSpansWordMatch()
        {
            var subString = " Out, Murali ";    //Input text as " Out, Murali " with leading and trailing spaces
            var service = new StringMatchService();
            var expected = "12";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubStringPartialWordMatch()
        {
            var subString = "LI";   //Inpput text as LI
            var service = new StringMatchService();
            var expected = "5,22,49";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubStringNotPresentMatch()
        {
            var subString = "Z";    //Input a wrong text
            var service = new StringMatchService();
            var expected = "No match found";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPartialSubStringMatch()
        {
            var subString = "murala";   //Input a wrong text
            var service = new StringMatchService();
            var expected = "No match found";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubStringOverRunMatch()
        {
            var subString = "Krishn";   //Input a wrong text
            var service = new StringMatchService();
            var expected = "No match found";
            var actual = service.FindStartingIndex(_inputString, subString);
            Assert.AreEqual(expected, actual);
        } 

        [TestMethod]
        public void CharMatchCaseInsenitive()
        {
            var service = new StringMatchService();

            //Test for Case Sensitivity
            Assert.IsFalse(service.MatchCaseInsenitive('A', 'B'));
            Assert.IsFalse(service.MatchCaseInsenitive('a', 'b'));
            Assert.IsTrue(service.MatchCaseInsenitive('a', 'A'));
            Assert.IsTrue(service.MatchCaseInsenitive('B', 'B'));
            Assert.IsTrue(service.MatchCaseInsenitive('C', 'c'));
        } 
    }
}
