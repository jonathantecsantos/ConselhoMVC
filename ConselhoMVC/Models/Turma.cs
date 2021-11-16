using System.Collections.Generic;

namespace ConselhoMVC.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Professor> ProfessorList { get; set; }
        public List<Disciplina> DisciplinaList { get; set; }
    }
}
