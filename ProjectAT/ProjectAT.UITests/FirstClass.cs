using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectAT.UITests
{
    [TestFixture]
    public class FirstClass
    {
        public const int IAmNot10 = 5;

        [TestCase("John", 27)]
        [TestCase("Bob", 100)]
        [TestCase("Michael", 120)]
        public void TestOne(string name, int age)
        {
            Assert.That(
                name, 
                Is.EqualTo("Bob").Or.EqualTo("John"), 
                "Incorrect name");

            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        [Test]
        [Category("uitrimming")]
        [Category("security")]
        [Category("automated")]
        public void TestTwo()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.That(IAmNot10 == 10, "Should be 10");
            // AssertionException > Exception > Fail
        }

        [Test]
        [Description("This test should fail")]
        [Category("run")]
        public void TestThree()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if (IAmNot10 != 10)
            {
                throw new Exception("Should be 10");
                // Exception > Fail
            }
        }

        [Test]
        [Category("type=TBA")]
        [Ignore("TBA")]
        public void TestFour()
        {
            
        }
    }
}
