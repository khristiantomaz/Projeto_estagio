using System;
/*
 Teste de numero 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
  escreva um programa na linguagem que desejar onde, informado um número,
   ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número:");
        int number = int.Parse(Console.ReadLine());

        int a = 0; 
        int b = 1;
        int c = 0;
        
        // Aqui fazemos o calculo aonde A e B sao os dois numeros anteriores da sequencia. 

        while (c < number)
        {
            c = a + b;
            a = b;
            b = c;
        } 
        // Aqui testamos para ver se ele se refere a numero 0 ou se C e igual a number
        if (c == number || number == 0)
            Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
    }
}