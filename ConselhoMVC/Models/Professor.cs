using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConselhoMVC.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        [NotMapped]
        public List<Turma> TurmaList { get; set; }

    }
}
