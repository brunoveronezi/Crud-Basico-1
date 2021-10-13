using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Cliente
    {
        [Key]
     public int ClienteId { get; set; }
     [Column(TypeName = "nvarchar(250)")]
     [Required(ErrorMessage = "Campo Obrigatório")]
     [DisplayName("Nome")]
     public string Nome { get; set; }
     [Column(TypeName = "nvarchar(250)")]
     [Required(ErrorMessage = "Campo Obrigatório")]
     [DisplayName("Telefone")]
     public string Telefone { get; set; }
     [Column(TypeName = "nvarchar(250)")]
     [Required(ErrorMessage = "Campo Obrigatório")]
     [DisplayName("Cpf")]
     public string Cpf  { get; set; }
     

    }
}
