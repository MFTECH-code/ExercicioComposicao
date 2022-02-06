using System;
using ExerciseComposition1.Entities;
using ExerciseComposition1.Entities.Enums;
using Xunit;

namespace Testes
{
    public class WorkerTest
    {
        [Fact]
        public void TesteAdicionarContrato()
        {
            Worker falseWorker = new Worker
            {
                Level = WorkerLevel.Junior,
                Name = "Jorge",
                BaseSalary = 2400.00
            };
            HourContract falseHourContract = new HourContract
            {
                Date = new DateTime(2022, 07, 30),
                Hours = 40,
                ValuePerHour = 30.00
            };
            
            falseWorker.AddContract(falseHourContract);

            Assert.NotNull(falseWorker.Contracts);
            Assert.True(falseWorker.Contracts[0].Date == falseHourContract.Date);
            Assert.True(falseWorker.Contracts[0].Hours == falseHourContract.Hours);
        }

        [Fact]
        public void TesteRemoverContrato()
        {
            Worker falseWorker = new Worker
            {
                Level = WorkerLevel.Junior,
                Name = "Jorge",
                BaseSalary = 2400.00,
                Contracts =
                {
                    new HourContract
                    {
                    Date = new DateTime(2022, 07, 30),
                    Hours = 40,
                    ValuePerHour = 30.00
                    },
                    new HourContract
                    {
                    Date = new DateTime(2022, 07, 30),
                    Hours = 40,
                    ValuePerHour = 30.00
                    },
                    new HourContract
                    {
                    Date = new DateTime(2022, 07, 30),
                    Hours = 40,
                    ValuePerHour = 30.00
                    }
                }
            };

            falseWorker.RemoveContract(1);
            
            Assert.Equal(2, falseWorker.Contracts.Count);
        }

        [Fact]
        public void TesteValorASerPago()
        {
            #region Mock
            Worker falseWorker = new Worker
            {
                Level = WorkerLevel.Junior,
                Name = "Jorge",
                BaseSalary = 2400.00,
                Contracts =
                {
                    new HourContract
                    {
                        Date = new DateTime(2022, 07, 30),
                        Hours = 40,
                        ValuePerHour = 30.00
                    },
                    new HourContract
                    {
                        Date = new DateTime(2022, 07, 30),
                        Hours = 40,
                        ValuePerHour = 30.00
                    },
                    new HourContract
                    {
                        Date = new DateTime(2022, 07, 30),
                        Hours = 40,
                        ValuePerHour = 30.00
                    }
                }
            };
            #endregion

            var result = falseWorker.Income(2022, 07);
            
            Assert.Equal(6000.0, result);
        }
    }
}