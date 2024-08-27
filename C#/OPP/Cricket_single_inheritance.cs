using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_single_inheritance
{
    class Cricketer
    {
        protected string name;
        protected int age;

        public void SetCricketerData(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        public void ShowCricketerData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Batsman : Cricketer
    {
        private int TotalRuns;
        private double averageRuns;
        private int BestPerformance;
        private int numberOfMatches;

        public void SetBatsmanData(string Name, int Age,int totalRuns, int bestPerformance, int NumberOfMatches)
        {
            SetCricketerData(Name, Age);
            TotalRuns = totalRuns;
            BestPerformance = bestPerformance;
            numberOfMatches = NumberOfMatches;
            CalculateAverageRuns();
        }
        private void CalculateAverageRuns()
        {
            if (numberOfMatches > 0)
            {
                averageRuns = (double)TotalRuns / numberOfMatches;
            }
            else
            {
                averageRuns = 0; 
            }
        }      

        public void ShowBatsmanData()
        {
            ShowCricketerData();
            Console.WriteLine("Total Runs: " + TotalRuns);
            Console.WriteLine("Average Runs: " + averageRuns); 
            Console.WriteLine("Best Performance: "+ BestPerformance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Batsman batsman = new Batsman();
            batsman.SetBatsmanData("Neeraj Rajbhar", 20, 5000, 150,50);
            batsman.ShowBatsmanData();
            Console.ReadLine();
        }
    }
       

}
