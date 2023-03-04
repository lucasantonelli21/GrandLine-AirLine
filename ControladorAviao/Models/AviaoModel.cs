using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ControladorAviao.Models
{
    [Table ("Avioes")]
    public class AviaoModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("NumeroRegistro")]
        [Display(Name = "nRegistro")]
        [Key]
        public int aviaoId { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo")]
        [StringLength(10,ErrorMessage = "O tamanho máximo é 10 caracteres")]
        public String modelo { get; set; }

        [Column("QntdAssentos")]
        [Display(Name = "qntdAssentos")]
        public int qntdAssentos { get; set; }

        [Column("QntdEspeciais")]
        [Display(Name = "qntdEspeciais")]
        public int qntdEspeciais { get; set; }

        public List<VooModel> Voos { get; set; }
    }
}
