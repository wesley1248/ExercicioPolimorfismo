---

# Exemplo de Aplicação de Polimorfismo em C#

Este é um exemplo simples de aplicação de polimorfismo em C# usando classes relacionadas a produtos.

## Sobre o Projeto

O projeto demonstra como usar a técnica de polimorfismo em C# para criar uma hierarquia de classes relacionadas a produtos. Três tipos de produtos são representados: comum, importado e usado. Cada tipo de produto tem características específicas que são tratadas por meio de classes derivadas.

## Classes de Produtos

### Classe `Produto`

A classe base que representa um produto comum. Possui propriedades para nome e preço. Além disso, ela possui um método virtual `ValorProduto()` para calcular o valor do produto.

### Classe `ProdutoImportado`

Uma classe derivada de `Produto` que representa produtos importados. Possui uma propriedade adicional `CustoTaxa` que representa a taxa de importação. O método `ValorProduto()` é sobrescrito para adicionar o custo da taxa de importação ao valor do produto.

### Classe `ProdutoUsado`

Uma classe derivada de `Produto` que representa produtos usados. Possui uma propriedade adicional `Fabricacao` que representa a data de aquisição do produto usado.

## Como Usar

1. Clone ou baixe este repositório para o seu sistema.

2. Abra o projeto em seu ambiente de desenvolvimento C#.

3. Navegue até o arquivo `Program.cs` que contém o código principal.

4. Execute o projeto para interagir com a funcionalidade de cadastro de produtos.

## Exemplo de Uso

```csharp
using System;

namespace ExercicioFixacaoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
                
            Console.Write("Quantos Produtos serão cadastrados?: ");
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
```

## Exemplo de Saída

```
Quantos Produtos serão cadastrados?: 3

Cadastro 1.

Comum, usado, importando (c/u/i): c
Nome: Teclado
Valor: 50.00

Cadastro 2.

Comum, usado, importando (c/u/i): u
Nome: Monitor
Valor: 300.00
Data da fabricação: 10/01/2023

Cadastro 3.

Comum, usado, importando (c/u/i): i
Nome: Celular
Valor: 800.00
Valor da taxa: 100.00

Registros
Teclado $ 50.00
Monitor usado $ 300.00 (adquirido: 10/01/2023)
Celular importado $ 900.00 (Custo da taxa: 100.00)
```

## Contribuição

Contribuições são bem-vindas! Para problemas ou sugestões, por favor abra um problema ou envie um pull request.

## Licença

Este projeto está licenciado sob a [Licença XYZ](link_da_licenca).
  
---

Certifique-se de ajustar os detalhes conforme necessário, como informações de licença e estrutura de diretórios, para que correspondam ao seu projeto real. Isso deve ajudar os outros a entenderem melhor como usar e interagir com seu programa de aplicação de polimorfismo em C#.
