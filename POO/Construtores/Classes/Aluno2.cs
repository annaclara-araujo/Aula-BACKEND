using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno2
    {
        public string name;
        public int cpf;

        public Aluno2() { }
        public Aluno2(string _chuchu)
        {
            name = _chuchu;
        }
        public Aluno2 (int _cpf, string _chuchu)
        {
            name = _chuchu;
            cpf = _cpf;
        }

       



    }






}