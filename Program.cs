using System;
using ExemploPOO.Models;
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
                Computador comp = new Computador();
                System.Console.WriteLine(comp.ToString());



        }
    }

}