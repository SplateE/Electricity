using Electricity;
using Electricity.Context;
using Electricity.Contracts;
using Electricity.Controllers;
using Electricity.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NUnit.Framework.Internal;
using System.ComponentModel;

namespace Test
{
    [TestFixture]
    public class Tests : ElectricityController
    {
        public ILastToMonthData _lastToMonthData;

        public Tests(ILogger<ElectricityController> logger, ILastToMonthData lastToMonthData) : base(logger, lastToMonthData)
        {
            _lastToMonthData = lastToMonthData;
        }

        [SetUp]
        public void SetUp()
        {
            
        }
        
        [Test]
        public async Task Test1()
        {
            Console.WriteLine("Test");

            var Result = await _lastToMonthData.GetLastTwoMonthData();

            //if(Result != null)
            Assert.Pass();
        }

    }
}