using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Carro
    {
        //atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        //metodos
        public void acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A velocidade Atual é " + this.Velocidade + "km/h");
        }
        public void Desacelerar()
        {
            this.Velocidade -= 5;
            Console.WriteLine("A velocidade Atual é " + this.Velocidade + "km/h");

        }
    }
}
