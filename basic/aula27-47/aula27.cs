using System;

// Parametros (params)
// Métodos: Sobrecarga usar (params)

class Aulas27A47 {
    static double multiplicacao( out int quantidade, params double[] nums) {
        double res = nums[0];
        quantidade = nums.Length;

        for (int n = 1; n < nums.Length; n++){
            res *= nums[n];
        }
        return res;
    }
    
    static double divisao(out int quantidade, params double[] nums) {
        double res = nums[0];
        quantidade = nums.Length;

        for(int n = 1; n < nums.Length; n++){
            res /= nums[n];
        }

        return res;
    }

    static void Main(){
        int qt, qtTwo;
        var res_mult = multiplicacao(out qt, 5, 6.6, 7.5, 7.8);

        var res_div = divisao(out qtTwo, 5.5, 2);
        
        Console.WriteLine($"Quantidade de números: {qt},\nResultado multiplição: {res_mult}");
        Console.WriteLine($"\nQuantidade de números: {qtTwo},\nResultado divisão: {res_div}");
    }
}