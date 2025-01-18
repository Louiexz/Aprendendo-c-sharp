using System;

// Classes: sealed
// Métodos: abstratos, getters e setters

abstract class Veiculo {
    public string marca, tipo;
    public int ano, rodas;

    // Propriedade Marca
    public string Marca {
        get { return this.marca; }
        set { this.marca = value; }
    }

    // Propriedade Tipo (Agora é uma propriedade normal, e o getter é abstrato)
    public abstract string Tipo { get; set; }

    // Propriedade Ano
    public int Ano {
        get { return this.ano; }
        set { this.ano = value; }
    }

    // Propriedade Rodas (Agora é uma propriedade normal, e o getter é abstrato)
    public abstract int Rodas { get; set; }

    public override string ToString() {
        return $"{rodas}, {marca}, {tipo}, {ano}";
    }
}

sealed class Carro : Veiculo {
    public abstract string passageiros {
        get { return passageiros; }
        set { passageiros = value; }
    }

    // Implementação da propriedade Tipo
    public override string Tipo {
        get { return tipo; }
        set { tipo = value; }
    }

    // Implementação da propriedade Rodas
    public override int Rodas {
        get { return 4; } // O carro tem sempre 4 rodas
        set { rodas = value; } // Este setter pode ser utilizado se necessário, mas geralmente não é.
    }
}

class Onibus : Carro {
    public override string passageiros {
        get { return passageiros; }
        set { value >= 10 ? passageiros = value : 10; }
    }
}

class Aula39 {
    static void Main() {
        Carro car = new Carro();
        car.Marca = "Ford";
        car.Tipo = "Sedan";
        car.Ano = 2025;

        Console.WriteLine(car.ToString());
    }
}
