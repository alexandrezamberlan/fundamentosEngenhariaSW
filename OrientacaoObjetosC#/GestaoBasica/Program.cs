using System;

namespace GestaoBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador um; //declarando um objeto um do tipo Jogador
            um = new Jogador(); //instanciamos o objeto um na memória == alocar com método construtor
            um.nome = "Diana";
            um.apelido = "Didi";
            um.sexo = "Feminino";
            um.dataNascimento = "23/04/2002";
            um.pontuacaoGeral = 0;

            //instanciamos o objeto dois na memória já passando parâmetros
            Jogador dois = new Jogador("João","Jo","Masculino", 0, "08/01/2003");

            Console.WriteLine("Nome jogador um: " + um.nome);
            Console.WriteLine("Apelido jogador um: " + um.apelido);
            Console.WriteLine("Sexo jogador um: " + um.sexo);
            Console.WriteLine("Data nascimento jogador um: " + um.dataNascimento);

            Console.WriteLine("Nome jogador dois: " + dois.nome);
            Console.WriteLine("Apelido jogador dois: " + dois.apelido);
            Console.WriteLine("Sexo jogador dois: " + dois.sexo);
            Console.WriteLine("Data nascimento jogador dois: " + dois.dataNascimento);

            Item item1 = new Item();
            item1.descricao = "Mapa do labirinto";
            item1.tipo = "Mapa";
            item1.quantidadeItem = 1;

            Item item2 = new Item("Lanterna", "Lanterna vermelha", 1);

            um.itemUnico = item1;
            dois.itemUnico = item2;

            Console.WriteLine("Descrição do item do jogador um: " + um.itemUnico.descricao);
            Console.WriteLine("Tipo do item do jogador um: " + um.itemUnico.tipo);
            Console.WriteLine("Quantidade do item do jogador um: " + um.itemUnico.quantidadeItem);

            Console.WriteLine("Descrição do item do jogador dois: " + dois.itemUnico.descricao);
            Console.WriteLine("Tipo do item do jogador dois: " + dois.itemUnico.tipo);
            Console.WriteLine("Quantidade do item do jogador dois: " + dois.itemUnico.quantidadeItem);
        }
    }
}
