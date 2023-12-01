using System;

class JogoDaVelha
{
    private static Random random = new Random();
    private static char[,] MatrizDoJogo = new char[3, 3];

    static void Main()
    {
        PreencherJogadas();
        MostrarJogo();
        ConferirVencedor(MatrizDoJogo);
    }

    static void MostrarJogo()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(MatrizDoJogo[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PreencherJogadas()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int randomIndex = random.Next(2);
                char[] letras = { 'X', 'O' };
                char letraAleatoria = letras[randomIndex];
                MatrizDoJogo[i, j] = letraAleatoria;
            }
        }
    }

    static void ConferirVencedor(char[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            if (matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2] && matriz[i, 0] != '\0')
            {
                Console.WriteLine($"Jogador {matriz[i, 0]} venceu!");
                return;
            }

            if (matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i] && matriz[0, i] != '\0')
            {
                Console.WriteLine($"Jogador {matriz[0, i]} venceu!");
                return;
            }
        }

        if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] && matriz[0, 0] != '\0')
        {
            Console.WriteLine($"Jogador {matriz[0, 0]} venceu!");
            return;
        }

        if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0] && matriz[0, 2] != '\0')
        {
            Console.WriteLine($"Jogador {matriz[0, 2]} venceu!");
            return;
        }
        Console.WriteLine("Empate! Não há vencedor.");
    }
}