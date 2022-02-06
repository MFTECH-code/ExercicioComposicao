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

        public Worker()
        {
            Contracts = new List<HourContract>();
        }
        
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
    }
}