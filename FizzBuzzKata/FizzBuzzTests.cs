using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ThreeisDivisibleByThreeTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisible = fb.IsDivisibleByThree(3);
            Assert.That(isDivisible, Is.True);
        }

        [Test]
        public void FiveisDivisibleByFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisible = fb.IsDivisibleByFive(5);
            Assert.That(isDivisible, Is.True);
        }

        [Test]
        public void OneisNotDivisibleByThreeTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisible = fb.IsNotDivisibleByThree(1);
            Assert.That(isDivisible, Is.True);
        }

        [Test]
        public void OneisNotDivisibleByFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisible = fb.IsNotDivisibleByFive(1);
            Assert.That(isDivisible, Is.True);
        }

        [Test]
        public void NumberIsDivisibleByThreeAndDivisibleByFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool isDivisible = fb.IsDivisibleByThreeAndFive(15);
            Assert.That(isDivisible, Is.True);
        }

        [Test]
        public void TextForDivisibleByThreeisFizzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(3);
            Assert.That(text, Is.EqualTo("Fizz"));
        }

        [Test]
        public void TextForDivisibleByFiveisBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(5);
            Assert.That(text, Is.EqualTo("Buzz"));
        }

        [Test]
        public void TextForDivisibleByThreeAndFiveisFizzBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(15);
            Assert.That(text, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void TextForNoDivisibleByThreeNorFiveIsItselfTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(7);
            Assert.That(text, Is.EqualTo("7"));
        }

        [Test]
        public void OneThroughFifteenTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string thewholething = fb.TheWholeThing(15);
            Assert.That(thewholething, Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
        }
    }
}
