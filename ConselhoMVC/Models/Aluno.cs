using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConselhoMVC.Models
{
    public class Aluno
    {

        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        [NotMapped]
        public List<Disciplina> Disciplinas { get; set; }
    }
}
