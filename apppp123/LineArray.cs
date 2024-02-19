using System;

namespace Arrays
{
    sealed class LineArray : BaseArray
    {
        public int[] array;
        public LineArray()
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
            Console.WriteLine("Сколько элементов вы бы хотели, чтобы было в массиве?");
            int count = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(1, 1001);
            }
            this.array = array;
        }

        public override void UserFill()
        {
            Console.WriteLine("Сколько элементов вы бы хотели, чтобы было в массиве?");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];
            for (int i = 0; i <= count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            this.array = array;
        }

        public override float Mean()
        {
            int s = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                s += this.array[i];
            }
            return s / this.array.Length;
        }

        public void DeleteElementsUpper100()
        {
            int[] result = { };
            for (int i = 0; i < this.array.Length; i++)
            {
                if (Math.Abs(this.array[i]) <= 100)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }

        public void OnlyUnique()
        {
            int[] result = { };
            for (int i = 0; i < this.array.Length; i++)
            {
                if (!result.Contains(this.array[i]))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }

        public override void DisplayArray()
        {
            Console.Write("[");
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.Write($" {this.array[i]} ");
            }
            Console.Write("]\n");
        }
    }
}
