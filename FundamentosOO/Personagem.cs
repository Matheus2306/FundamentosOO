using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Personagem
    {

        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //Metodos
        public virtual void ApresentarSe() { }


        public virtual void Evoluir() { }
        public virtual int Atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + this.Forca + (this.Agilidade) + this.Nivel + this.Vida) / 6;
            return pontosAtaque;
        }
        public virtual int Defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade) + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void Batalha(Personagem p)
        {
            int valorAtaque = this.Atacar();
            int valorDefesa = p.Defender();
            int danoDeVida = valorAtaque - valorDefesa;
            if (danoDeVida <= 0)

                danoDeVida = 1;

            p.Vida = p.Vida - danoDeVida;
            Console.WriteLine("Dano na vida do inimigo e " + danoDeVida);
            Console.WriteLine("O nivel de vida do inimigo agora é" + p.Vida);

            int valorAtaqueInimigo = p.Atacar();
            int valorDefesa2 = this.Defender();
            int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
            if (danoDeVida2 <= 0)

            {
                danoDeVida2 = 1;
            }
            this.Vida = this.Vida - danoDeVida2;
            Console.WriteLine("Dano na vida do Atacante em" + danoDeVida2);
            Console.WriteLine("O nivel de vida do Atacante agora é " + this.Vida);
        }


    }
}
