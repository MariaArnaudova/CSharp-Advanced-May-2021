using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firsPersonsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = $"{firsPersonsInfo[0]} {firsPersonsInfo[1]}";

            string adress = $"{firsPersonsInfo[2]}";
            string town =/* $"{firsPersonsInfo[3]}";*/ String.Empty;
            for (int i = 3; i < firsPersonsInfo.Length; i++)
            {
                town += firsPersonsInfo[i] + " ";
            }
            town.Trim();

            Threeuple<string, string, string> person = new Threeuple<string, string, string>(personName, adress, town);

            Console.WriteLine(person);

            string[] secondPersonInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string secondName = secondPersonInfo[0];

            int litresBeer = int.Parse(secondPersonInfo[1]);

            string drunkInfo = secondPersonInfo[2];

            Threeuple<string, int, string> secondPerson = new Threeuple<string, int, string>(secondName, litresBeer, drunkInfo);

            if (drunkInfo=="drunk")
            {
                Console.WriteLine($"{secondName} -> {litresBeer} -> True");
            }
            else
            {
                Console.WriteLine($"{secondName} -> {litresBeer} -> False");
            }

            string[] personAcountInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = personAcountInfo[0];
            double doubleNumber = double.Parse(personAcountInfo[1]);
            string bankName = personAcountInfo[2];

            Threeuple<string, double,string> numbers = new Threeuple<string, double,string>(name, doubleNumber, bankName);
            Console.WriteLine(numbers);
        }
    }
}
