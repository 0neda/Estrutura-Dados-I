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
                Informacoes.Add("CPF" + QuantiaDados, CadastroPessoaFisica);
                Console.WriteLine("CPF adicionado com sucesso");
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
                Informacoes.Add("Nome" + QuantiaDados, Nome);
                Console.WriteLine("Nome adicionado com sucesso");
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
        Console.WriteLine("{0}:{1}", de.Key, de.Value);
    }
}