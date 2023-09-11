using stringStackClass; // Namespace é usado aqui

stringStack pilhaString = new stringStack(); // <-- stringStack é o método construtor (nosso molde)
Console.WriteLine("------------------------------------");
pilhaString.Push("Primeiro item a ser empurrado");
pilhaString.Push("Segundo item a ser empurrado");
pilhaString.Push("Terceiro item a ser empurrado");
pilhaString.Push("Quarto item a ser empurrado");
Console.WriteLine("O PUSH foi executado aqui, de maneira invisível ao usuário");
Console.WriteLine("------------------------------------");
// Strings definidas de maneira a exemplificar FILO (First in, last out) ^


Console.WriteLine("------------------------------------");
Console.WriteLine("PRINT (Mostra pilha da maneira atual após feito o PUSH):");
pilhaString.printStack();
Console.WriteLine("------------------------------------");
Console.WriteLine("POP (Item removido):");
Console.WriteLine(pilhaString.Pop());
Console.WriteLine("------------------------------------");
Console.WriteLine("PEEK (Topo atual da pilha):");
pilhaString.Peek();
