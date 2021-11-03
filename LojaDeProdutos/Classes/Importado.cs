//Daniel Hiroshi Fugikawa - 200209

namespace LojaDeProdutos.Classes
{
    class Importado:Produto
    {
        
       //Variaveis dos produtor importados 
        public double Taxa { get; set; } 
        //Construtores
        public Importado() { }
        public Importado (string nome,double preco, double taxa):base(nome,preco)
        {
            Nome = nome;
            Preco = preco;
            Taxa = taxa;
        }
        //To String com a variavel taxa 
        public override string ToString()
        {
            return Nome + " - " + Preco + " - " + $"(Taxa: {Taxa})";
        }
    }
}
