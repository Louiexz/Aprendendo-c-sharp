using System;

// Herança
// Escopo e variáveis: protected, static, private, this
// Métodos: sobrescrita e virtuais

class Pessoa { // Classe base
    protected string nome;
    private string senha;

    public Pessoa() {}

    public Pessoa(string nome) {
        this.nome = nome;
        Console.WriteLine("Classe: Base");
    }

    public Pessoa(string nome, string senha) {
        this.nome = nome;
        this.senha = senha;
    }

    public void setNome(string nome) {
        this.nome = nome;
    }

    private void setSenha(string senha) {
        this.senha = senha;
    }

    private string getSenha() {
        return this.senha;
    }

    virtual public string ToString() {
        // Usar senha apenas internamente na classe
        return $"Seu nome: {nome},\nSua senha: {senha}.";
    }
}

class Inimigo : Pessoa { // Classe filha/Herança
    static protected bool alerta = false;

    public Inimigo(string nome) : base(nome) {
        Console.WriteLine("Classe: Inimigo");
    }

    public Inimigo() {}

    public static void setAlerta(bool a) {
        alerta = a; // Acessa diretamente a variável estática
    }

    public static bool getAlerta() {
        return alerta;
    }

    public override string ToString() {
        return $"Seu nome: {nome},\nAlerta: {alerta}.";
    }
}

class Ladrao : Inimigo {
    public const string classe = "Ladrão";

    public Ladrao(string nome) : base(nome) {
        Console.WriteLine("Classe: Ladrão");
    }

    public Ladrao() {}

    public string getRoubo() {
        return "O ladrão realizou um roubo!";
    }

    public override string ToString() {
        return $"Seu nome: {nome},\nAlerta: {alerta}, \nClasse: {classe}.";
    }
}

class Aula31 {
    static void Main() {
        Pessoa luiz = new Pessoa("Luiz", "234!321a");
        Console.WriteLine(luiz.ToString());

        Ladrao pedro = new Ladrao("Pedro");
        Console.WriteLine("\n{0}", pedro.getRoubo());
        Console.WriteLine("\n{0}",  pedro.ToString());

        // Set alert as true
        Inimigo.setAlerta(true);

        Inimigo ana = new Inimigo();
        ana.setNome("Ana");
        Console.WriteLine("\n{0}", ana.ToString());

        Inimigo joao = new Inimigo("João");
        Console.WriteLine("\n{0}", joao.ToString());
    }
}
