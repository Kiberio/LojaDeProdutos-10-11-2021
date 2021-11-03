//Daniel Hiroshi Fugikawa - 200209

namespace LojaDeProdutos
{
    abstract class Produto
    {
        //Variaveis para os produtos
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtores
        public Produto() { }
        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //To string para as etiquetas 
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}
