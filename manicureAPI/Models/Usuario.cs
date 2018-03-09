using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace manicureAPI.Models
{
    public class Usuario : Cadastro
    {
        public Usuario()
        {
            usuarioId = Guid.NewGuid();
        }
        public Guid usuarioId { get; set; }
        public string IdFirebase { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        [Required(ErrorMessage = "Informe seu nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe seu email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe seu CPF.")]
        public string CPF { get; set; }

        public double? Preco { get; set; }
        [Required(ErrorMessage = "Informe seu Endereco.")]
        public Endereco Endereco { get; set; }

        public string Skype { get; set; }
        public string Whatsapp { get; set; }

    }
}
