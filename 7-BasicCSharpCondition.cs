using System;

namespace BasicCSharpCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Name Please ");
            String input_username = Console.ReadLine();
            String username = "Rezaul Hasan";
            
            String password = "12345678";
            

            if (input_username == username)
            {
                Console.WriteLine("Enter Password Please ");
                String input_password = Console.ReadLine();

                if (input_password == password)
                {
                    Console.WriteLine(" Open ");
                }
                else
                {
                    Console.WriteLine(" Password Wrong ");
                }
            }
            else
            {
                Console.WriteLine("User Name is Worong ");
            }

            Console.ReadKey();

        }
    }
}
