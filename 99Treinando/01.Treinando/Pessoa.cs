using System;

class Pessoa
{
    // Atributos
    public string nome;
    public int idade;
    public string EstadoCivil;

    public void mensagem()
    {
        Console.WriteLine($"Meu nome é {nome}, tenho {idade} de idade e sou {EstadoCivil}.");
    }

}