using System;
using System.IO;

namespace MyFinances
{
    internal class Program
    {
        public static decimal aluguel;
        public static decimal internet;
        public static decimal luz;
        public static decimal cursoProgramacao;
        public static decimal faculdade;
        public static decimal nubank;
        public static decimal neon;
        public static decimal inter;
        public static decimal telefone;
        public static decimal estetica;
        public static decimal entretenimento;
        public static decimal somaGastos;
        public static decimal rendaMensal;
        public static decimal rendaExtra;
        public static decimal rendaTotal;
        public static decimal valorRestante;


        private static void Main(string[] args)
        {
            Criar();
            Menu();
        }
        public static void Criar()
        {
            Console.Write("Aluguel: ");
            aluguel = decimal.Parse(Console.ReadLine());
            Console.Write("Internet: ");
            internet = decimal.Parse(Console.ReadLine());
            Console.Write("Luz: "); 
            luz = decimal.Parse(Console.ReadLine());
            Console.Write("Rockeseat: ");
            cursoProgramacao = decimal.Parse(Console.ReadLine());
            Console.Write("Ampli: ");
            faculdade = decimal.Parse(Console.ReadLine());
            Console.Write("Nubank: ");
            nubank = decimal.Parse(Console.ReadLine());
            Console.Write("Neon: ");
            neon = decimal.Parse(Console.ReadLine());
            Console.Write("Inter: ");
            inter = decimal.Parse(Console.ReadLine());
            Console.Write("Telefone: ");
            telefone = decimal.Parse(Console.ReadLine());
            Console.Write("Corte de Cabelo: ");
            estetica = decimal.Parse(Console.ReadLine());
            Console.Write("Amazon: ");
            entretenimento = decimal.Parse(Console.ReadLine());

            somaGastos = aluguel + internet + luz + cursoProgramacao + faculdade + nubank + neon + inter + telefone + estetica + entretenimento;
            

            Console.Write("Qual sua Renda Mensal? ");
            rendaMensal = decimal.Parse(Console.ReadLine());
            Console.Write("Qual a Renda Extra? ");
            rendaExtra = decimal.Parse(Console.ReadLine());
            rendaTotal = rendaMensal + rendaExtra;
            valorRestante = rendaTotal - somaGastos;

            Salvar(aluguel, internet, luz, cursoProgramacao, faculdade, nubank, neon, inter, telefone, estetica, entretenimento, somaGastos, rendaMensal, rendaExtra, rendaTotal, valorRestante);
            
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
            //*****************************************
            Menu();
            //*************************************************
            Console.ReadKey();
        }
        
        public static void Menu()
        {
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
                    Salvar(aluguel, internet, luz, cursoProgramacao, faculdade, nubank, neon, inter, telefone, estetica, entretenimento, somaGastos, rendaMensal, rendaExtra, rendaTotal, valorRestante);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        public static void Salvar(decimal aluguel, decimal internet, decimal luz, decimal cursoProgramacao, decimal faculdade, decimal nubank,  decimal neon, decimal inter, decimal telefone, decimal estetica, decimal entretenimento, decimal somaGastos, decimal rendaMensal, decimal rendaExtra, decimal rendaTotal, decimal valorRestante)
        {
            // Salva no arquivo
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

            string caminhoDiretorio = @".\";

            using (StreamWriter saidaArquivo = new StreamWriter(Path.Combine(caminhoDiretorio, "Minhas Finanças.txt")))
            {
                foreach (string linha in linhas)
                    saidaArquivo.WriteLine(linha);
            }
            Console.WriteLine("\nArquivo salvo com sucesso!");
        }

    }
}

