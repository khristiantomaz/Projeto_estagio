using System;
using System.Collections.Generic;
using System.IO;
// lembre-se de instalar a biblioteca do newtonsoft: dotnet add package Newtonsoft.Json
using Newtonsoft.Json;

/*
 Teste de numero 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;  
*/

class Program
{
    class Faturamento
    {
        public List<double> faturamento { get; set; }
    }

    static void Main()
    {
        // Ler o arquivo JSON
        string json = File.ReadAllText("faturamento.json");

        // Deserializar o JSON para o objeto Faturamento
        Faturamento dadosFaturamento = JsonConvert.DeserializeObject<Faturamento>(json);

        // Variáveis para armazenar o menor e maior faturamento
        double menor = double.MaxValue;
        double maior = double.MinValue;
        double soma = 0;
        int diasComFaturamento = 0;

        // Calcular menor, maior faturamento e soma dos dias com faturamento
        foreach (var valor in dadosFaturamento.faturamento)
        {
            if (valor > 0)
            {
                if (valor < menor) menor = valor;
                if (valor > maior) maior = valor;
                soma += valor;
                diasComFaturamento++;
            }
        }

        // Calcular a média
        double media = soma / diasComFaturamento;

        // Contar os dias com faturamento acima da média
        int diasAcimaDaMedia = 0;
        foreach (var valor in dadosFaturamento.faturamento)
        {
            if (valor > media)
            {
                diasAcimaDaMedia++;
            }
        }

        // Aqui exibimos os resultados 
        Console.WriteLine($"Menor faturamento: {menor:F2}");
        Console.WriteLine($"Maior faturamento: {maior:F2}");
        Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
    }
}
