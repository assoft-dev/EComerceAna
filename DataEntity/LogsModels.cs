namespace DataEntity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Logs")]
    public class LogsModels
    {
        [Key]
        public int LogsModelsID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public virtual UsuariosModels usuariosModels { get; set; }
    }
}