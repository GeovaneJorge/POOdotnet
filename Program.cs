using System;
using System.IO;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[]args)
        {   
            // Metodo da aula de abstração
            // Pessoa p1=new Pessoa();
            // p1.Nome="Bob";
            // p1.Idade=20;
            // p1.Apresentar();
            
            //====================================
            //Encapsulamento
            // Valores validos
            // Retangulo r =new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área:{r.ObterArea()}");

            // // Valores Invalidos
            // Retangulo r2 =new Retangulo();
            // r.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área:{r2.ObterArea()}");

                //=====================
                // Aula de Herança
                // Aluno p1=new Aluno();
                // p1.Nome="Bob";
                // p1.Idade=20;
                // p1.Documento="123456";
                // p1.Apresentar();

                // Aula de Herança
                // Professor p1=new Professor();
                // p1.Salario=2000;
                // p1.Nome="Bob";
                // p1.Idade=20;
                // p1.Documento="123456";
                // p1.Apresentar();

                // Aula de Herança
                // Professor p1=new Professor();
                // p1.Salario=2000;
                // p1.Nome="Bob";
                // p1.Idade=20;
                // p1.Documento="123456";
                // p1.Apresentar();
                //====================================
                // Aula de Polimorfismo em tempo de execução virtual override 
                // Aluno p1=new Aluno();
                // p1.Nome="Bob";
                // p1.Idade=20;
                // p1.Documento="123456";
                // p1.Nota=10;
                // p1.Apresentar();

                // Aula de Polimorfismo em tempo de execução virtual override 
                // Professor p1=new Professor();
                // p1.Salario=2000;
                // p1.Nome="Bob";
                // p1.Idade=20;
                // p1.Documento="123456";
                // p1.Apresentar();

                // Aula de Polimorfismo sobrecarga de metodos 
                // Calculadora calc = new Calculadora();
                // System.Console.WriteLine("Resultado da primeira soma: " +calc.Somar(10,10));
                // System.Console.WriteLine("Resultado da segunda soma: " +calc.Somar(10,10,10));

                // //Aula de Classes Abstratas
                // Corrente c  = new Corrente();
                // c.Creditar(1000);
                // c.ExibirSaldo();
                //----------------------------------------------------

                //Aula Trbalhando com a classe de baixo nivel Object 
                //Computador comp = new Computador();
                //System.Console.WriteLine(comp.ToString());
                //--------------------------------------------------
                //Trabalhando com Interfaces 
                //ICalculadora calc = new ICalculadora();
                //System.Console.WriteLine(calc.Somar(10, 20));

                //--------------------------------------------------
                //Aula de Manipulação de arquivos FileHelper Metodo GetDirectories (Listar diretorios)
                // var caminho="C:\\TrabalhandoComArquivos";
                // FileHelper helper = new FileHelper();
                // helper.ListarDiretorios(caminho);

           
                //Aula de Manipulação de arquivos FileHelper Metodo GetFiles (Listar arquivos e diretorios )
                // var caminho="C:\\TrabalhandoComArquivos";
                // FileHelper helper = new FileHelper();
                // helper.ListarArquivosDiretorios(caminho);

                //Aula de Manipulação de arquivos FileHelper Metodo(Criando diretorios) CreateDirectory 
                //  var caminho="C:\\TrabalhandoComArquivos";
                //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 3","SubPastaTeste3");
                //  FileHelper helper = new FileHelper();
                //  System.Console.WriteLine("Criando diretorio: "+ caminhoPathCombine);
                //  helper.CriarDiretorios(Path.Combine(caminho, " Pasta teste 3", "SubPastaTeste3"));
                 
                //Aula de Manipulação de arquivos FileHelper Metodo(Deletando diretorios) DeleteDirectory 
                //     var caminho="C:\\TrabalhandoComArquivos";
                //     var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1");
                //     FileHelper helper = new FileHelper();
                //    helper.ApagarDiretorios(caminhoPathCombine, true);

                 //Aula de Manipulação de arquivos FileHelper Metodo(Criando arquvivos de texto) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo.txt");
                    //  FileHelper helper = new FileHelper();
                    // helper.CriarArquivoTexto(caminhoArquivo, "Olá Teste de escrita de arquivo");


                    //Aula de Manipulação de arquivos FileHelper Metodo(Criando arquvivos) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var listaString = new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  FileHelper helper = new FileHelper();
                    //  helper.CriarArquivoTextoStream(caminhoArquivo,listaString);

                    //Aula de Manipulação de arquivos FileHelper Metodo(Criando arquvivos) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var listaString= new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  var listaStringContinuacao = new List<String>{"Linha 4","Linha 5","Linha 6"};
                    //  FileHelper helper = new FileHelper();
                    //  helper.CriarArquivoTextoStream(caminhoArquivo,listaString);
                    //  helper.AdicionarTextoStream(caminhoArquivo,listaStringContinuacao);


                     //Aula de Manipulação de arquivos FileHelper Metodo(Lendo arquivos) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var listaString= new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  var listaStringContinuacao = new List<String>{"Linha 4","Linha 5","Linha 6"};
                    //  FileHelper helper = new FileHelper();
                    //  helper.LerArquivoStream(caminhoArquivo);


                     //Aula de Manipulação de arquivos FileHelper Metodo(Movendo arquivos) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var novoCaminhoArquivo=Path.Combine(caminho,"Pasta Teste 2","arquivo-teste-stream.txt");
                    //  var listaString= new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  var listaStringContinuacao = new List<String>{"Linha 4","Linha 5","Linha 6"};
                    //  FileHelper helper = new FileHelper();
                    //  helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);


                     //Aula de Manipulação de arquivos FileHelper Metodo(Copiando arquivos e fazendo backups) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var caminhoArquivoTeste=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var caminhoArquivoTesteCopia=Path.Combine(caminho,"arquivo-teste-bkp.txt");
                    //  var novoCaminhoArquivo=Path.Combine(caminho,"Pasta Teste 2","arquivo-teste-stream.txt");

                    //  var listaString= new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  var listaStringContinuacao = new List<String>{"Linha 4","Linha 5","Linha 6"};

                    //  FileHelper helper = new FileHelper();
                    //  helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
                     

                     //Aula de Manipulação de arquivos FileHelper Metodo(Deletando arquivos ) 
                    //  var caminho="C:\\TrabalhandoComArquivos";
                    //  var caminhoPathCombine=Path.Combine(caminho,"Pasta teste 1 ");
                    //  var caminhoArquivo=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var caminhoArquivoTeste=Path.Combine(caminho,"arquivo-teste-stream.txt");
                    //  var caminhoArquivoTesteCopia=Path.Combine(caminho,"arquivo-teste-bkp.txt");
                    //  var novoCaminhoArquivo=Path.Combine(caminho,"Pasta Teste 2","arquivo-teste-stream.txt");

                    //  var listaString= new List<String>{"Linha 1","Linha 2","Linha 3"};
                    //  var listaStringContinuacao = new List<String>{"Linha 4","Linha 5","Linha 6"};

                    //  FileHelper helper = new FileHelper();
                    //  helper.DeletarArquivo(caminhoArquivoTesteCopia);
                     
                     


        }
    }

}