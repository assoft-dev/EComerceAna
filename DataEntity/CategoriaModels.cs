using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntity
{
    [Table("Categoria")]
    public class CategoriaModels
    {
        [Key,
        Display(Name = "Código")]
        public int CategoriaID { get; set; }

        [Display(Name = "Descrição"),
        DataType(DataType.Text),
        StringLength(200),
        Required(ErrorMessage = "Desculpe este campo {0} é Obrigatório")]
        public string Designacao { get; set; }

        [Display(Name = "Produtos")]
        public ICollection<ProdutoModels> ProdutoModels { get; set; }
    }
}