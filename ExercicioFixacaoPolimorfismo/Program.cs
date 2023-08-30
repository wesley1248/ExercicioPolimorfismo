using ExercicioFixacaoPolimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoPolimorfismo {
    internal class Program {
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
                
            Console.Write("Quantos Produtos será cadastrado?: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantidadeProdutos; i++)
            {
                Console.WriteLine($"Cadastro {i}.");
                Console.WriteLine();

                Console.Write("Comum, usado, importando (c/u/i): ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Valor: ");
                double preco = double.Parse(Console.ReadLine());

                if (tipo == 'i')
                {
                    Console.Write("Valor da taxa: ");
                    double taxa = double.Parse(Console.ReadLine());

                    Produtos.Add(new ProdutoImportado { Nome = nome, Preco = preco, CustoTaxa = taxa });
                    Console.WriteLine();
                }
                else if (tipo == 'u')
                {
                    Console.Write("Data da fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                    Produtos.Add(new ProdutoUsado { Nome = nome, Preco = preco, Fabricacao = dataFabricacao });
                    Console.WriteLine();
                }
                else
                {
                    Produtos.Add(new Produto { Nome = nome, Preco = preco });
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Registros");
            foreach (Produto cadastrados in Produtos )
            {
                Console.WriteLine(cadastrados.ToString());
            }
        }
    }
}
