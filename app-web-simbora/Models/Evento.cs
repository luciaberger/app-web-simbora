using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_simbora.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o local")]
        public string Local { get; set; }

    }
}
