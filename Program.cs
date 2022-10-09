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
            /*            Console.WriteLine("--------abc--------");
                       Payment P = new Payment();
                       P.Nome = "Filipe. Augusto. Santos.";
                       P.Idade = 20;
                     //  Console.WriteLine( "NOME " + P.Nome+ " Idade: "+P.Idade);
                       Movel m = new Movel(1);
                       Cama c = new Cama(5);
                       c.Preco(); */
            #region classe abstrata
            //nao pode ser estanciada
            // var a = new classeEstatica();
            classeEstatica.propriedade1 = 1;





            #endregion

            #region dispose e using
            //
            //  var pessoa = new Pessoa();
            //  pessoa.Dispose();

            /*  using (var pessoa1 = new Pessoa())
             {
                 System.Console.WriteLine("processando o pagamento");
             } */
            #endregion
            //m.Preco();
            Console.ReadLine();
            // ----------------------
            // var pagamento = new  PaymentCreditCard();
            // pagamento

            #region partial
            Payment a = new Payment();
            a.PropriedadeB = 1;
            a.PropriedadeA = 2;
            #endregion
        }
    }

    public sealed class classeSelada
    {
        //inibidir a possiblidade de alguem criar uma herança da classe
    }


    static class classeEstatica
    {
        //não é possivel estanciar

        //propriedades precisam ser estaticas
        public static int propriedade1 { get; set; }

    }

    class Pessoa : IDisposable
    {
        public Pessoa()
        {
            Console.WriteLine("falar...");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento");
        }
    }

    class Payments
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
        public string Nome
        {
            get
            {
                _nome = _nome.Replace(".", "");
                // Console.WriteLine("lendo valor");
                return _nome;
            }
            set
            {
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
            set
            {
                idade = value + 10;
            }
        }
        //METODOS
        //nome do metodo é pagar
        //a assinatura do metodo é protected void Pagar(string numero) 
        protected virtual void Pagar(string numero) { }
        //sobrecarga - Quando cria metodos com assinaturas diferentes e nomes iguais 
        protected void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false)
        {

        }
        private void ConsultarSaldoDoCartao()
        {

        }
    }

    //Sobrescrita
    class Movel
    {
        //CONSTRUTOR
        public DateTime CriacaoDoMovel { get; set; }
        public int Tamanho { get; set; }
        public Movel(int tamanho)
        {
            Tamanho = tamanho;
            CriacaoDoMovel = DateTime.Now;
            Console.WriteLine("Iniciando o movel: " + CriacaoDoMovel + "tamanho: " + Tamanho);
        }
        public virtual void Preco() { Console.WriteLine("METODO PAI - MOVEL"); }
    }
    class Cama : Movel
    {
        public Cama(int tamanho) : base(tamanho)
        {
        }

        public override void Preco()
        {
            base.Preco();//chamando metodo do pai
            Console.WriteLine("METODO FILHO - CAMA");
        }
    }

    class PaymenTBoleto : Payments
    {
        void Teste()
        {
            base.Pagar("1");
        }
    }

    class PaymentCreditCard : Payment
    {
        //public override void Pagar( string numero){}
    }
    struct Customer
    {
        public string Name;
    }
}
