using System;

// Delegate: Variáveis referenciando métodos
// Passagem de argumentos na execução do programa
// Exceções
// Uso do namespace

namespace Mat{
    delegate double Op(params double[] valores);

    class Operacoes{

        public static double soma(params double[] valores){
            double res = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                res += valores[i];
            }
            return res;
        }
    }
}

namespace MatTwo{
    delegate double Op(params double[] valores);

    class Operacoes{

        public static double soma(params double[] valores){
            double res = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                res += valores[i];
            }
            return res;
        }
    }
}

class Aula50{
    static void Main(string[] args){
        try{
            Mat.Op soma = new Mat.Op(Mat.Operacoes.soma);

            Console.WriteLine(soma(7, 7));
        } catch(Exception) {
            Console.WriteLine("\nError");
        } finally {
            Console.WriteLine("\nThank you!");
        }
    }
}
