using System.Security.AccessControl;
using System;
using System.IO;

class Program
{
   public static void Main(string[] args)
   {
      var caminho = "C:\\Program Files\\DecolaTech\\Decola-tech\\Manipulações com a classe File";
      var caminhoGitEGithub = "C:\\Program Files\\DecolaTech\\Decola-tech\\Git e Github\\Anotações.txt";
      
      File gerenciadorDeArquivos = new File();

      gerenciadorDeArquivos.listarDiretorios(caminho);
      gerenciadorDeArquivos.listarArquivos(caminho);

      var novaAlteracao = new List<string> {"Git push -> envia repositorio para o local remoto ou atualiza-o"};
      
      gerenciadorDeArquivos.alterarArquivoTexto(caminhoGitEGithub, novaAlteracao);
   }
}