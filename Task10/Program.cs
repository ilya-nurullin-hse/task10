using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Даны натуральное число n, действительные числа a1, …, аn. Если последовательность а1, …, an упорядочена по не " +
                "убыванию (т. е. Если а1 < = a2 <= … <= an), то оставить ее без изменения. Иначе получить последовательность аn, …, a1.");
            while (true)
            {
                try
                {
                    int count = Input.readInt("Введите количество элементов в последовательности", x => x > 0,
                        "Ожидалось натуральное число");

                    bool isNormal = true;
                    ReversedList list = new ReversedList(Input.readInt("Введите число"));
                    for (int i = 0; i < count - 1; i++)
                    {
                        int next = Input.readInt("Введите число");
                        isNormal = next >= list.data;
                        list = list.append(next);
                    }

                    if (isNormal)
                    {
                        Console.WriteLine("Последовательность упорядочена по неубыванию");
                    }
                    else
                    {
                        Console.WriteLine("Новая коллекция: {0}", list);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидалось число.");
                }
            }
        }
    }
}
