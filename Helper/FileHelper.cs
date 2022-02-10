using System.Net;
using System;
using System.Net.WebSockets;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        private string novoCaminhoArquivo;

        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
         public void ListarArquivosDiretorios(string caminho)
         {
        
            var retornoArquivos=Directory.GetFiles(caminho,"*",SearchOption.AllDirectories);

            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }

         }

          public void CriarDiretorios(string caminho)
         {
            var retorno=Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);

         }

         public void ApagarDiretorios(string caminho, bool ApagarArquivos)
         {
                Directory.Delete(caminho,ApagarArquivos);
            System.Console.WriteLine("Apagado com sucesso");

         }


         public void CriarArquivoTexto(string caminho, string conteudo)
         {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            System.Console.WriteLine("Criado com sucesso");

            }    
            
         }
          public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
          {
            using (var stream = File.CreateText(caminho))
              foreach(var linha in conteudo)
            {
                stream.WriteLine(linha);
                 System.Console.WriteLine("Criado com sucesso");
             }
         }

         public void AdicionarTexto(string caminho,string conteudo)
          {
            File.AppendAllText(caminho,conteudo);
          }   


         public void AdicionarTextoStream(string caminho, List<string> conteudo)
          {
            using (var stream = File.AppendText(caminho))
              foreach(var linha in conteudo)
            {
                stream.WriteLine(linha);
               
                 System.Console.WriteLine("Criado com sucesso = ");
            
             }
         }
         
         public void LerArquivo(string caminho)
          {
           var conteudo = File.ReadAllLines(caminho);
           foreach(var linha in conteudo)
           {
             System.Console.WriteLine(linha);
           }
         }
          public void LerArquivoStream(string caminho)
          {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
              while((linha = stream.ReadLine()) != null)
              {
              System.Console.WriteLine(linha);
              }
            }

          }

          public void MoverArquivo(string caminho,string novoCaminho, bool sobreescrever)
          {
           File.Move (caminho,novoCaminhoArquivo,sobreescrever);
          }

           public void CopiarArquivo(string caminho,string novoCaminho, bool sobreescrever)
          {
             File.Copy (caminho, novoCaminho,sobreescrever);
             System.Console.WriteLine("Arquivo copiado e backup com sucesso : ) ");
          }


          public void DeletarArquivo(string caminho)
          {
             File.Delete(caminho);
            System.Console.WriteLine("Arquivo deletado com sucesso ");
          }


    }
    
}  
