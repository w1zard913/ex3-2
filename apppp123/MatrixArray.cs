using System;

namespace Arrays
{
    internal class MatrixArray : BaseArray
    {
        public int[,] array;
        public MatrixArray(int rows, int columns, bool IsUserInput = false)
        {
            if (IsUserInput)
            {
                this.array = this.UserFill(rows, columns);
            }
            else
            {
                this.array = this.RandomFill(rows, columns);
            }
        }
        public int[,] RandomFill(int rows, int columns)
        {
            Random random = new Random();
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 1001);
                }
            }
            return array;
        }

        public int[,] UserFill(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public void DisplayArray()
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

        public float Mean()
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