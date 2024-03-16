using System;
using System.Security.Principal;

namespace MyFinances
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Principal();
        }

        public static void Principal()
        {
        // Variáveis
        decimal aluguel = 800.00m;
        decimal internet = 99.00m;
        decimal luz = 0.00m;
        decimal cursoProgramacao = 0.00m;
        decimal faculdade = 150.00m;
        decimal nubank = 0.00m;
        decimal neon = 0.00m;
        decimal inter = 0.00m;
        decimal telefone = 0.00m;
        decimal estetica = 0.00m;
        decimal entretenimento = 0.00m;

        decimal somaGastos = aluguel + internet + luz + cursoProgramacao + faculdade + nubank + neon + inter + telefone + estetica + entretenimento;

        decimal rendaMensal = 1000.00m;
        decimal rendaExtra = 0.00m;
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
        Console.ReadKey(); 
        }
    }
}

