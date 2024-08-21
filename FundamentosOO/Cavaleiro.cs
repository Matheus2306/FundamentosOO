using Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    internal class Cavaleiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o Mago " + this.Nome + " tenho " + this.Vida + " pontos de vida.\nInteligência: " + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + "\nNível atual é: " + this.Nivel);
            Console.WriteLine("==================================================");
        }
    }
}
