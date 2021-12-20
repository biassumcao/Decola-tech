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
      var novaAlteracao = new List<string> {"Git status -> mostra o status dos arquivos do repositório em questão, se há alterações, novos arquivos etc."};
      gerenciadorDeArquivos.alterarArquivoTexto(caminhoGitEGithub, novaAlteracao);
   }
}