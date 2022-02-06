using System;
using ExerciseComposition1.Entities;
using Xunit;

namespace Testes
{
    public class HourContractTest
    {
        [Fact]
        public void TestValorTotalDoContrato()
        {
            HourContract falseHourContract = new HourContract
            {
                Date = new DateTime(2022, 07, 30),
                Hours = 40,
                ValuePerHour = 30.00
            };

            var result = falseHourContract.TotalValue();
            
            Assert.Equal(1200, result);
        }
    }
}