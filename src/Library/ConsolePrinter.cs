using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;


namespace Full_GRASP_And_SOLID.Library
{
public static class ConsolePrinter
    {
         public static void PrintRecipe(ArrayList steps,Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
/* Para determinar este cambio, utilizamos el principio SRP, ya que la clase ConsolePrinter tiene como única responsabilidad  imprimir la
receta, que es el cambio que le hicimos para que lo cumpla.*/