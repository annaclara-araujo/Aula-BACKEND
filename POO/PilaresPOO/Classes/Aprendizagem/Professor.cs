using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Aluno
    {
        public int NIF;
    
        public float salario; 

        public Professor(int _nif)
        {
            NIF = _nif;
        }
        
    }
}