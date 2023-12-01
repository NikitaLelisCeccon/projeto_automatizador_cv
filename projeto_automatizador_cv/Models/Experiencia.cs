using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projeto_automatizador_cv.Models
{
    [Table("Experiencias")]
    public class Experiencia
    {
        [Key]
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        [Display(Name = "Início")]
        public string Inicio { get; set; }

        [Display(Name = "Término")]
        public string Termino { get; set; }

        public string Atividades { get; set; }

        [ForeignKey("CurriculoCandidato")]
        public string CurriculoCandidato { get; set; }
        
        public Curriculo Curriculo { get; set; }
    }
}