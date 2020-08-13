namespace DataEntity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Produto")]
    public class ProdutoModels
    {
        [Key,
        Display(Name = "Código")]
        public int ProdutoModelsID { get; set; }

        [Display(Name = "Descrição"),
        DataType(DataType.Text),
        StringLength(200),
        Required(ErrorMessage = "Desculpe este campo {0} é Obrigatório")]
        public string Designacao { get; set; }

        [Display(Name = "Preço"),
        Range(0, double.MaxValue, ErrorMessage = "Não podes colocar um valor negativo")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade"),
        Range(0, int.MaxValue, ErrorMessage = "Não podes colocar valores inferiores")]
        public int Quantidade { get; set; }
        public virtual CategoriaModels categoriaModels { get; set; }

        public ICollection<FacturaOrdemModels> FacturaOrdemModels { get; set; }
    }
}