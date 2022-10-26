using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apprendendo_API.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Senha { get; set; }
    }
}