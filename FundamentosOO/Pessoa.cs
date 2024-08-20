using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public void envelhecer(int anos)
        {
            this.idade += anos;
            Console.WriteLine("Você fez aniversario, agora tem " + this.idade);
        }
    }
}
