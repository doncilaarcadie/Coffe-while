using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_cofee_cost = 0;
            int user_choise = 0;
            string user_decision = "";
            do
            {
                Console.WriteLine("Please select your coffe: 1-Small 2-Medum 3-Large");
                bool corect_input = int.TryParse(Console.ReadLine(),out  user_choise);


                switch (user_choise)
                {
                    case 1:
                        total_cofee_cost += 1;
                        break;
                    case 2:
                        total_cofee_cost += 2;
                        break;
                    case 3:
                        total_cofee_cost += 3;
                        break;
                    default:
                        if (corect_input)
                        {
                            Console.WriteLine("Choise \"{0}\" is invalid", user_choise);
                        }
                        else
                        {
                            Console.WriteLine("The choise should be a number");
                        }
                        break;

                }
                do
                {
                    Console.WriteLine("Do you want to continue shopping? Yes/No");
                    user_decision = Console.ReadLine().ToUpper();

                    switch (user_decision)
                    {
                        case "YES":
                            break;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Choise \"{0}\" is invalid", user_decision);
                            break;

                    }
                } while (user_decision != "YES" && user_decision != "NO");




            } while (user_choise > 3 || user_choise < 1 || user_decision == "YES");
            

            

            Console.WriteLine();
            Console.WriteLine("Thanks for shoping with us!!!");
            Console.WriteLine("Total coffee cost is: {0}", total_cofee_cost);








            Console.ReadLine();
        }
    }
}
