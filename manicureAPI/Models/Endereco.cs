using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace manicureAPI.Models
{
    public class Endereco : Cadastro
    {
        public Endereco()
        {
            EnderecoId = Guid.NewGuid();
        }
        [Key]
        public Guid EnderecoId { get; set; }
        [Required(ErrorMessage = "Informe o CEP.")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Informe o Logradouro.")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Informe o Numero.")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Informe o Bairro.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe a UF.")]
        public UF UF { get; set; }
        [Required(ErrorMessage = "Informe a Cidade.")]
        public string Cidade { get; set; }

    }
}
