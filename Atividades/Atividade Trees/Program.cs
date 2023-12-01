public class Empregado {
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public List<Empregado> Subordinados { get; set; }
}

class Program {
    static void Main() {
        Empregado diretor = new Empregado {
            Nome = "Seu Nelson",
            Cargo = "Diretor",
            Subordinados = new List<Empregado> {
                new Empregado {
                    Nome = "Guilherme S.",
                    Cargo = "Faxineiro"
                },
                new Empregado {
                    Nome = "Gustavo P.",
                    Cargo = "Encanador"
                }
            }
        };
        MostrarHierarquiua(diretor, 0);
    }

    static void MostrarHierarquiua(Empregado empregado, int altura) {
        Console.WriteLine($"{new string(' ', altura * 2)}{empregado.Nome} - {empregado.Cargo}");
        if (empregado.Subordinados != null) {
            foreach (var subordinado in empregado.Subordinados) {
                MostrarHierarquiua(subordinado, altura + 1);
            }
        }
    }
}