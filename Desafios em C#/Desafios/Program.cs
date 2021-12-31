using System.Security.AccessControl;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
namespace Desafios
{
   public class Program
   {

      public static void xenlongao()
      {
         System.Console.WriteLine("Digite o número de casos:");
         int c = Convert.ToInt32(Console.ReadLine());
         while(c-- > 0)
         {
            System.Console.WriteLine("Digite o número de esferas:");
            int n = Convert.ToInt32(Console.ReadLine());
            int newval = Convert.ToInt32(Math.Ceiling(n - Math.Sqrt(n)));
            int answer =  newval;
            Console.WriteLine("Número de esferas a serem procuradas: "+ answer);
         }
      }

      public static void quadradoDePares()
      {
         System.Console.WriteLine("Digite um valor inteiro:");
         int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                if(i % 2 == 0)
                  Console.WriteLine($"{i}^{2} = {i*i}");
            }
      }

      public static void sequenciaS()
      {
         double a, c, S= 0;
            for (a=1; a <= 100; a++)
            {
                c = 1/a; 
                S += c;
            }
            var x=Math.Round(S,2);
            Console.WriteLine(x);
      }
      
      public static void sequenciaIJ2()
      {
         for (int i = 1; i <= 9; i+=2)
            {
                for(int j = 7; j >= 5; j--)    
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
      } 

      public static void vaiTerCopa()
      {
         string str;
            while((str=Console.ReadLine())!= null)
            {
                    int x = int.Parse(str);
                    if (x == 0)
                    {
                    Console.WriteLine("vai ter copa!"); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!");
                    }
            }
      }

      public static void sucessorPar()
      {
         int x = int.Parse(Console.ReadLine());
            
            x = x % 2 == 0 ? x += 2 : ++x;
		        Console.WriteLine(x);
            
      }

      public static void Main(string[] args)
      {
         System.Console.WriteLine("-------------MENU-------------");
         System.Console.WriteLine("Escolha uma opção: ");
         System.Console.WriteLine("1. Xenlongao");
         System.Console.WriteLine("2. Quadrado de Pares");
         System.Console.WriteLine("3. Sequencia S");
         System.Console.WriteLine("4. Sequencia IJ 2");
         System.Console.WriteLine("5. Vai ter Copa");
         System.Console.WriteLine("6. Sucessor Par");

         try
         {
            int choice =  Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
               case 1:
                  xenlongao();
                  break;
               case 2:
                  quadradoDePares();
                  break;
               case 3:
                  sequenciaS();
                  break;
               case 4:
                  sequenciaIJ2();
                  break;
               case 5:
                  vaiTerCopa();
                  break;
               case 6:
                  sucessorPar();
                  break;
               default:
                  System.Console.WriteLine("Opção inválida");
                  break;
            }
         }catch(System.FormatException){
            System.Console.WriteLine("Inválido. A entrada deve ser um valor numérico");
         }
      }
   }
}