using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projeto_automatizador_cv.Models
{
    [Table("Curriculos")]
    public class Curriculo
    {
        [Key]
        [Display(Name = "Nome do Candidato")]
        public string Candidato { get; set; }

        [Display(Name = "Nome no CV")]
        public string Nome { get; set; }

        [Display(Name = "Posição")]
        public string Posicao { get; set; }

        [Display(Name = "Resumo Profissional")]
        public string Resumo { get; set; }

        [Display(Name = "Competências")]
        public string Competencias { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }

        [Display(Name = "Início")]
        public string Inicio { get; set; }

        [Display(Name = "Término")]
        public string Termino { get; set; }

        public string Atividades { get; set; }

        [Display(Name = "Formação")]
        public string Formacao { get; set; }

        [Display(Name = "Certificações")]
        public string Certificacoes { get; set; }
        public string Cursos { get; set; }
        public string Idiomas { get; set; }

        public List<Experiencia> Experiencias { get; set; }
    }
    public class Experiencia
    {
        [Key]
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Inicio { get; set; }
        public string Termino { get; set; }
        public string Atividades { get; set; }
    }
}