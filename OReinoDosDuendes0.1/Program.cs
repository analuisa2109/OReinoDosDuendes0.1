using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OReinoDosDuendes0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Reino dos Duendes!");
            Console.WriteLine("Antes de iniciarmos, por favor, informe o seu nome:");
            string nome_usuario = Console.ReadLine();

            Console.WriteLine("Olá, " + nome_usuario + "! Você está prestes a embarcar em uma aventura no Reino dos Duendes.");
            Console.WriteLine("Para continuarmos, por favor, informe a sua idade:");
            int idade_usuario = Convert.ToInt32(Console.ReadLine());
            if (idade_usuario <= 13)
            {
                Console.WriteLine("Desculpe, mas você precisa ter mais de 13 anos para jogar este jogo.");
                return;
            }
            else
            {
                Console.WriteLine("Ótimo! Vamos começar a aventura!");
           
            }

            Console.WriteLine("Exitem duas vilas em uma floresta encantada, a Vila dos Duendes e a Vila dos Elfos.");
            Console.WriteLine("Um certo dia, a Vila dos Elfos atacou a Vila dos Duendes, com o objetivo de destruir a vila e derrotar o Rei Duende");
            Console.WriteLine("O Rei Duende, desesperado, convocou você para ajudá-lo a proteger a vila e derrotar os Elfos.");
            Console.WriteLine("Essa batalha vai acontecer através de uma escolha.");
            Console.WriteLine("Poderes mágicos serão concedidos a você, mas você só poderá escolher um deles.");
            Console.WriteLine("Escolha sabiamente, pois sua decisão determinará o destino da Vila dos Duendes.");
            Console.WriteLine("Primeiro escolha o seu personagem para batalhar:");
            Console.WriteLine("1. Duende verde");
            Console.WriteLine("2. Fada Guerreira");
            Console.WriteLine("3. Mago Elemental");
            int escolha_personagem = Convert.ToInt32(Console.ReadLine());
            string personagem_jogador = Console.ReadLine();
            int pv_jogador = 0;


            if (escolha_personagem == 1)
            {
                personagem_jogador = "Duende verde";
                pv_jogador = 12;
            }
            else if (escolha_personagem == 2)
            {
                personagem_jogador = "Fada Guerreira";
                pv_jogador = 10;
            }
            else if (escolha_personagem == 3)
            {
                personagem_jogador = "Mago Elemental";
                pv_jogador = 8;
            }
            else
            {
                Console.WriteLine("Escolha inválida. Por favor, escolha um dos personagens disponíveis.");
                return;
            }


            //Sistema de escolha do personagem inimigo
            Random escolha_computador = new Random();
            int escolha_inimigo = escolha_computador.Next(1, 4);
            string personagem_inimigo = "";
            int pv_inimigo = 0;

            while (escolha_inimigo == escolha_personagem)
            {
                escolha_computador = new Random();
                escolha_inimigo = escolha_computador.Next(1, 4);
            }
            if (escolha_inimigo == 1)
            {
                personagem_inimigo = "Duende verde";
                pv_inimigo = 12;
            }
            else if (escolha_inimigo == 2)
            {
                personagem_inimigo = "Fada Guerreira";
                pv_inimigo = 10;
            }
            else if (escolha_inimigo == 3)
            {
                personagem_inimigo = "Mago Elemental";
                pv_inimigo = 8;
            }

            Console.WriteLine ("Seu personagem é o(a) " + personagem_jogador + " e possui " + pv_jogador + " pontos de vida."); 
            Console.WriteLine ("O personagem inimigo é o(a) " + personagem_inimigo + " e possui " + pv_inimigo + " pontos de vida."); 
            Console.WriteLine ("Agora você deve escolher o seu poder mágico para a batalha.");
            Console.WriteLine ("Nessa batalha você poderá escolher entre três poderes:");
            Console.WriteLine ("1. Poder de Fogo");
            Console.WriteLine ("2. Poder da Terra");
            Console.WriteLine ("3. Poder da Água");
            int poder_jogador = Convert.ToInt32(Console.ReadLine());
            string poder_escolhido = "";


            if (poder_jogador == 1)
            {
                poder_escolhido = "Poder de Fogo";
                Console.WriteLine(escolha_personagem + " escolheu o " + poder_escolhido + "!");
            }
            else if (poder_jogador == 2)
            {
                poder_escolhido = "Poder da Terra";
                Console.WriteLine(escolha_personagem + " escolheu o " + poder_escolhido + "!"); 
            }
            else if (poder_jogador == 3)
            {
                poder_escolhido = "Poder da Água";
                Console.WriteLine(escolha_personagem + " escolheu o " + poder_escolhido + "!");
            }
            else
            {
                Console.WriteLine("Escolha inválida. Por favor, escolha um dos poderes disponíveis.");
                return;
            }


            Random poderes = new Random();
            int poder_inimigo = poderes.Next(1, 4);
            string poder_inimigo_escolhido = "";


            if (poder_inimigo == 1)
            {
                poder_inimigo_escolhido = "Poder de Fogo";
                Console.WriteLine(personagem_inimigo + " escolheu o poder do Fogo!");
            }
            else if (poder_inimigo == 2)
            {
                poder_inimigo_escolhido = "Poder da Terra";
                Console.WriteLine(personagem_inimigo + " escolheu o poder da Terra!");
            }
            else if (poder_inimigo == 3)
            {
                poder_inimigo_escolhido = "Poder da Água";
                Console.WriteLine(personagem_inimigo + " escolheu o poder da Água!");
            }



            //primeira rodada de batalha
            if (poder_jogador == 1 && poder_inimigo == 1)
            {
                Console.WriteLine (poder_inimigo + poder_escolhido + "são iguais! A batalha continua!");
                Console.WriteLine (personagem_jogador + "e" + personagem_inimigo + " continuam com os mesmos pontos de vida.");
               
            }
            else if (poder_jogador == 2 && poder_inimigo == 2)
            {
                Console.WriteLine (poder_inimigo + poder_escolhido + "são iguais! A batalha continua!");
                Console.WriteLine (personagem_jogador + "e" + personagem_inimigo + " continuam com os mesmos pontos de vida.");
            }
            else if (poder_jogador == 3 && poder_inimigo == 3)
            {
                Console.WriteLine(poder_inimigo + poder_escolhido + "são iguais! A batalha continua!");
                Console.WriteLine(personagem_jogador + "e" + personagem_inimigo + " continuam com os mesmos pontos de vida.");
            }
            else if (poder_jogador == 1 && poder_inimigo == 2)
            {
                pv_inimigo -= 3;
                Console.WriteLine(personagem_jogador + " venceu a rodada! " + personagem_inimigo + " perdeu 3 pontos de vida e agora possui " + pv_inimigo + " pontos de vida.");
            }
            else if (poder_jogador == 2 && poder_inimigo == 3)
            {
                pv_inimigo -= 3;
                Console.WriteLine(personagem_jogador + " venceu a rodada! " + personagem_inimigo + " perdeu 3 pontos de vida e agora possui " + pv_inimigo + " pontos de vida.");
            }
            else if (poder_jogador == 3 && poder_inimigo == 1)
            {
                pv_inimigo -= 3;
                Console.WriteLine(personagem_jogador + " venceu a rodada! " + personagem_inimigo + " perdeu 3 pontos de vida e agora possui " + pv_inimigo + " pontos de vida.");
            }
            else
            {
                pv_jogador -= 3;
                Console.WriteLine(personagem_inimigo + " venceu a rodada! " + personagem_jogador + " perdeu 3 pontos de vida e agora possui " + pv_jogador + " pontos de vida.");
            }
           
        
        }

    }
}
