using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_2
{
    public class Avaliacao
    {
        public string Nome { get; set; }
        public float Nota { get; set; }
        public int Serie { get; set; }
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
        private Aluno aluno;
        public Aluno Aluno
        {
            get
            {
                return aluno;
            }
            set
            {
                Aluno novoAluno = value;
                if (validarAluno(novoAluno.Serie))
                {
                    Console.WriteLine("Aluno pode fazer a prova");
                    this.aluno = novoAluno;
                }
                else
                {
                    throw new ArgumentException("Não foi possível adicionar aluno");
                }
            }
        }

        public bool validarAluno(int serieAluno)
        {
            if (serieAluno == this.Serie)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString(){
            return string.Format("Prova: " + this.Nome + "Matéria: " + this.Disciplina + "Professor: " + this.Professor.Nome + "Série: " + this.Serie + "Aluno: " + this.aluno.Nome);
        }
        
    }
}
