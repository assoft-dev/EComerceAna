namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Factura")]
    public class FacturaModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),
        Display(Name = "Código")]
        public int FacturaModelsID { get; set; }

        [Key,
        Display(Name = "Doc. Factura"),
        StringLength(250)]
        public string NumeroFactura { get; set; }

        [Display(Name = "Data / Hora"),
        DataType(DataType.DateTime)]
        public DateTime DataHora { get; set; }

        [Display(Name = "Total"),
        Range(0, double.MaxValue, ErrorMessage ="Desculpe não aceitamos valores negativos"),
        DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public decimal ValorTotal { get; set; }
        public virtual ICollection<FacturaOrdemModels> FacturaOrdemModels { get; set; }
    }
}
