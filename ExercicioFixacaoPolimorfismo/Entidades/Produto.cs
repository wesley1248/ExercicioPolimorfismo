﻿
using System.Globalization;

namespace ExercicioFixacaoPolimorfismo.Entidades {
    internal class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual double ValorProduto() 
        {
            return Preco;
        }

        public override string ToString()
        {
            return $"{Nome} $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string TesteRetorno() 
        {
            return $"{Nome} $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
