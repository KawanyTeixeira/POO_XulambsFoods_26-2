using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class Sobremesa
    {
        private string _nome;
        private double _preco;

        public Sobremesa(string nome, double preco)
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
