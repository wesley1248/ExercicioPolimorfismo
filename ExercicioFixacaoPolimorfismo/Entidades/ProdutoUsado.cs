using System;
using System.Globalization;

namespace ExercicioFixacaoPolimorfismo.Entidades {
    internal class ProdutoUsado : Produto {
        public DateTime Fabricacao { get; set; }

        public ProdutoUsado () {}

        public ProdutoUsado(string nome, double preco, DateTime aquisicao) : base(nome, preco)
        {
            Fabricacao = aquisicao;
        }

        public override double ValorProduto()
        {
            return base.ValorProduto();
        }

        public override string ToString()
        {
            return $"" + Nome + " usado" + " $ " + ValorProduto().ToString("F2", CultureInfo.InvariantCulture) + " (adquirido: " + Fabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
