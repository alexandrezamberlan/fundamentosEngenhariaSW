using System;

namespace GestaoBasica
{
    class Item
    {
        public string tipo;
        public string descricao;
        public int quantidadeItem;

        //metodo construtor vazio
        public Item()
        {

        }

        //metodo construtor com parametros
        public Item(string tipo, string descricao, int quantidade)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.quantidadeItem = quantidade;
        }
    }
}