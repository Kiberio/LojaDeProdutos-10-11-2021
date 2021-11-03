//Daniel Hiroshi Fugikawa - 200209
using System;


namespace LojaDeProdutos.Classes
{
    class Usado:Produto
    {
        //Variavel dos produtos usados
        public DateTime Fabricacao { get; set; }

        //Construtores
        public Usado() { }
        public Usado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Fabricacao = fabricacao;
        }
        //To Strig com a variavel fabricacao
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " +$"(fabricado: {Fabricacao.ToString("dd/MM/yyyy")})";
        }

    }
}
