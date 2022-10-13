// See https://aka.ms/new-console-template for more information

using Payments;
using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Clear();
            //List<int> a = new List<int>();
            Console.WriteLine("----------k13123------");
            #region CLASSES ABSTRATAS
            /*   
                         inciandoAparelho a1 = new inciandoAparelho();
                         inciandoAparelho.iniciando(); 
                         */
            #endregion
            #region UPCAST E DOWNCAST
            //  //  DowncastUpcast downcast_Upcast = new DowncastUpcast();//  downcast_Upcast.iniciando();
            #endregion
            #region  Comprando objetos
            /*   DowncastUpcastComparandoObjetos a = new DowncastUpcastComparandoObjetos();
                          a.iniciando(); */
            #endregion
            #region Event
            //EventsInicial eventos = new EventsInicial();// eventos.iniciando();
            #endregion
            Console.ReadLine();
            //var customer = new Customer();// customer.Name = "Teste";/*   Console.WriteLine("--------abc--------");
            //  Payment P = new Payment();
            // P.Nome = "Filipe. Augusto. Santos.";
            //             P.Idade = 20;
            //  Console.WriteLine( "NOME " + P.Nome+ " Idade: "+P.Idade);
            //           Movel m = new Movel(1);
            //Cama c = new Cama(5);
            //c.Preco();
            #region abstrata e subscrita
            /*   var car = new Polo();
                          car.Ano = 2022;
                          car.Velocidade = 200.5m;
                          car.Nome = "polo preto 2012";
                          car.correr(); */
            #endregion
            //  Console.WriteLine();//m.Preco();//Console.ReadLine();// ----------------------// var pagamento = new  PaymentCreditCard();// pagamento
        }
    }
    class Pagamento
    {
        //Garbage collector
        public Pagamento()
        {
            Console.WriteLine("Iniciando o pagamento");
        }
    }

    #region construtor, metodos e propriedades
    partial class Payment
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
    class PaymenTBoleto : Payment
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
    #endregion



    #region classe Abstrata e sobrescrita
    abstract class Carro
    {
        public string Nome { get; set; }
        public decimal Velocidade { get; set; }

        public virtual void correr()
        {
            Console.WriteLine($"velocidade é {this.Velocidade}km/h");
        }
    }

    class Polo : Carro
    {
        public int Ano { get; set; }
        //sobrescrita
        public override void correr()
        {
            Console.WriteLine($"velocidade do polo é {this.Velocidade}km/h");
        }
    }
    #endregion

}
