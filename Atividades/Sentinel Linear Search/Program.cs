using System;
 
class Program
{
    static void sentinelSearch(int[] lista, int valor)
    {
        int tamanho = lista.Length;
        int ultimo = lista[tamanho - 1];
        lista[tamanho - 1] = valor;
        int i = 0;
 
        while (lista[i] != valor)
            i++;

        lista[tamanho - 1] = ultimo;
 
        if ((i < tamanho - 1) || (lista[tamanho - 1] == valor))
            {
                Console.WriteLine($"O valor [{valor}] foi encontrado no índice [{i}]");
            }
        else
            Console.WriteLine("Valor não encontrado");
    }
    
    public static void Main()
    {
        int[] lista = { 10, 20, 180, 30, 60, 50, 110, 100, 70 };
        sentinelSearch(lista, 70);
    }
}


