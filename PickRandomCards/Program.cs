using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cards shall I pick?");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (var card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("The number you entered was not valid.");
            }
        }
    }
}
