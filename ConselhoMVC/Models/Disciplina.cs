namespace ConselhoMVC.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Qualitativa2 { get; set; }
        public float Qualitativa3 { get; set; }
        public float Qualitativa4 { get; set; }
        [NotMapped]
        public List<Aluno> Alunos { get; set; }
    }
}
