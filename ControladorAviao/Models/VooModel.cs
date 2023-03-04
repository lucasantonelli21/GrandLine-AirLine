using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Data;

namespace ControladorAviao.Models
{
    [Table ("Voos")]
    public class VooModel
    {
        [Column("NumeroVoo")]
        [Display(Name = "nVoo")]
        [Key] 
        public int nVoo { get; set; }
        [Column("Data")]
        [Display(Name = "data")]
       

        public DateTime data { get; set; }
        [Column("Horario")]
        [Display(Name = "horario")]
       

        public TimeSpan horario { get; set; }
        [Column("LocalPartida")]
        [Display(Name = "LocalPartida")]
        [StringLength(10, ErrorMessage = "O tamanho máximo é 10 caracteres")]

        public String localPartida { get; set; }
        [Column("LocalChegada")]
        [Display(Name = "LocalChegada")]
        [StringLength(10, ErrorMessage = "O tamanho máximo é 10 caracteres")]

        public int localChegada { get; set; }
        [Column("ValorNormal")]
        [Display(Name = "ValorNormal")]
        public float valorNormal { get; set; }
        [Column("ValorEspecial")]
        [Display(Name = "ValoEspecial")]
        public float valorEspecial { get; set; }

        [Column("AviaoId")]
        [Display(Name = "AviaoId")]
        public int aviaoId { get; set; }
        public virtual AviaoModel aviao { get; set; }
    }
}
