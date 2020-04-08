using System;

namespace BasicCSharpArithmeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 2.5f;

            float add = a + b;
            float sub = a - b;
            float mul = a * b;
            float div = a / b;
            float mod = a % b;


            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);
            Console.WriteLine(mod);
        }
    }
}
