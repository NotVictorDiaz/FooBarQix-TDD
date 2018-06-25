using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FBQTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberDivisibleBy3ShouldReturnFoo()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "Foo";
            string actual = obj.Compute("12");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void NumberDivisibleBy5ShouldReturnBar()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "Bar*";
            string actual = obj.Compute("20");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void NumberDivisibleBy7ShouldReturnQix()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "Qix";
            string actual = obj.Compute("14");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void NumberNonDivisibleByAnyShouldReturnSameNumber()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "1";
            string actual = obj.Compute("1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]


        public void ComputeWith60ShouldReturnFooBar()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "FooBar*";
            string actual = obj.Compute("60");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ComputeWith15ShouldReturnFooBarBar()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "FooBarBar";
            string actual = obj.Compute("15");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeWith35ShouldReturnBarQixFooBar()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "BarQixFooBar";
            string actual = obj.Compute("35");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeWith7ShouldReturnQixQix()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "QixQix";
            string actual = obj.Compute("7");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComputeWith105ShouldReturnFooBarQixAsteriskBar()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "FooBarQix*Bar";
            string actual = obj.Compute("105");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ComputeWith101ShouldReturn1Asterisk1()
        {
            FooBarQix obj = new FooBarQix();
            string expected = "1*1";
            string actual = obj.Compute("101");
            Assert.AreEqual(expected, actual);

        }

    }
}
