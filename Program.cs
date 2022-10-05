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
        public int qualquer { get; private set; }
        //PROP FULL
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                idade = value+10; }
        }
        //METODOS
        //nome do metodo é pagar
        //a assinatura do metodo é protected void Pagar(string numero) 
        protected  virtual void Pagar(string numero) { }
        //sobrecarga - Quando cria metodos com assinaturas diferentes e nomes iguais 
        protected void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false) {

         }

        private void ConsultarSaldoDoCartao()
        {

        }
    }

    //Sobrescrita
    class Movel { 
        public virtual void Preco(){ /*corpo do método*/ }
         }
    class Cama : Movel { 
        public override void Preco(){ /*corpo do método*/ }
         }

    class PaymenTBoleto : Payment
    {
        void Teste()
        {
            base.Pagar("1");
        }
    }

    class PaymentCreditCard : Payment{
            //public override void Pagar( string numero){}
    }
    struct Customer
    {
        public string Name;
    }
}
