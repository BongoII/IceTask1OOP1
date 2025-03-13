using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask1
{
    public class Ingredients
    {
        public int NumOfIngridients { get; set; }
        public string[] Ingriedients { get; set; }
        public int[] NumIngriedients { get; set; }
        public string[] UnitOfMeasurement { get; set; }
        public void enterIngridients()
        {
            for (int e = 0; e < NumOfIngridients; e++)
            {
                Console.Write("Enter the name of the ingridient: ");
                Ingriedients[e] = Console.ReadLine();
                Console.Write("\nEnter the quantity of the ingridients: ");
                NumIngriedients[e] =Convert.ToInt32(Console.ReadLine());
                Console.Write($"\nEnter the unit of measurement for {Ingriedients[e]}: ");
                UnitOfMeasurement[e] = Console.ReadLine();

            }
        }
        
    }
    public class Recipe : Ingredients
    {
        public string[] StepsForRecipe { get; set; }
        public int NumSteps { get; set; }
        public void GetFullSteps()
        {
            for(int v = 0; v < NumSteps; v++)
            {
                Console.WriteLine($"Step {v+1}");
                Console.WriteLine(StepsForRecipe[v]);
            }
        }
    }
}
