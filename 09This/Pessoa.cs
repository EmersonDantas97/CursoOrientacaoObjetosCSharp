using System;

class Pessoa
{

    // Atributo
    private string nome = "Tatiana";

    // Construtor
    public Pessoa(string nome) /* colocando o parametro nome */
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // Chama o atributo e não o parametro, utilizando o comando "this".
    }

}