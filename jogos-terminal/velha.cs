using System;

class JogoDaVelha {
    static char[,,] velha = new char[3, 3, 3];  // Criação do array 3D

    static void ExibirTabuleiro() {
        for (int linha = 0; linha < 3; linha++) {
            for (int coluna = 0; coluna < 3; coluna++) {
                char simbolo = velha[coluna, linha, 0];
                Console.Write($"| {(simbolo == '\0' ? ' ' : simbolo)} ");  // Substitui '\0' por espaço vazio
            }
            Console.WriteLine("|");  // Finaliza a linha
            Console.WriteLine("-------------");  // Linha divisória
        }
    }
    static void Main() {
        int jogada = 1;  // Inicializa a variável de contagem de jogadas
    
        while (jogada <= 9) {
            // Alterna entre 'X' e 'O'
            char simbolo = (jogada % 2 == 0) ? 'O' : 'X';
            
            input:
            
            try {
                Console.WriteLine($"Jogador {simbolo}. Onde deseja jogar? Coluna: ");
                int coluna = Convert.ToInt32(Console.ReadLine());
    
                Console.WriteLine($"Jogador {simbolo}. Onde deseja jogar? Linha: ");
                int linha = Convert.ToInt32(Console.ReadLine());
    
                // Verifica se as coordenadas estão dentro do intervalo válido
                if (coluna < 1 || coluna > 3 || linha < 1 || linha > 3) {
                    Console.WriteLine("Coordenadas inválidas! Tente novamente.");
                    goto input;
                }
    
    
                if (velha[coluna - 1, linha - 1, 0] != '\0') {
                    Console.WriteLine("Posição já preenchida.");
                    goto input;
                }
    
                velha[coluna - 1, linha - 1, 0] = simbolo;
    
                jogada++;

                Console.Clear();
                
                ExibirTabuleiro();
            } catch (Exception) {
                Console.WriteLine("Por favor. Digite apenas números inteiros.");
                goto input;
            }
        }
    }
}