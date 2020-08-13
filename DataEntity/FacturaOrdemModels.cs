namespace DataEntity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FacturaOrdem")]
    public class FacturaOrdemModels
    {
        [Key,
        Display(Name = "Código")]
        public int FacturaOrdemModelsID { get; set; }

        [ForeignKey("FacturaModels")]
        public string NumeroFactura { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public virtual FacturaModels FacturaModels { get; set; }

        public ProdutoModels ProdutoModels { get; set; }
    }
}