using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public class PedidoCompleto
    {
        private Pedido _pedido;
        private List<Bebida> _bebidas;
        private Sobremesa _sobremesa;

        public PedidoCompleto(Pedido pedido)
        {
            _pedido = pedido;
            _bebidas = new List<Bebida>();
        }

        public void AdicionarPizza(Pizza pizza)
        {
            _pedido.Adicionar(pizza);
        }

        public void AdicionarBebida(Bebida bebida)
        {
            _bebidas.Add(bebida);
        }

        public void EscolherSobremesa(Sobremesa sobremesa)
        {
            _sobremesa = sobremesa;
        }

        public double PrecoAPagar()
        {
            double total = _pedido.PrecoAPagar();

            foreach (Bebida bebida in _bebidas)
            {
                total += bebida.CalcularValorFinal();
            }

            if (_sobremesa != null)
                total += _sobremesa.CalcularValorFinal();

            return total;
        }

        public string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine(_pedido.ToString());

            texto.AppendLine("\nBEBIDAS:");

            foreach (Bebida bebida in _bebidas)
            {
                texto.AppendLine(bebida.ToString());
            }

            texto.AppendLine("\nSOBREMESA:");

            if (_sobremesa != null)
                texto.AppendLine(_sobremesa.ToString());

            texto.AppendLine($"\nTOTAL FINAL: {PrecoAPagar():C2}");

            return texto.ToString();
        }
    }
}
