using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Time
    {
        //Atributos
        private string nome1;
        private string nome2;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> jogadores;

        //Construtor
        public Time(string TTime1, string TTime2)
        {
            Time1(TTime1);
            Time2(TTime2);
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.jogadores = new List<Jogador>();
        }

        //Métodos
        public string Nome1
        {
            get { return nome1; }
            set { nome1 = value; }
        }
        public string Nome2
        {
            get { return nome2; }
            set { nome2 = value; }
        }
        public void Time1(string TTime1)
        {
            this.Nome1 = TTime1;
        }
        public void Time2(string TTime2)
        {
            this.Nome2 = TTime2;
        }

        public string getStatus()
        {
            return ("\n   [Status - " + this.Nome1 + "]\n   Vitórias: " + this.Vitorias + "\n   Derrotas: " + this.Derrotas + "\n   Empates: " + this.Empates);
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }

        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }

        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }

        public void contratarJogadores(Jogador Contrato)
        {
            this.jogadores.Add(Contrato);
        }

        private string demitirJogador(Jogador Contrato)
        {
            int buscarJogador = this.jogadores.IndexOf(Contrato);
            string Retorno = "\n\n   Jogador: " + Contrato.getNome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return Retorno + "\n\n   [Demitido].";
            }
            return "\n\n   Não foi possível demitir " + Retorno;
        }

        private Jogador getJogador(int Camisa)
        {
            return jogadores.Find(Contrato => Contrato.getCamisa().Equals(Camisa));
        }

        public void gol(int Camisa)
        {
            this.getJogador(Camisa).Gols = 1;
        }

        public void getDescricaoJogadores()
        {
            foreach (Jogador Jogadores in jogadores)
            {
                Console.Write(Jogadores.getDescricao());
            }
        }
    }
}

