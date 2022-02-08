using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//Aula de MODELO SELEADO USANDO O "selead" entre a classe Professor e Diretor.
namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"DIRETOR");
        }

    }
}