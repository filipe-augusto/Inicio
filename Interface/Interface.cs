

using System;

namespace Payments
{


    public class Inicio
    {

        public void inicio()
        {
            var car = new Car();
            car.Name = "gol";
            car.Run();
            //object value = car.Teste();


        }
    }
    public interface ICar
    {
        public int Color { get; set; }
        public decimal Speed { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Run();
        public void Stop();

        public void Teste()
        {
            Console.WriteLine("teste");
        }
    }
    public class Car : ICar
    {
        public int Color { get; set; }
        public decimal Speed { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Run()
        {
            // Teste();
            Console.WriteLine("Run...");
        }

        public void Stop()
        {
            Console.WriteLine("Stop...");
        }
    }

    public class Fuzilamento : IFuzilamento
    {
        public int Quantidade { get; set; }

        public void Atirar(string alvo)
        {

        }
    }
    public interface IFuzilamento
    {
        public int Quantidade { get; set; }
        public void Atirar(string alvo);
    }


}