using stringStackClass; // Namespace é usado aqui

bool running = true;
stringStack stringStack = new stringStack(); // <-- stringStack é o método construtor (nosso molde)

while (running){
    Console.WriteLine("Qual a função desejada?");
    Console.WriteLine("1- Push");
    Console.WriteLine("2- Pop");
    Console.WriteLine("3- Peek");
    Console.WriteLine("4- Clear");
    Console.WriteLine("5- Print");
    Console.WriteLine("6- Exit");
    // Prints acima p/ ilustrar escolhas possíveis

    string? inputX = Console.ReadLine(); // string? possibilita null, armazena o input do usuário como inputX
    if (inputX != null){ // se inputX for diferente de nulo
        if (int.TryParse(inputX, out int selectedOption)) // converte inputX (até então string) em selectedOption (agora uma int)
        {
            switch(selectedOption){ // detecta a opção selecionada
                case 1: // caso selectedOption seja 1
                    Console.WriteLine("Digite a string para adição:");
                    string? inputY = Console.ReadLine(); // string a ser adicionada salva em inputY
                    if (inputY != null){ // se a inputY não for nula
                        stringStack.Push(inputY); // faz o push da inputY
                    } else {
                        Console.WriteLine("String nula e inválida"); // se é nula, retorna erro
                    }
                    break;
                case 2:
                    string popped = stringStack.Pop(); // faz o pop e armazena o retorno em popped
                    Console.WriteLine($"Valor removido: {popped}"); // printa valor do índice removido (armazenado em popped)
                    break;
                case 3:
                    stringStack.Peek();
                    break;
                case 4:
                    stringStack.Clear();
                    break;
                case 5:
                    stringStack.printStack();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } else {
            Console.WriteLine("Não é um número, porcão."); // caso inputX não possa ser convertido em int (vide linha 18)
        }
    }
}