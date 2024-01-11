using System.ComponentModel.DataAnnotations;

namespace Agenciaapi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string  nomeCliente { get; set; }

        [StringLength(30)]
        public string cpfCliente { get; set; }

        [StringLength(50)]
        public string enderecoCliente { get; set; }

        [StringLength(50)]
        public string telefoneCliente { get; set; }

        [StringLength(50)]
        public string emailCliente { get; set; }
    }
}
