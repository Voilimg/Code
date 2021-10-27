using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---------------------------------------------------------------");
            WriteLine("Type     Byte(s) of memory           Min                    Max");
            WriteLine("---------------------------------------------------------------");
            WriteLine($"sbyte    {sizeof(sbyte), -4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte     {sizeof(byte), -4}");
            WriteLine($"short    {sizeof(short), -4}");
            WriteLine($"ushort   {sizeof(ushort), -4}");
            WriteLine($"int      {sizeof(int), -4}");
            WriteLine($"unit     {sizeof(unit), -4}");
            WriteLine($"long     {sizeof(long), -4}");
            WriteLine($"ulong    {sizeof(ulong), -4}");
            WriteLine($"float    {sizeof(float), -4}");
            WriteLine($"double   {sizeof(double), -4}");
            WriteLine($"decimal  {sizeof(decimal), -4}");
        }
    }
}
