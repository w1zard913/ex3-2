using System;

namespace Arrays
{
    internal class StepArray : BaseArray, IStepArray
    {
        public int[][] array;
        public StepArray()
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

        public override void DisplayArray()
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

        public override void RandomFill()
        {
            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в {i} ряду?");
                columns[i] = int.Parse(Console.ReadLine());
            }

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
            this.array = array;
        }
        public override void UserFill()
        {

            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в {i} ряду?");
                columns[i] = int.Parse(Console.ReadLine());
            }

            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns[i]];
                for (int j = 0; j < columns[i]; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            this.array = array;
        }

        public override float Mean()
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