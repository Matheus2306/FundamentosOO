using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public void apresentarSe()
        {
            Console.WriteLine("Olá meu nome é " + this.nome + ", tenho " + this.idade + " sou " + this.Cargo + " e meu sario é R$" + this.Salario);
        }
    }
}
