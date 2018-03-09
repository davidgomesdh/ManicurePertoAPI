using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manicureAPI.Models
{
    public abstract class Cadastro
    {
        public Cadastro()
        {
            UsuarioCadastrou = Guid.NewGuid();
            Ativo = true;
            DataCadastrou = DateTime.Now;
        }
        public Guid UsuarioCadastrou { get; set; }
        public DateTime DataCadastrou { get; set; }
        public Guid? UsuarioAlterou { get; set; }
        public DateTime? DataAlterou { get; set; }
        public bool Ativo { get; set; }
    }
}
