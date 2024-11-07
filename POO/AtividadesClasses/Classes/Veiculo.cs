using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadesClasses.Classes
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public string cor;
        public float potencia;
        public int qtdPortas;

        public void Acelerar()
        {
            Console.WriteLine($"vruuuuuum");
         }
        public void Freiar()
        {
            Console.WriteLine($"Sssss! Ssss!");
            
         }
        public void Ligar()
        {
            Console.WriteLine($"çzr çzr çzr çzr çzr");
            
         }
        public void Desligar()
        { 
            Console.WriteLine($"pif pif pif");
            
        }
    }

}