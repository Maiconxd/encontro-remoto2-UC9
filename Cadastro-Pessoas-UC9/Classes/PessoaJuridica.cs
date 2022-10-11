using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_Pessoas_UC9.Interfaces;

namespace Cadastro_Pessoas_UC9.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }

        public string? Cnpj { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}