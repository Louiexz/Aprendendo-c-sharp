using System;
// Utilizando bitwise e conversão de inputs
class Welcome
{
    static void Main(string[] args)    {
        int numOne, numTwo;
        byte numByteAusiEsquerda, numByteAusiDireita;

        try
        {
            Console.WriteLine("Digite um número: ");
            numOne = int.Parse(Console.ReadLine());
            numByteAusiEsquerda = (byte)(numOne << 1);
        
            Console.WriteLine("Digite outro número: ");
            numTwo = int.Parse(Console.ReadLine());
            numByteAusiDireita = (byte)(numTwo >> 1);
        
            Console.WriteLine("Entrada: {0}, ByteAusiEsquerda '{1}' para (binário): {2}", numOne, numOne * 2, Convert.ToString(numByteAusiEsquerda, 2).PadLeft(8, '0'));
            Console.WriteLine("Entrada: {0}, ByteAusiDireita '{1}' para (binário): {2}", numTwo, numTwo / 2, Convert.ToString(numByteAusiDireita, 2).PadLeft(8, '0'));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de digitar um número inteiro entre 0 e 255.");
        }
    }
}
