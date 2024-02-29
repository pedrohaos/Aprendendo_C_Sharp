using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_velha
{
    internal class Program
    {
        static char[,] tabuleiro = new char[3, 3]; // Representa o tabuleiro do jogo
        static char jogadorAtual = 'X'; // Começa com o jogador X
        static void Main(string[] args)
        {
            InicializarTabuleiro();
            MostrarTabuleiro();

            // Loop principal do jogo
            while (!JogoAcabou())
            {
                FazerJogada();
                Console.Clear();
                MostrarTabuleiro();
                TrocarJogador();
            }

            // Verificar resultado do jogo
            if (VerificarVitoria('X'))
            {
                Console.WriteLine("Jogador X venceu!");
            }
            else if (VerificarVitoria('O'))
            {
                Console.WriteLine("Jogador O venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }

        static void InicializarTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }
        }

        static void MostrarTabuleiro()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FazerJogada()
        {
            bool jogadaValida = false;

            while (!jogadaValida)
            {
                Console.Write("Jogador " + jogadorAtual + ", faça sua jogada (linha coluna): ");
                string[] entrada = Console.ReadLine().Split(' ');

                if (entrada.Length != 2)
                {
                    Console.WriteLine("Entrada inválida! Use o formato linha coluna.");
                    continue;
                }

                int linha, coluna;

                if (!int.TryParse(entrada[0], out linha) || !int.TryParse(entrada[1], out coluna))
                {
                    Console.WriteLine("Entrada inválida! Use números para linha e coluna.");
                    continue;
                }

                if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
                {
                    Console.WriteLine("Posição fora do tabuleiro! Escolha entre 0 e 2 para linha e coluna.");
                    continue;
                }

                if (tabuleiro[linha, coluna] != ' ')
                {
                    Console.WriteLine("Posição ocupada! Escolha outra.");
                    continue;
                }

                tabuleiro[linha, coluna] = jogadorAtual;
                jogadaValida = true;
            }
        }

        static void TrocarJogador()
        {
            jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
        }

        static bool JogoAcabou()
        {
            return VerificarVitoria('X') || VerificarVitoria('O') || TabuleiroCheio();
        }

        static bool VerificarVitoria(char jogador)
        {
            // Verificar linhas
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
                {
                    return true;
                }
            }

            // Verificar colunas
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[0, j] == jogador && tabuleiro[1, j] == jogador && tabuleiro[2, j] == jogador)
                {
                    return true;
                }
            }

            // Verificar diagonais
            if ((tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador) ||
                (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador))
            {
                return true;
            }

            return false;
        }

        static bool TabuleiroCheio()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
