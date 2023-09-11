//int[,] biNumbers = new int[3, 3];

//Vetor de três dimensões:
//int[ , , ] triNumbers = new int[3, 3, 3];

//Criar já carregada:
int[,] loadedBiNumbers = new int[,] {
    {1 ,2 ,3},
    {4, 5, 6},
    {7, 8, 9}
};

for(int i = 0; i < loadedBiNumbers.GetLength(0); i++)
{
    for (int j = 0; j < loadedBiNumbers.GetLength(1); j++)
    {
        Console.Write($"[{loadedBiNumbers[i, j]}]");
    }
    Console.WriteLine("");
}