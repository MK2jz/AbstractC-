using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstract30_05
{
    abstract class Pessoa
    {
        protected string nome, idade, email;

        public abstract void cadastrar();

        public abstract void exibir();
    }
}
