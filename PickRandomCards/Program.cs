using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入要抽出的紙牌數量： ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }

            else
            {
                Console.WriteLine("請輸入有效的數字。");
            }
        }
    }
}
