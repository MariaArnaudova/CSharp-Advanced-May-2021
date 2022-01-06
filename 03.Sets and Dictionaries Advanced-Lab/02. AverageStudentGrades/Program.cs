using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._AverageStudentGrades
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grade = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal currentGrade = decimal.Parse(input[1]);
            
                if (!grade.ContainsKey(name))
                {
                    grade.Add(name, new List<decimal>());
                }
                grade[name].Add(currentGrade);
            }

            foreach (var item in grade)
            {
                // John -> 5.20 3.20 (avg: 4.20)
                StringBuilder allGrades = new StringBuilder();

                for (int i = 0; i < item.Value.Count; i++)
                {
                    allGrades.Append($"{item.Value[i]:F2} ");
                }
                Console.WriteLine($"{item.Key} -> {allGrades.ToString()}(avg: {item.Value.Average():F2})");
            }
        }
    }
}
