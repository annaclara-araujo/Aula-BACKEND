using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string Nome { get; set; }
        public string Lançamento { get; set; }
        public float Valor { get; set; }
        public string Genero { get; set; }

    public Jogo (string nm, string ln, float vl, string gn) 
    {
        Nome = nm;
        Lançamento = ln;
        Valor = vl;
        Genero = gn;
    }

    public void ExibirDados() 
        {
            Console.WriteLine(@$"
            
            Nome: {Nome}
            Lançamento: {Lançamento}
            Valor: {Valor}
            Genero: {Genero}
            ");
            
       }
























    }
}