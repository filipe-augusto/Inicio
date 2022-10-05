// See https://aka.ms/new-console-template for more information
using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer();
           // customer.Name = "Teste";
            Console.WriteLine("--------abc--------");
            Payment P = new Payment();
            P.Nome = "Filipe. Augusto. Santos.";
            P.Idade = 20;
            Console.WriteLine( "NOME " + P.Nome+ " Idade: "+P.Idade);
            Console.ReadLine();
        }
    }

    class Payment
    {
        public DateTime vencimento { get; set; }

        private DateTime _dataPagametno;

        //PROPRIEDADES
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
        private string _nome; 
        public string Nome {
            get{
                _nome = _nome.Replace(".","");
              // Console.WriteLine("lendo valor");
                return _nome;
            }
            set{
                _nome = value;
            }
        } 
        //PROPG
        public int MyProperty { get; private set; }
        //PROP FULL
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                
                idade = value+10; }
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
    struct Customer
    {
        public string Name;
    }
}
