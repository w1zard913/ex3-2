using System;
using System.Security.Cryptography;

namespace apppp123
{
    internal class Printer : IPrinter
    {
        string[] week_days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        public void Print()
        {
            for (int i = 0; i < week_days.Length; i++)
            {
                Console.Write($"{week_days[i]}  ");
            }
        }
    }
}
