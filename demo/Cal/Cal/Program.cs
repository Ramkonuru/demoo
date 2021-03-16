using System;

namespace Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, result;
            char option;

            char action = 'Y';
            while (action == 'Y')
            {

                Console.Write("\n Enter the First Number : ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number : ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.Write("Enter the Operation : ");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        result = Add(Num1, Num2);
                        Console.WriteLine("The result of Add is : {0}", result);
                        break;
                    case '2':
                        result = Sub(Num1, Num2);
                        Console.WriteLine("The result of Sub is : {0}", result);
                        break;
                    case '3':
                        result = Mul(Num1, Num2);
                        Console.WriteLine("The result of Mul is : {0}", result);
                        break;
                    case '4':
                        result = Div(Num1, Num2);
                        Console.WriteLine("The result of Div is : {0}", result);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                Console.WriteLine("Do you want to continue!\n");
                Console.WriteLine("Press Y to continue");
                Console.WriteLine("Press N to finish");
                action = Console.ReadKey().KeyChar;
            }

            Console.ReadLine();
        }


        public static int Add(int Num1, int Num2)
        {
            int result = Num1 + Num2;
            return result;
        }
        
        public static int Sub(int Num1, int Num2)
        {
            int result = Num1 - Num2;
            return result;
        }
  
        public static int Mul(int Num1, int Num2)
        {
            int result = Num1 * Num2;
            return result;
        }
 
        public static int Div(int Num1, int Num2)
        {
            int result = Num1 / Num2;
            return result;
        }
    }
}

