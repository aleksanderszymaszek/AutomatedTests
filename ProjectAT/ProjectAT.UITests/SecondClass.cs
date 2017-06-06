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
    public class SecondClass
    {
        public const int IAmNot10 = 5;

        [Test]
        public void TestOne()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // No exceptions > pass
        }

        [Test]
        public void TestTwo()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.That(IAmNot10 == 10, "Should be 10");
            // AssertionException > Exception > Fail
        }

        [Test]
        public void TestThree()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if (IAmNot10 != 10)
            {
                throw new Exception("Should be 10");
                // Exception > Fail
            }
        }
    }
}
