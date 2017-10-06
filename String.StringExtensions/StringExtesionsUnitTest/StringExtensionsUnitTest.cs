using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String.StringExtensions;

namespace StringExtesionsUnitTest
{
    [TestClass]
    public class StringExtensionsUnitTest
    {
        [TestMethod]
        public void isNullOrEmptyTest()
        {
            Assert.AreEqual("".isNullOrEmpty(), true);

            string value = null;

            Assert.AreEqual(value.isNullOrEmpty(), true);

            value = "A";

            Assert.AreEqual(value.isNullOrEmpty(), false);


        }

        [TestMethod]
        public void isNullOrWhiteSpaceTest()
        {
            Assert.AreEqual("".isNullOrWhiteSpace(), true);

            string value = null;

            Assert.AreEqual(value.isNullOrWhiteSpace(), true);

            value = "           ";

            Assert.AreEqual(value.isNullOrWhiteSpace(), true);

            Assert.AreEqual("A".isNullOrWhiteSpace(), false);

        }

        [TestMethod]
        public void isMailAddressTest()
        {
            Assert.AreEqual("".isMailAddress(), false);

            Assert.AreEqual("hooge@hoge.com".isMailAddress(), true);

            Assert.AreEqual("hooge@".isMailAddress(), false);
        }

        [TestMethod]
        public void containsNarrowStringTest()
        {
            Assert.AreEqual("あいうえお".containsNarrowString(), false);

            Assert.AreEqual("ABCDE".containsNarrowString(), true);

            Assert.AreEqual("あいうえおABCDE".containsNarrowString(), true);

            Assert.AreEqual("".containsNarrowString(), false);

        }

        [TestMethod]
        public void containsWideStringTest()
        {
            Assert.AreEqual("あいうえお".containsWideString(), true);

            Assert.AreEqual("ABCDE".containsWideString(), false);

            Assert.AreEqual("あいうえおABCDE".containsWideString(), true);

            Assert.AreEqual("".containsWideString(), false);

        }
    }
}
