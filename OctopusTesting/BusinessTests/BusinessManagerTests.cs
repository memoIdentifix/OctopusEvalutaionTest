using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace OctopusTesting.BusinessTests
{
    [TestClass]
    public class BusinessManagerTests
    {
        BusinessManager manager = new BusinessManager();

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ThrowNullExceptionTest()
        {
            manager.DoBusinessStuff(new NullReferenceException("Throw null exception test"));
        }

        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        public void ThrowNullExceptionTestExpected()
        {
            manager.DoBusinessStuff(new AccessViolationException("Throw null exception test"));
        }

        [TestMethod]
        public void BusinessIsViableTrue()
        {
            Assert.IsTrue(manager.CheckIfBusinessIsViable(true));
        }

        [TestMethod]
        public void BusinessIsNOTViableTrue()
        {
            Assert.IsTrue(manager.CheckIfBusinessIsViable(true));
        }

        [TestMethod]
        public void BusinessIsNOT_NOTViableTrue()
        {
            Assert.IsTrue(manager.CheckIfBusinessIsViable(true), "The business is not-not viable");
        }
    }
}
