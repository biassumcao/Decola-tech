using System;
using System.Collections.Generic;
using System.Text;
namespace Desafios
{
   public class Program{

      public static void xenlongao(){
         int c = Convert.ToInt32(Console.ReadLine());
         while(c-- > 0)
         {
            int n = Convert.ToInt32(Console.ReadLine());
            int newval = Convert.ToInt32(Math.Ceiling(n - Math.Sqrt(n)));
            int resposta =  newval;
            Console.WriteLine(resposta);
         }
      }

      public static void Main(string[] args)
      {
         System.Console.WriteLine("MENU");
         System.Console.WriteLine("Escolha uma opção: ");
         System.Console.WriteLine("1. Xenlongao");
         System.Console.WriteLine("2. Quadrado de Pares");
         System.Console.WriteLine("3. Sequencia S");
         System.Console.WriteLine("4. Sequencia IJ 2");
         System.Console.WriteLine("5. Vai ter Copa");
         System.Console.WriteLine("6. Sucessor Par");
      }
   }
}