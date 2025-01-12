using System;

class Advinhar {
    static int numeros;
    static int tentativa;
    
    static void Main(){
        Random random = new Random();
        
        Console.WriteLine("----- Adivinhação -----");
        
        while(true){
            try{
                Console.WriteLine("\nCom quantos números quer jogar?");
                numeros = int.Parse(Console.ReadLine());
                break;
            } catch(Exception){
                Console.WriteLine("\nDigite um número inteiro.");
            }
        }
        
        int num = random.Next(1, numeros);
        int numero_tentativas = 0;
        
        while(true){
            try{
                Console.WriteLine("\nTente acertar o número: ");
                tentativa = int.Parse(Console.ReadLine());
            } catch(Exception){
                Console.WriteLine("\nDigite um número inteiro.");
            }

            if (tentativa > num){
                Console.WriteLine("\nTente um número mais baixo.");
            } else if (tentativa < num){
                Console.WriteLine("\nTente um número mais alto.");
            } else {
                Console.WriteLine("\nVocê acertou!");
                break;
            }
            
            Console.WriteLine("\nNúmero de tentativas: {0}", numero_tentativas);
            
            numero_tentativas++;
        }
    }
}