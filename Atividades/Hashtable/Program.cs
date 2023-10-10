using System.Collections;

// Criar Hashtable

Hashtable openWith = new Hashtable();

try{
    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");

    openWith.Add("txt", "notepad++.exe");
}

catch(ArgumentException aex){
    Console.WriteLine("Ops, você fez cagada. (Chave inválida)");
    Console.WriteLine($"Detalhes do erro: {aex.Message}");
}

catch(Exception ex){
    Console.WriteLine("Ops, tem cagada genérica aí!");
    throw ex;
}

Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"]);
// Substituíção do valor da chave
openWith["rtf"] = "winword.exe";

Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"]);

// Verificando a existência de uma chave na hashtable
if(!openWith.ContainsKey("ht")){
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

// Percorrendo a hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith){
    Console.WriteLine("Key = {0} - Value {1}", de.Key, de.Value);
}

// Obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol){
    Console.WriteLine("Value = {0}", s);
}

// Obtendo apenas as valores do hash
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol){
    Console.WriteLine("Key = {0}", s);
}

// Removendo o registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc")){
    Console.WriteLine("A chave \"doc\" foi removida!");
}


Console.WriteLine("Programa ainda em execução.");