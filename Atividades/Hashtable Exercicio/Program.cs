using System.Collections;

Hashtable Informacoes = new Hashtable();
bool Rodando = true;

int QuantiaDados = 0;
bool EstadoNome = false;

while (Rodando)
{
    try
    {
        if(EstadoNome)
        {           
            Console.WriteLine("Digite seu CPF (apenas números):");
            string CadastroPessoaFisica = Console.ReadLine();
            if(!Informacoes.ContainsValue(CadastroPessoaFisica))
            {
                Informacoes.Add(QuantiaDados + "CPF", CadastroPessoaFisica);
                Console.WriteLine("CPF adicionado com sucesso");
                Console.WriteLine("Key = {0} - Value {1} - Quantia {2}", QuantiaDados, CadastroPessoaFisica, QuantiaDados);
                QuantiaDados += 1;
                EstadoNome = false;
            }
            else
            {
                Console.WriteLine("Este CPF já existe na Hashtable.");
            }
        }
        else
        {
            Console.WriteLine("Digite um Nome (apenas letras):");
            string Nome = Console.ReadLine();

            if(!Informacoes.ContainsValue(Nome))
            {
                Informacoes.Add(QuantiaDados, Nome);
                Console.WriteLine("Nome adicionado com sucesso");
                Console.WriteLine("Key = {0} - Value {1} - Quantia {2}", QuantiaDados, Nome, QuantiaDados);
                EstadoNome = true;
            }
            else
            {
                Console.WriteLine("Este nome já existe na Hashtable.");
            }
        }
    }

    catch (ArgumentException arg)
    {
        Console.WriteLine("Chave inválida.");
        Console.WriteLine($"Detalhes:\n[{arg.Message}]");
    }

    catch (Exception ex)
    {
        Console.WriteLine("Erro genérico.");
        throw ex;
    }

    // Percorrendo a hash com foreach
    Console.WriteLine();
    foreach(DictionaryEntry de in Informacoes){
        Console.WriteLine("Key = {0} - Value {1}", de.Key, de.Value);
    }
}