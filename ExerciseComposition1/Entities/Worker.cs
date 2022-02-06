using System;
using System.Collections.Generic;
using ExerciseComposition1.Entities.Enums;

namespace ExerciseComposition1.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        
        public IList<HourContract> Contracts { get; }
        public Department Department { get; set; }

        public Worker()
        {
            Contracts = new List<HourContract>();
        }
        
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(int indexer)
        {
            Contracts.RemoveAt(indexer);
        }

        public double Income(int year, int month)
        {
            var calcContracts = 0.0;
            foreach (var contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    calcContracts += contract.TotalValue();
                }
            }

            return BaseSalary + calcContracts;
        }
    }
}