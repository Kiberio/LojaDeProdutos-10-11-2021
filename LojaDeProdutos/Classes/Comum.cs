//Daniel Hiroshi Fugikawa - 200209 

namespace LojaDeProdutos.Classes
{
    class Comum:Produto
    {
        //Construtores
        public Comum() { }
        public Comum(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        //To string dos produtos comuns
        public override string ToString()
        {
            return Nome + " - " + Preco;
        }
    }
}
