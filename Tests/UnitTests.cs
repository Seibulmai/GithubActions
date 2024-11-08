using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        //Addition Tests
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Subtraction Tests
        [Test]
        public void Subtract_Valid_Gueret()
        {
            Assert.AreEqual(2, Program.Subtract("6", "4"));
            Assert.AreEqual(4, Program.Subtract("12", "8"));
            Asser.AreEqual(1, Program.Subtract("3", "2"));
        }

        [Test]
        public void Subtract_Invalid_Gueret() 
        {
            Assert.Throws<FormatException>(() => Program.Subtract("12", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "3"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_Gueret()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("5", null));
             Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "4"));
             Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        //Multiplication Tests
        [Test]
        public void Multiply_Valid_Gueret()
        {
            Assert.AreEqual(5, Program.Multiply("5", "1"));
            Assert.AreEqual(16, Program.Multiply("4", "4"));
            Assert.AreEqual(21, Program.Multiply("3", "7"));
        }

        [Test]
        public void Multiply_Invalid_Gueret()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("6", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "9"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        [Test]
        public void Multiply_Null_Gueret() 
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "7"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        //Division Tests
        [Test]
        public void Divide_Valid_Gueret()
        {
            Assert.AreEqual(2, Program.Divide("8", "4"));
            Assert.AreEqual(10, Program.Divide("10", "1"));
            Assert.AreEqual(6, Program.Divide("42", "7"));
        }

        [Test]
        public void Divide_Invalid_Gueret()
        {
            Assert.Throws<FormatException>(() => Program.Divide("8", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_Gueret()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("18", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "5"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        //Power Tests
        [Test]
        public void Power_Valid_Gueret()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(216, Program.Power("6", "3"));
            Assert.AreEqual(16, Program.Power("2", "4"));
        }
    
        [Test]
        public void Power_Invalid_Gueret()
        {
            Assert.Throws<FormatException>(() => Program.Power("13", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "2"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Gueret()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "8"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
