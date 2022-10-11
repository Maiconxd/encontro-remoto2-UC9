using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_UC9.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataDeNascimento(DateTime dataNascimento);
    }
}