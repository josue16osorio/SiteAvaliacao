using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SiteAvaliacao.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Column("Id")]
        [Display(Name = "código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
