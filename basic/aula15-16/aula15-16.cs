using System;
// Utilizando switch e goto

class Aula15 {

    static void Main(){
        inicio:

        string veiculo;
        char choose;

        Console.WriteLine("Veículo para viajar: carro 1, bode 2, jumento 3");
        Console.Write("Digite uma escolha válida: ");
                
        choose = char.Parse(Console.ReadLine());

        switch (choose) {
            case '1':
                veiculo = "Carro";
                break;
            case '2':
                veiculo = "Bode";
                break;
            case '3':
                veiculo = "Jumento";
                break;
            default:
                Console.Clear();
                goto inicio;
        }
        if ((int)choose > 0 | (int)choose < 3){
            Console.WriteLine("\nVeículo escolhido: {0}.", veiculo);
        }
    }
}