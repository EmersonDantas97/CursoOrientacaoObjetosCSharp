using System;

class Colaborador : Pessoa /* Fazendo henrança */
{

    // Atributos
    private double salario;

    // Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Metodo
    private void mensagemColaborador()
    {
        Console.WriteLine($"Salario: {salario}.");
    }
}