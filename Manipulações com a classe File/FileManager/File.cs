using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System;
using System.IO;

public class File
{
   public void listarDiretorios(string caminho)
   {
      var diretorios = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
      foreach (var item in diretorios)
      {
         System.Console.WriteLine(item);
      }

      System.Console.WriteLine();
   }

   public void listarArquivos(string caminho)
   {
      var arquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
      foreach (var item in arquivos)
      {
         System.Console.WriteLine(item);
      }

      System.Console.WriteLine();
   }
}