using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gitactionstest;

namespace UnitTests
{
    [TestClass]
    public class CaseWorkerTests
    {
        [TestMethod]
        public void TestCaseWorkerIds()
        {
            Assert.IsTrue((int)Cases.CaseWorkers.Joe == 1);
            Assert.IsTrue((int)Cases.CaseWorkers.Jane == 2);
            Assert.IsTrue((int)Cases.CaseWorkers.Mark == 3);
        }

        [TestMethod]
        public void TestCaseWorkersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Cases.CaseWorkers)).Length == 3);
        }
    }
}
