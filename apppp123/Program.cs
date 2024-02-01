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
            Console.WriteLine("Сколько элементов вы бы хотели, чтобы было в массиве?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными числами");
            answer = int.Parse(Console.ReadLine());
            LineArray array = new LineArray(count, answer == 1);
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
            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько колонок вы бы хотели, чтобы было в массиве?");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными числами");
            answer = int.Parse(Console.ReadLine());
            MatrixArray array = new MatrixArray(rows, columns, answer == 1);
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
            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в {i} ряду?");
                columns[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными числами");
            answer = int.Parse(Console.ReadLine());
            StepArray array = new StepArray(rows, columns, answer == 1);
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