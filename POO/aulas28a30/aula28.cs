using System;

class Pessoa{
    // Uso classes, construtores e sua sobrecarga
    protected string nome;
    private string senha;

    public Pessoa(){}

    public Pessoa(string n, string s){
        nome = n;
        senha = s;
    }

    public void setNome(string n){
        nome = n;
    }
    public void setSenha(string s){
        senha = s;
    }
    public string getName(){
        return nome;
    }
    public string getSenha(){
        return nome;
    }
    public string toString(){
        return $"Seu nome: {nome},\nSua senha: {senha}";
    }
}

class AulasVinteOitoTrinta{
    static void Main(){
        Pessoa luiz = new Pessoa("Luiz", "234!321a");
        Console.WriteLine(luiz.toString());

        Pessoa ana = new Pessoa();
        ana.setNome("Ana");
        ana.setSenha("zeze1!As");
        Console.WriteLine("\nNome: {0}", ana.getName());
    }
}