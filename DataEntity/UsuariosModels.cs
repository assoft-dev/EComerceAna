using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntity
{
    [Table("Usuarios")]
    public class UsuariosModels
    {
        [Key,
        Display(Name = "Código")]
        public int UsuariosModelsID { get; set; }

        [Display(Name = "Nome Completo"),
        DataType(DataType.Text),
        StringLength(200),
        Required(ErrorMessage = "Desculpe este campo {0} é Obrigatório")]
        public string FullName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Login"),
        DataType(DataType.Text),
        StringLength(200),
        Required(ErrorMessage = "Desculpe este campo {0} é Obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Senha"),
        DataType(DataType.Text),
        StringLength(200),
        Required(ErrorMessage = "Desculpe este campo {0} é Obrigatório")]
        public string Senha { get; set; }

        public virtual ICollection<LogsModels> logsModels { get; set; }
    }
}
