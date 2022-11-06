using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteViagem_API.Model
{
    [Table("Destino")]
    public class Destino
    {
            [Key]
            public int DestinoId { get; set; }
            [Required(ErrorMessage = "Informe o Destino a ser inserido")]
            [StringLength(50)]
            public string Local { get; set; }
            [Required(ErrorMessage = "Informe a quantidade de passageiros")]
            public int QuantPass { get; set; }
        
    }
}
