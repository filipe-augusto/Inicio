// See https://aka.ms/new-console-template for more information
using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name = "Teste";
            Payment P = new Payment();

        }
    }

    class Payment
    {
        public DateTime vencimento { get; set; }

        private DateTime _dataPagametno;
        public DateTime dataPagamento
        {
            get
            {
                return _dataPagametno;
            }
            set
            {
                _dataPagametno = value;
            }
        }

        protected void Pagar() { }

        private void ConsultarSaldoDoCartao()
        {

        }
    }

    class PaymenTBoleto : Payment
    {
        void Teste()
        {
            base.Pagar();
        }
    }

    // class Customer{
    struct Customer
    {
        public string Name;
    }
}
