using System.Security.Cryptography;
using System;

/* teste de numero 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE ) 
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        // resultado da SOMA + K seria de 91
        System.Console.WriteLine(SOMA);
    }
}