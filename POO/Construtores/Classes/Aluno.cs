
namespace Construtores.Classes
{
    public class Aluno
    {
        public string Nome;
        public int Idade { get; set; }
        public string Matricula { get; set; }
    

    public Aluno (string nm, int id, string ma) 
    {
        Nome = nm;
        Idade = id;
        Matricula = ma;

    }

    public void ExibirDados() 
        {
            Console.WriteLine(@$"
            
            Nome: {Nome}
            Idade: {Idade}
            Matricula: {Matricula}
            ");
        
       }
}
}