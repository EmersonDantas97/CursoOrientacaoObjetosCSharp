using System;

class Pessoa
{
    // Atributos
    protected string nome;
    protected int idade;

    // Metodo
    protected void mensagemPessoa()
    {
        Console.WriteLine($"Nome: {nome}.");
        Console.WriteLine($"Idade: {idade}.");
    }
}