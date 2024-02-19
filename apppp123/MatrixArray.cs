using System;

namespace Arrays
{
    internal class MatrixArray : BaseArray
    {
        public int[,] array;
        public MatrixArray()
        {
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными числами");
            int answer = int.Parse(Console.ReadLine());
            bool IsUserInput = answer == 1;

            if (IsUserInput)
            {
                this.UserFill();
            }
            else
            {
                this.RandomFill();
            }
        }
        public override void RandomFill()
        {

            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько колонок вы бы хотели, чтобы было в массиве?");
            int columns = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 1001);
                }
            }
            this.array = array;
        }

        public override void UserFill()
        {
            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько колонок вы бы хотели, чтобы было в массиве?");
            int columns = int.Parse(Console.ReadLine()); 
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            this.array = array;
        }

        public override void DisplayArray()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                    Console.Write($"{spaces}{this.array[i, j]}");
                }
                Console.WriteLine(); 
            }
        }

        public override float Mean()
        {
            float sum = 0.0f;
            for (int i = 0;i < this.array.GetLength(0); i++)
            {
                for (int j = 0;j < this.array.GetLength(1); j++)
                {
                    sum += this.array[i,j];
                }
            }
            return sum / (this.array.GetLength(0) * this.array.GetLength(1));
        }

        public void PrintArrayAndReversedArray()
        {
            this.DisplayArray();
            Console.WriteLine();
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = this.array.GetLength(1) - 1; j >= 0; j--)
                    {
                        string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }
                else 
                {
                    for (int j = 0; j < this.array.GetLength(1); j++)
                    {
                        string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}