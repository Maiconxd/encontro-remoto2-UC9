using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_Pessoas_UC9.Interfaces;

namespace Cadastro_Pessoas_UC9.Classes
{

    //classe abstrata que herda de sua interface

    public abstract class Pessoa : IPessoa
    {
        //atributos
        public string? Nome { get; set; }
   
    public string? Endereco {get; set;}

    public float Rendimento {get; set;}

    //metodo herdado da interface IPessoa
        public abstract float PagarImposto(float rendimento);
       
    }
}