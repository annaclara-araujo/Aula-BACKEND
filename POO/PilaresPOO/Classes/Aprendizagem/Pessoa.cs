
using System.Diagnostics.Contracts;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public float peso;
        public float altura;

        public void Envelhecer () 
        {
            idade++;
        }
        public void Engordar (float _kg) 
        {
            peso = peso + _kg;
        }
        public void Emagrecer (float _quilo) 
        {
            peso = peso - _quilo;
        }
        












    }
}