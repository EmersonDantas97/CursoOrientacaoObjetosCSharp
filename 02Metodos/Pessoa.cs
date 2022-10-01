using System;

class Pessoa
{
    // Metodo 01
    public void apresentar()
    {
        Console.WriteLine("Ola!!!");
    }

    // Metodo 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }

    // Metodo 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + " você tem " + idade + " anos.");
    }

}

/* 
Boas praticas:
- Nome das class sempre comecar com letra maiuscula.
- class sempre tem que ter o nome do arquivo.

Obsservacoes: 
- Eu posso ter varios metodos com o mesmo nome, so que eles tem que ter parametros diferentes.

*/