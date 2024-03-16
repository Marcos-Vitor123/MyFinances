using System;
using System.IO;

namespace MyFinances
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Criar();
        }

        public static void Criar()
        {
        // Variáveis
        Console.Write("Aluguel: ");
        decimal aluguel = decimal.Parse(Console.ReadLine());
        Console.Write("Internet: ");
        decimal internet = decimal.Parse(Console.ReadLine());
        Console.Write("Luz: "); 
        decimal luz = decimal.Parse(Console.ReadLine());
        Console.Write("Rockeseat: ");
        decimal cursoProgramacao = decimal.Parse(Console.ReadLine());
        Console.Write("Ampli: ");
        decimal faculdade = decimal.Parse(Console.ReadLine());
        Console.Write("Nubank: ");
        decimal nubank = decimal.Parse(Console.ReadLine());
        Console.Write("Neon: ");
        decimal neon = decimal.Parse(Console.ReadLine());
        Console.Write("Inter: ");
        decimal inter = decimal.Parse(Console.ReadLine());
        Console.Write("Telefone: ");
        decimal telefone = decimal.Parse(Console.ReadLine());
        Console.Write("Corte de Cabelo: ");
        decimal estetica = decimal.Parse(Console.ReadLine());
        Console.Write("Amazon: ");
        decimal entretenimento = decimal.Parse(Console.ReadLine());

        decimal somaGastos = aluguel + internet + luz + cursoProgramacao + faculdade + nubank + neon + inter + telefone + estetica + entretenimento;

        Console.Write("Qual sua Renda Mensal? ");
        decimal rendaMensal = decimal.Parse(Console.ReadLine());
        Console.Write("Qual a Renda Extra? ");
        decimal rendaExtra = decimal.Parse(Console.ReadLine());
        decimal rendaTotal = rendaMensal + rendaExtra;
        decimal valorRestante = rendaTotal - somaGastos;

        // Impressões na tela

        Console.Clear();
        Console.WriteLine("\n\tMinhas Finanças\t\n");

        Console.WriteLine("\tRenda Mensal\t\n");

        Console.WriteLine($"Renda Mensal: \t\t{rendaMensal}");
        Console.WriteLine($"Renda Extra: \t\t{rendaExtra}");
        Console.WriteLine($"Renda Total: \t\t{rendaTotal}\n");

        Console.WriteLine("\tGastos Mensal\t\n");

        Console.WriteLine($"Aluguel: \t\t{aluguel}");
        Console.WriteLine($"Internet: \t\t{internet}");
        Console.WriteLine($"Luz: \t\t\t{luz}");
        Console.WriteLine($"Rocketseat: \t\t{cursoProgramacao}");
        Console.WriteLine($"Ampli: \t\t\t{faculdade}");
        Console.WriteLine($"Nubank: \t\t{nubank}");
        Console.WriteLine($"Neon: \t\t\t{neon}");
        Console.WriteLine($"Inter: \t\t\t{inter}");
        Console.WriteLine($"Celular: \t\t{telefone}");
        Console.WriteLine($"Corte Cabelo: \t\t{estetica}");
        Console.WriteLine($"Amazon: \t\t{entretenimento}\n");

        Console.WriteLine($"Valor Restante: \t{valorRestante}\n");
    
        string[] linhas = 
        [
            "\n\tMinhas Finanças\t\n",

            "\tRenda Mensal\t\n",

            $"Renda Mensal: \t\t{rendaMensal}", 
            $"Renda Extra: \t\t{rendaExtra}",
            $"Renda Total: \t\t{rendaTotal}\n",

            "\tGastos Mensal\t\n",

            $"Aluguel: \t\t{aluguel}",
            $"Internet: \t\t{internet}",
            $"Luz: \t\t\t{luz}",
            $"Rocketseat: \t\t{cursoProgramacao}",
            $"Ampli: \t\t\t{faculdade}",
            $"Nubank: \t\t{nubank}",
            $"Neon: \t\t\t{neon}",
            $"Inter: \t\t\t{inter}",
            $"Celular: \t\t{telefone}",
            $"Corte Cabelo: \t\t{estetica}",
            $"Amazon: \t\t{entretenimento}\n",

            $"Valor Restante: \t{valorRestante}\n"
        ];

        Console.WriteLine("Deseja salvar o arquivo?\n");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Salvar\n");
        Console.Write("Escolha a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                string caminhoDiretorio = @"D:\";

                using (StreamWriter saidaArquivo = new StreamWriter(Path.Combine(caminhoDiretorio, "Minhas Finanças.txt")))
                {
                    foreach (string linha in linhas)
                        saidaArquivo.WriteLine(linha);
                }
                Console.WriteLine("\nArquivo salvo com sucesso!");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
            }
            Console.ReadKey();
        }

    }
}

