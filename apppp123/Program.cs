using Arrays;
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("С каким типом массивов вы хотите работать?");
        Console.WriteLine("1 - линейный, 2 - двумерный, 3 - ступенчатый");
        int answer = int.Parse(Console.ReadLine());
        if (answer == 1)
        {
            LineArray array = new LineArray();
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - вывести массив, 2 - найти среднее значение в массиве, 3 - удалить элементы больше 100, 4 - удалить повторяющиеся элементы, 5 - выйти");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    array.DisplayArray();
                }
                if (answer == 2)
                {
                    Console.WriteLine($"Среднее: {array.Mean()}");
                }
                if (answer == 3)
                {
                    array.DeleteElementsUpper100();
                }
                if (answer == 4)
                {
                    array.OnlyUnique();
                }
                if (answer == 5)
                {
                    break;
                }
            }
        }

        else if (answer == 2)
        {
            MatrixArray array = new MatrixArray();
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - вывести массив, 2 - найти среднее значение в массиве, 3 - вывести четные строки в обратном порядке,  5 - выйти");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    array.DisplayArray();
                }
                if (answer == 2)
                {
                    Console.WriteLine($"Среднее: {array.Mean()}");
                }
                if (answer == 3)
                {
                    array.PrintArrayAndReversedArray();
                }
                if (answer == 5)
                {
                    break;
                }
            }
        }

        else if (answer == 3)
        {
            StepArray array = new StepArray();
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - вывести массив, 2 - найти среднее значение в массиве, 3 - найти среднее значение по всем вложенным массивам, 4 - изменить все четные по значению элементы массива на произведения их индексов, 5 - выйти");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    array.DisplayArray();
                }
                if (answer == 2)
                {
                    Console.WriteLine($"Среднее: {array.Mean()}");
                }
                if (answer == 3)
                {
                    array.MeanValues();
                }
                if (answer == 4)
                {
                    array.ChangeEvenNumbers();
                }
                if (answer == 5)
                {
                    break;
                }
            }
        }
    }
}