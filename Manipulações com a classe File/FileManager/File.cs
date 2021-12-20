using System.IO.Enumeration;
using System.Runtime.Serialization;
using System.Net.Http;
using System.Net;
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

   public void alterarArquivoTexto(string caminho, List<string> alteracao){
      using(var stream = System.IO.File.AppendText(caminho))
      {
         foreach (var item in alteracao)
         {
            stream.WriteLine(item); 
         }
      }
   }

   public void deletarArquivo(string caminho)
   {
      System.IO.File.Delete(caminho);
   }
}