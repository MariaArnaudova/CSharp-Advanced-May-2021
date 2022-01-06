using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firsPersonsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = $"{firsPersonsInfo[0]} {firsPersonsInfo[1]}";

            string adress = $"{firsPersonsInfo[2]}";

            Tuple<string, string> person = new Tuple<string, string>(personName, adress);

            Console.WriteLine(person);

            string[] secondPersonInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string secondName = secondPersonInfo[0];

            int litresBeer = int.Parse(secondPersonInfo[1]);

            Tuple<string, int> secondPerson = new Tuple<string, int>(secondName, litresBeer);

            Console.WriteLine(secondPerson);

            string[] numbersInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int integer =int.Parse( numbersInfo[0]);
            double doubleNumber = double.Parse(numbersInfo[1]);

            Tuple<int, double> numbers = new Tuple<int, double>(integer, doubleNumber);
            Console.WriteLine(numbers);

        }

    }
}
