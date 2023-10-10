// C# program for implementation of Insertion Sort
using System;
 
class InsertionSort {
     static void printarArray(int[] data)
    {
        int arrMax = data.Length; // Tamanho do escopo da array
        for (int i = 0; i < arrMax; ++i) // Enquanto i for menor que o tamanho do escopo da array
        {
            if (i < arrMax-1) // se i for menor que o tamanho do escopo da array - 1
            { 
                Console.Write(data[i] + ","); // adiciona a data com vírgula após
            }
            else // se não
            {
                Console.Write(data[i]); // adiciona a data sem vírgula após
            }
        }
            
 
        Console.Write("\n"); // pula uma linha
    }
 
     public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 }; // Cria uma array nova com valores pré-definidos, fora de ordem
        InsertionSort ObjetoInsertion = new InsertionSort(); // Cria uma instância chamada Objetoinsertion com a classe acima
        Array.Sort(arr); // Ordena a array de acordo com a função criada na classe do InsertionSort
        printarArray(arr); // Printa a array
    }
}