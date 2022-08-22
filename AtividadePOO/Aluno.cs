using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace AtividadePOO
{
    public class Aluno
    {
        public string matricula, nome;
        public string telefone;
        

        public void imprime(Aluno aux)
        {
            Console.WriteLine(aux.nome + aux.matricula + aux.telefone);
        }
        public Aluno(string telefone, string matricula, string nome)
        {
            this.telefone = telefone;
            this.matricula = matricula;
            this.nome = nome;

        }
        public string getmatricula(Aluno aux)
        {
            return matricula;
        }
        public string getnome(Aluno aux)
        {
            return nome;
        }
    }
    
}
