using System;

// Métodos: Recursividade, static
// Variáveis: static

class Mat{
    public static int num = 8;

    public static int fatorial(int num, int res=1) {
        if (num == 1) {
            return res;
        }
        
        res *= num;
        
        num--;
        
        return fatorial(num, res);
    }
}

class Aula48{
    static void Main(){
        int num = Mat.num;
        Console.WriteLine($"O fatorial de {num} é: {Mat.fatorial(Mat.num)}");
    }
}