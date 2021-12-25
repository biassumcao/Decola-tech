using System.Security.AccessControl;
using System;
using System.IO;

class Program
{
   public static void Main(string[] args)
   {
      var caminho = Console.ReadLine();
      
      File gerenciadorDeArquivos = new File();

      if(caminho != null){
         gerenciadorDeArquivos.listarDiretorios(caminho);
         gerenciadorDeArquivos.listarArquivos(caminho);
      }
   }
}