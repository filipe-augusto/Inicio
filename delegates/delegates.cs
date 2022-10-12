Single System;

namespace Payments
{
    public class Delegates
    {

        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de R${valor}");
        }
        public void iniciando()
        {
            var pagar = new PagamentoPensao.Pagar(RealizarPagamento);
            pagar(25);
        }
    }

    public class PagamentoPensao
    {
        public delegate void Pagar(double valor);
    }
}