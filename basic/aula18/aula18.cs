using System;

class Aula18 {
    static char[,,] velha = new char[3, 3, 3];  // Criação do array 3D
    
    static Random random = new Random();
    
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
        int jogada = 0;  // Inicializa a variável de contagem de jogadas
    
        while (jogada < 9) {  // O jogo continua até 9 jogadas
            int coluna, linha;
            // Alterna entre 'X' e 'O'
            char simbolo = (jogada % 2 == 0) ? 'O' : 'X';
            
            while (true){
                coluna = random.Next(0, 3);
                linha = random.Next(0, 3);
    
                if (velha[coluna, linha, 0] == '\0') {
                    break;
                }
    
            }
            velha[coluna, linha, 0] = simbolo;

            Console.Clear();
            
            ExibirTabuleiro();
            
            jogada++;
        }
    }
}