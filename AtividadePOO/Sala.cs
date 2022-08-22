using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO
{
     public class Sala
    {
        int cod;
        public List<Aluno>alunos = new List<Aluno>();
        

        public Sala(int cod, List<Aluno> lista)
        {
            this.cod = cod;
            this.alunos = lista;
        }
        // declarar sala + o aluno
        public void addAluno(Sala cod, Aluno aux)
        {
            alunos.Insert(0,aux);
        }
        public void imprime(List<Aluno> aux)
        {
            foreach(Aluno a in aux){
                Console.WriteLine("Aluno: " + a.nome +" Matrícula: " + a.matricula + " Telefone: " + a.telefone);
            }
        }
        public void delAluno(Sala cod, Aluno aux)
        {
            alunos.Remove(aux);
        }
    }
}

