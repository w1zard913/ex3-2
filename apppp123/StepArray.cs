using System;

namespace Arrays
{
    internal class StepArray : BaseArray
    {
        public int[][] array;
        public StepArray(int rows, int[] columns, bool IsUserInput = false)
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

        public void DisplayArray()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    string spaces = new string(' ', 5 - $"{this.array[i][j]}".Length);
                    Console.Write($"{spaces}{this.array[i][j]}");
                }
                Console.WriteLine();
            }
        }

        public int[][] RandomFill(int rows, int[] columns)
        {
            Random random = new Random();
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns[i]];
                for (int j = 0; j < columns[i]; j++)
                {
                    array[i][j] = random.Next(1, 1001);
                }
            }
            return array;
        }
        public int[][] UserFill(int rows, int[] columns)
        {
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public float Mean()
        {
            float sum = 0.0f;
            int count = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                }
                count += this.array[i].Length;
            }
            return sum / count;
        }

        public float[] MeanValues()
        {
            float[] means = new float[this.array.Length];
            for (int i = 0;i < this.array.Length; i++)
            {
                float s = 0;
                for (int j = 0;j <  this.array[i].Length; j++)
                {
                    s += this.array[i][j];
                }
                means[i] = s / this.array[i].Length;
            }
            return means;
        }

        public void ChangeEvenNumbers()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    if (this.array[i][j] % 2 == 0)
                    {
                        this.array[i][j] = i * j;
                    }
                }
            }
        }
    }
}