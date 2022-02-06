using System.Collections.Generic;

namespace ExerciseComposition1
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        
        public IList<HourContract> Contracts { get; } 
    }
}