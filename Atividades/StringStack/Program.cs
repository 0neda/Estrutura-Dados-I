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

    string? inputX = Console.ReadLine();
    if (inputX != null){
        if (int.TryParse(inputX, out int selectedOption))
        {
            switch(selectedOption){
                case 1:
                    Console.WriteLine("Digite a string para adição:");
                    string? inputY = Console.ReadLine();
                    if (inputY != null){
                        stringStack.Push(inputY);
                    } else {
                        Console.WriteLine("String nula e inválida");
                    }
                    break;
                case 2:
                    string popped = stringStack.Pop();
                    Console.WriteLine($"Valor removido: {popped}");
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
            Console.WriteLine("Não é um número, porcão.");
        }
    }
}