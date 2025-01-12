using System;

class Aula27 {


    static float multiplicacao( out int quantidade, params float[] nums) {
        float res = nums[0];
        quantidade = nums.Length;

        for (int n = 1; n < nums.Length; n++){
            res *= nums[n];
        }
        return res;
    }
    
    static float divisao(out int quantidade, params float[] nums) {
        float res = nums[0];
        quantidade = nums.Length;

        for(int n = 1; n < nums.Length; n++){
            res /= nums[n];
        }

        return res;
    }

    static void Main(){
        int qt, qtTwo;
        float res_mult = multiplicacao(out qt, 5, 6, 7, 7);
        float res_div = divisao(out qtTwo, 5, 2);
        
        Console.WriteLine($"Quantidade de números: {qt},\nResultado multiplição: {res_mult}");
        Console.WriteLine($"\nQuantidade de números: {qtTwo},\nResultado divisão: {res_div}");
    }
}