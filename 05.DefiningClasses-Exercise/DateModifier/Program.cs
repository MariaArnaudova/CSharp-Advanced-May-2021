using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDays = Console.ReadLine();
            string endDays = Console.ReadLine();

            DateModifier dateModifire = new DateModifier();
            int totalDays = dateModifire.GetDaysDifference(startDays, endDays);
            Console.WriteLine(totalDays);

        }
    }
}
