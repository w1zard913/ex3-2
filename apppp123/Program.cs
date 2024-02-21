using apppp123;
using Arrays;
using System;

class Program
{
    static void Main()
    {
        IBaseArray[] arrays = { new LineArray(), new MatrixArray(), new StepArray() };
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.WriteLine("Массив:");
            arrays[i].DisplayArray();
            Console.WriteLine("Среднее значение:");
            Console.WriteLine(arrays[i].Mean());
        }

        Printer printer = new Printer();
        printer.Print();
    }
}