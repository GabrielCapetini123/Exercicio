using Exercícios.Entities.Enums;
using System.Collections.Generic;

namespace Exercícios.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departaments Departaments { get; set; }
        public List<HourContracts> Contracts { get; set; } = new List<HourContracts>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departaments departaments)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departaments = departaments;
        }

            public void AddContract(HourContracts contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracts(HourContracts contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
                foreach(HourContracts contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
