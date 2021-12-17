using System.Security.AccessControl;
using System;
using System.IO;

class Program
{
   public static void Main(string[] args)
   {
      var caminho = "C:\\Program Files\\DecolaTech\\Decola-tech\\Manipulações com a classe File";
      
      File gerenciadorDeArquivos = new File();

      gerenciadorDeArquivos.listarDiretorios(caminho);
      gerenciadorDeArquivos.listarArquivos(caminho);
   }
}