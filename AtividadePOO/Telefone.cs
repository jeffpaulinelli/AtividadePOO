using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Telefone
    {
        private string DDD, Prefixo, Sufixo;
        public void imprime(Telefone aux)
        {
            Console.Write(aux.DDD);
            Console.Write(aux.Prefixo);
            Console.WriteLine(aux.Sufixo);
        }
        public Telefone(string DDD, string prefixo, string sufixo)
        {
            this.DDD = DDD;
            this.Prefixo = prefixo;
            this.Sufixo = sufixo;
        }
        public string getDDD()
        {
            return DDD;
        }
        public string getPrefixo()
        {
            return Prefixo;
        }
        public string getSufixo()
        {
            return Sufixo;
        }
        static void Main()
        {
            Telefone t1 = new Telefone("31", "3319", "9500");
            t1.imprime(t1);
            Aluno a1 = new Aluno("31998418338", "01", "Jeff");
            a1.imprime(a1);
            Aluno a2 = new Aluno("31998418338", "02", "Nicole");
            a2.imprime(a2);
            List<Aluno> saladeteste = new List<Aluno>();
            Sala s1 = new Sala(01, saladeteste);
            s1.addAluno(s1, a1);
            s1.addAluno(s1, a2);
            s1.imprime(saladeteste);
            s1.delAluno(s1, a2);
            s1.imprime(saladeteste);
        }

    }
   
}
