using System;
using System.Globalization;
using ExerciseComposition1.Entities;
using ExerciseComposition1.Entities.Enums;

namespace ExerciseComposition1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department
            {
                Name = Console.ReadLine()
            };
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel) Enum.Parse(typeof(WorkerLevel),Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker
            {
                Department = department,
                Level = level,
                Name = name,
                BaseSalary = baseSalary
            };
            
            Console.Write("How many contracts to this worker? ");
            int totalContracts = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract hc = new HourContract
                {
                    Date = date,
                    Hours = duration,
                    ValuePerHour = valuePerHour
                };
                worker.AddContract(hc);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string incomeDate = Console.ReadLine();
            int month = int.Parse(incomeDate.Split('/')[0]);
            int year = int.Parse(incomeDate.Split('/')[1]);
            Console.WriteLine(worker);
            Console.WriteLine("Income for " + incomeDate + ": " + worker.Income(year, month).ToString("F2"));
        }
    }
}