using System.Collections;

Hashtable Informacoes = new Hashtable();
bool Rodando = true;

bool EstadoNome = false;
bool EstadoCPF = false;
string Nome = "";
string CPF = "";

while (Rodando)
{
    try
    {
        if (!EstadoNome)
        {
            Console.WriteLine("Digite seu nome:");
            Nome = Console.ReadLine();
            if (Nome != "")
            {
                if (!Informacoes.ContainsKey(Nome))
                {
                    EstadoNome = true;
                }
                else
                {
                    Console.WriteLine("Nome já cadastrado.");
                }
            }
            else
            {
                Console.WriteLine("Nome inválido.");
            }
        }
        if (EstadoNome && !EstadoCPF)
        {
            Console.WriteLine("Digite seu CPF:");
            CPF = Console.ReadLine();
            if (CPF != "")
            {
                if (!Informacoes.ContainsValue(CPF))
                {
                    Informacoes.Add(Nome, CPF);
                    EstadoCPF = true;
                }
                else
                {
                    Console.WriteLine("CPF já cadastrado.");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }
        }
        if (EstadoNome && EstadoCPF)
        {
            Console.WriteLine("Cadastro concluído com sucesso.");
            Console.WriteLine();
            foreach(DictionaryEntry de in Informacoes){
                Console.WriteLine("{0}:{1}", de.Key, de.Value);
            }
            EstadoCPF = false;
            EstadoNome = false;
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
}

Console.WriteLine();
foreach (DictionaryEntry de in Informacoes)
{
    Console.WriteLine("{0}:{1}", de.Key, de.Value);
}