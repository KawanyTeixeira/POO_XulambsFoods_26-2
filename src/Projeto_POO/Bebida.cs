using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Bebida
    {
        private string _nome;
        private double _preco;

        public Bebida(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public double CalcularValorFinal()
        {
            return _preco;
        }

        public override string ToString()
        {
            return $"{_nome} - {_preco:C2}";
        }
    }
}
