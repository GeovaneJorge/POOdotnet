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
            
            
            //Encapsulamento
            // Valores validos
            Retangulo r =new Retangulo();
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área:{r.ObterArea()}");


        }
    }

}