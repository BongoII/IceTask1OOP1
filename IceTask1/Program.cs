using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            Console.WriteLine("Enter number of ingridients");
            recipe.NumOfIngridients= Convert.ToInt32(Console.ReadLine());
            recipe.enterIngridients();
            Console.WriteLine("Enter number of Steps to cook");
            recipe.NumSteps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In the following process you are going to describe each step and that step is going to be stored");
            recipe.GetFullSteps();
            
        }
    }
}
