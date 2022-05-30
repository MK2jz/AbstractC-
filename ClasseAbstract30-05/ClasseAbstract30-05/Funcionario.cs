using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstract30_05
{
    class Funcionario : Pessoa
    {
        protected string registro;

        public override void cadastrar()
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();
        }

        public override void exibir()
        {
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(email);
        }
    }
}
