using System;

namespace MyFinances
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        // Variáveis
        decimal rendaMensal = 0;
        decimal rendaExtra = 0;
        decimal rendaTotal = 0;
        decimal valorRestante = 0;
        decimal aluguel = 0;
        decimal internet = 0;
        decimal luz = 0;
        decimal cursoProgramacao = 0;
        decimal faculdade = 0;
        decimal nubank = 0;
        decimal neon = 0;
        decimal inter = 0;
        decimal telefone = 0;
        decimal estetica = 0;
        decimal entretenimento = 0;

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

