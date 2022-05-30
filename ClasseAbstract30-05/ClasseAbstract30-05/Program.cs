using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstract30_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.cadastrar();
            Console.ReadKey();
            Console.Clear();
            f.exibir();

            Console.ReadKey();
        }
    }
}
