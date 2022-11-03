using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Cache;

namespace Tests
{
    [TestClass]
    public class UnitTest1 
    {
        private readonly ILastToMonthData _lastToMonthData;
        [TestMethod]
        public void TestMethod1()
        {

        }

        internal static IResult DbGetTest()
        {
            //var GetsFrom = repo.Get();
            //return GetsFrom is not null ? Results.OK(GetsFrom): Results.NotFound();
            return new UnitTest1();
        }
    }
}
