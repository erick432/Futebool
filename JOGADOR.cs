using System;
using System.Collections.Generic;
using System.Text;

namespace ProjFutebol_01
{
    class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;

        public Jogador(string Nome, int Idade, int Habilidade, int Camisa)
        {
            this.nome = Nome;
            this.idade = Idade;
            this.habilidade = Habilidade;
            this.camisa = Camisa;
        }
        public string getNome()
        {
            return nome;
        }
        public int getCamisa()
        {
            return camisa;
        }
        public int getHabilidade()
        {
            return habilidade;
        }
        public int Gols
        {
            get { return gols; }
            set { gols = value; }
        }
        public string getDescricao()
        {
            return "\n  Nome do Jogador: " + this.getNome() + "\t - Idade: " + this.idade + " - Habilidade: " + this.habilidade + " - Camisa: " + this.camisa + " - Gols: " + this.Gols;
        }
    }
}