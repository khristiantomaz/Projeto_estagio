using System;
/*
Teste de numero 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
*/
class Program
{
    // Aqui fazemos o calculo de para gerar o percentual de todos os estados 
    static void Main()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        Console.WriteLine($"Percentual de SP: {sp / total * 100:F2}%");
        Console.WriteLine($"Percentual de RJ: {rj / total * 100:F2}%");
        Console.WriteLine($"Percentual de MG: {mg / total * 100:F2}%");
        Console.WriteLine($"Percentual de ES: {es / total * 100:F2}%");
        Console.WriteLine($"Percentual de Outros: {outros / total * 100:F2}%");
    }
}
