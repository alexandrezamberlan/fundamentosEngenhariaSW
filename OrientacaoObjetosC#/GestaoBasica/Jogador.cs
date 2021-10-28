using System;

namespace GestaoBasica
{
    class Jogador
    {
        public string nome;
        public string apelido;
        public string sexo;
        public int pontuacaoGeral;
        public string dataNascimento;

        public Item itemUnico;

        //metodo construtor
        public Jogador(string nome, string apelido, string sexo, int pontuacao, string data) 
        {
            this.nome = nome;
            this.apelido = apelido;
            this.sexo = sexo;
            this.pontuacaoGeral = pontuacao;
            this.dataNascimento = data;
            this.itemUnico = new Item();
        }

        //metodo construtor vazio
        public Jogador()
        {
            this.itemUnico = new Item();
        }
    }
}