
using System.Globalization;

namespace ExercicioFixacaoPolimorfismo.Entidades {
    internal class ProdutoImportado : Produto {
        public double CustoTaxa { get; set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco, double custoTaxa) : base(nome, preco)
        {
            CustoTaxa = custoTaxa;
        }

        public override double ValorProduto()
        {
            return base.ValorProduto() + CustoTaxa;
        }

        public override string ToString()
        {
            return $"" + Nome + " $ " + ValorProduto().ToString("F2", CultureInfo.InvariantCulture) + " (Custo da taxa: " + CustoTaxa.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
