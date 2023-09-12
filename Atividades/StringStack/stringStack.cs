using System;

namespace stringStackClass{

    public class stringStack{
        static readonly int MAX = 1000; // Definição do valor máximo de itens na pilha.
        int top = -1; // Inicia o topo como -1.
        string[] stringsOnStack = new string[MAX]; // Cria uma variável com o nome de stringsOnStack com MAX itens.

        public bool isEmpty(){
            return (top < 0); // Se top for menor que 0 (ou seja, -1 (valor iniciado), retorna true, else retorna false.)
        }

        public bool Push(string stringAdicionada){
            if(top >= MAX){
                Console.WriteLine("Stack Overflow"); // CASO topo for MAIOR ou IGUAL a MAX, retorna stack overflow (atingido número máximo de itens)
                return false; // Não retorna/retorna falso.
            }
            top += 1; // Caso passe do if anterior, adiciona +1 em top.
            stringsOnStack[top] = stringAdicionada; // Adiciona a string passada como parâmetro no local atual da pilha.
            return true; // Retorna/finaliza função.
        }
        /* A função acima checa se a stack não está lotada, caso esteja, não executa a função abaixo, caso
        não esteja, aumenta o valor de top em +1 e define o valor do item no índice: stringsOnStack[top]
        (agora com o valor de top após o +1) como a string passada como parâmetro na função*/

        public string Pop(){
            if(top < 0){
                Console.WriteLine("Stack Underflow"); // Caso TOP seja MENOR QUE ZERO, retorna stack underflow (Itens abaixo de 0 ou nulos (?))
                return "ERRO"; // Retorna uma string de ERRO
            }
            string texto = stringsOnStack[top]; // DEFINE O VALOR DE TEXTO COMO O VALOR DO ÍNDICE DA NOSSA PILHA
            top -= 1; // Diminui top em -1

            return texto; // FAZ A FUNÇÃO RETORNAR O VALOR DEFINIDO ACIMA EM "TEXTO" (Caso a função seja usada em um print, por exemplo, ela mostrará o valor removido pela função)
        }
         /* A função acima checa se a stack não está vazia, caso esteja, não executa a função abaixo, caso
        não esteja, diminui o valor de top em -1, removendo assim o último ítem a ter sido inserido na pilha e armazena em seu return texto temporariamente.*/

        public void Peek(){
            if(top < 0){
                Console.WriteLine("Stack Underflow"); // SE O VALOR DE TOP FOR MENOR QUE 0 (VAZIO) retorna stack underflow (pilha vazia)
                return;
            }
            Console.WriteLine($"O topo da pilha é: {stringsOnStack[top]}"); // RETORNA O VALOR DO TOPO DA PILHA CASO TOP NÃO SEJA MENOR QUE 0
        }

        public void Clear(){
            if(top >= 0){
                top = -1;
            }
        }

        public void printStack(){
            if(top < 0){
                Console.WriteLine("Stack Underflow"); // check underflow
                return;
            }
            Console.WriteLine($"Itens da pilha:");
            for(int i = top; i >= 0; i--){
                Console.WriteLine($"ITEM [{i}] do STACK: '{stringsOnStack[i]}'");
            }
        }
        /* A função acima checa se a stack não está vazia, caso esteja, não executa a função abaixo, caso
        não esteja, faz loop de forma inversa na pilha, iniciando nosso "i" com o valor igual a top (logo, começamos
        o loop no índice mais alto da pilha) após isso a cada iteração reduzimos o i em 1 (i--), e isso se repete
        enquanto i for maior que 0, e para cada iteração, printamos o item do índice atual do valor de i.*/
    }
}