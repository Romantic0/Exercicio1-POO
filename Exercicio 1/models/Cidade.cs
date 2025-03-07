using System.ComponentModel.DataAnnotations;

namespace Exercicio_1.models
{
    public class Cidade
    {
        [Key]
        [StringLength(2,MinimumLength =2,ErrorMessage = "se fudeu")]
        public string Estado { get; set; }
        
        [Required(ErrorMessage = "se fuder é obrigatorio")]
        [StringLength(100 , ErrorMessage = "se fuder tem que ter fudiçao")]
        public string nome { get; set; }
        public int codigo { get; set; }
    }
}
