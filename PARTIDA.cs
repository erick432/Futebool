using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Partida
    {
        //Atributos
        private DateTime data;
        private Time ttime1;
        private Time ttime2;
        private int placarCasa;
        private int placarVisitante;

        //Construtor
        public Partida(DateTime dataPartida, Time Time1, Time Time2)
        {
            this.ttime1 = Time1;
            this.ttime2 = Time2;
            this.data = dataPartida;
            this.placarCasa = 0;
        }

        //Métodos
        public int golCasa()
        {
            return placarCasa++;
        }

        public int golVisitante()
        {
            return placarVisitante++;
        }

        public string getPlacar()
        {
            if (this.placarCasa > this.placarVisitante)
            {
                this.ttime1.Vitorias = 1;
                this.ttime2.Derrotas = 1;
                return "\n O Vencedor da partida em " + this.data.ToString("[dd/MM/yyyy]") + " entre " + this.ttime1.Nome1 + " x " + this.ttime1.Nome2 + " foi o time " + this.ttime1.Nome1 + " com o placar de " + this.placarCasa.ToString() + " a " + this.placarVisitante.ToString() + ".\n";
            }

            else if (this.placarCasa == this.placarVisitante)
            {
                this.ttime1.Empates = 1;
                this.ttime2.Empates = 1;
                return "\n Sem vencedor na partida em " + this.data.ToString("[dd/MM/yyyy]") + " com o placar de " + this.placarCasa + " a " + this.placarVisitante + ".\n";
            }

            else
            {
                this.ttime1.Derrotas = 1;
                this.ttime2.Vitorias = 1;
                return "\n O Vencedor da partida em " + this.data.ToString("[dd/MM/yyyy]") + " entre " + this.ttime1.Nome1 + " x " + this.ttime1.Nome2 + " foi o time " + this.ttime1.Nome2 + " com o placar de " + this.placarVisitante.ToString() + " a " + this.placarCasa.ToString() + ".\n";
            }
        }

        public void jogar()
        {
            Random rand = new Random();
            Int32 gols = rand.Next(0, 15);

            Console.Write("\n Número total de gols: " + gols);

            for (int i = 1; i <= gols; i++)
            {
                Int32 golDoTime = rand.Next(0, 2);
                
                if (golDoTime == 1)
                {
                    this.golCasa();
                }
                else
                {
                    this.golVisitante();
                }
            }
        }
    }
}