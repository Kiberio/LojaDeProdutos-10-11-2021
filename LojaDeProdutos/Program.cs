//Daiel Hiroshi Fugikawa - 200209
using System;


namespace LojaDeProdutos.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando a quantidade de produtos a ser registrado
            Console.WriteLine("Digite o numero de produtos a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            //Criação do vetor
            Produto[] vect = new Produto[x+1];

            for (int i = 1; i < x+1; i++)
            {
                //Informações dos produtos
                Console.WriteLine("===================================");
                Console.WriteLine($"Produto#{i}");
                Console.WriteLine("Comum, Usado ou Importado (c/u/i)? ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (tipo == "i" || tipo == "I")
                {
                    //Informações adicionais para produtos Importados
                    Console.WriteLine("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    //Adicionando o Importado ao vetor
                    vect[i] = new Importado(nome, preco, taxa);
                    
                }
                if (tipo == "u"||tipo == "U")
                {
                    //Informações adicionais para produtror Usados
                    Console.WriteLine("Fabricação: ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    //Adicionando o Usado ao vetor
                    vect[i] = new Usado(nome, preco, fabricacao);
                    
                }
                if (tipo =="c" || tipo == "C")
                {
                    //Adicionar produto comun ao vetor
                    vect[i] = new Comum(nome, preco);
                    
                }
               
            }
            //Formatação
            Console.WriteLine("===================================");
            Console.WriteLine("");

            //Imprimindo produtos com suas determinadas informações 
            Console.WriteLine("Etiquetas: ");
                for (int i = 0; i < x + 1; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(vect[i]);
                    }
                }
                Console.ReadKey();
            
        }
    }
}
