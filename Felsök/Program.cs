using System.Runtime.InteropServices;

namespace Felsök
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            void case1()//modifications: space beetween elseif and ; was missing. Program will not compile because it does not understand the code
            {
                Console.WriteLine("Case 1");
                int number = 2;

                if (number > 3)
                {
                    Console.WriteLine("Talet är större än tre");
                }
                else if(number < 3)
                {
                    Console.WriteLine("Talet är mindre än tre");
                }             
            }
            void case2()//changed < to <= because < will be under 100 and <= will be under or equal
            {
                Console.WriteLine("Case 2");
                for (int i = 1; i <= 100; i++) 
                {
                    Console.WriteLine(i);
                }
            }
            void case3()//faulty statement the compiler does not know what to do with "i" or "j" in the for loops. Fix this by adding "++", so instead of "i" we do "i++" same for "j"
            {
                Console.WriteLine("Case 3");
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

            }
            void case4()//it expects doing output. If you do WriteLine() you add a new line but with Write() you are doing nothing and Console.Write(); expects it to do something
                        //fix this my adding "" inside Console.Write() like this Console.Write("")
            {
                Console.WriteLine("Case 4");
                int i = 1;
                while (i <= 5)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("");
                    }

                    Console.WriteLine();
                    i++;
                }
            }
            void case5()//so what i have arrived at is that case 1 doent have a break; and therefore falls to case 2. This it known as "fall-through" behavior in a switch statment.
                        //we can fix this by adding break; to case 1
            {
                Console.WriteLine("Case 5");
                int i = 1;

                switch (i)
                {
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine(i);
                        break;
                    default:
                        Console.WriteLine("Other");
                        break;
                }

            }
            void case6()//need == instead of =. Else the compiler will think the statement is a int instead of a bool inside the if statement
            {
                Console.WriteLine("Case 6");
                int i = 10;

                if (i == 5)
                {
                    Console.WriteLine("i är 5");
                }
            }
            case1();
            case2();
            case3();
            case4();
            case5();
            case6();
        }
    }
}