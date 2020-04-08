using System;

namespace BasicCSharpInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number Please");
           int x =int.Parse( Console.ReadLine());
            Console.WriteLine("Your Number : {0}",x);

            Console.WriteLine("Enter A Name Please");
            String name = Console.ReadLine();
            Console.WriteLine("Your Number : {0}", name);

            Console.ReadKey();



        }
    }
}
