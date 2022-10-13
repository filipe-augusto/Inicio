using System;

namespace Payments
{

    public class inciandoAparelho
    {
        public static void iniciando()
        {
            var app = new Celular();
            app.Nome = "J22";
            app.Id = 1535455;
            app.Ligar();
        }
    }

    public abstract class AAparelho
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligar...");
        }
        public void Desligar()
        {
            Console.WriteLine("Desligando");
        }
    }

    public class Celular : AAparelho
    {


        public override void Ligar()
        {
            Console.WriteLine($"Ligando celular {base.Nome} Id: {this.Id}");
        }
    }

}