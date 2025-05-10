using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dicionário com o faturamento por estado
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        // Calcula o total do faturamento
        double total = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            total += valor;
        }

        // Exibe os percentuais
        Console.WriteLine("Percentual de representação por estado:\n");
        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
