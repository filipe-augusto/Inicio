using System;

namespace Payments
{

    public class DowncastUpcastComparandoObjetos
    {
        public void iniciando()
        {
            #region  upcast
            /*        var pessoa = new Pessoa();
                   pessoa = new PessoaFisica();
                   pessoa = new PessoaJuridica(); */

            #endregion
            #region downcast 
            /*    var pessoa1 = new Pessoa();
               var pessoaFisica = new PessoaFisica();
               pessoaFisica = (PessoaFisica)pessoa1; */
            #endregion
            #region comparação de objeto
            var pessoaA = new Pessoa2("Filipe", 22);
            var pessoaB = new Pessoa2("Filipe", 22);

            System.Console.WriteLine(pessoaA == pessoaB);
            System.Console.WriteLine("Comparando os ids: " + (pessoaA.Id == pessoaB.Id));

            System.Console.WriteLine("Usando IEquatable: " + (pessoaA.Equals(pessoaB)));
            #endregion

        }
    }

    #region upcast

    public class Pessoa2 : IEquatable<Pessoa2>
    {
        public Pessoa2(string nome, int id)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa2 pessoa)
        {
            return Id == pessoa.Id & Nome == pessoa.Nome;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {

        public string CPF { get; set; }
    }
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }

    #endregion
}