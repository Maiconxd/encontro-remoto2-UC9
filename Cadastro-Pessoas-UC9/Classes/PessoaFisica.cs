using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_Pessoas_UC9.Interfaces;

namespace Cadastro_Pessoas_UC9.Classes
{
    //classe pessoa fisica que herda da classe abs e da sua interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //atributos

        public string? Cpf { get; set; }
        public DateTime DataDeNascimento{ get; set; }

    //metodo herdado com sobrescrita da classe abs
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    //metodo herdado da interface IPessoaJuridica
        public bool ValidarDataDeNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}