using System;
/*
 Teste de numero 5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse; 
*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();

        for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
        }

        string reversed = new string(charArray);
        Console.WriteLine($"String invertida: {reversed}");
    }
}
