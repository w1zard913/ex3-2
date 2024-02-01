using System;

namespace Arrays
{
    class LineArray : BaseArray
    {
        public int[] array;
        public LineArray(int count, bool IsUserInput = false)
        {
            if (IsUserInput)
            {
                this.array = this.UserFill(count);
            }
            else
            {
                this.array = this.RandomFill(count);
            }
        }

        public int[] RandomFill(int count)
        {
            Random random = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(1, 1001);
            }
            return array;
        }

        public int[] UserFill(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i <= count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public new float Mean()
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

        public void DisplayArray()
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
