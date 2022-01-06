using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] piecesClothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacitOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(piecesClothes);

            int sumPieces = 0;
            int countRack = 1;
            int countClothes = clothes.Count();

            for (int i = 0; i < countClothes; i++)
            {
                int currentCloth = clothes.Pop();
          
                sumPieces += currentCloth;
  
                if (sumPieces == capacitOfRack)
                {
                    sumPieces = 0;

                    if (clothes.Count() > 0)
                    {
                        countRack++;
                    }
                }

                if (sumPieces > capacitOfRack)
                {
                    sumPieces = currentCloth;
                    countRack++;
                }
            }

            Console.WriteLine(countRack);
        }
    }
}
