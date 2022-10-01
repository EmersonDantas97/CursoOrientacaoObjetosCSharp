using System;

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2;

    /* Metodos */
    // Media
    public double media()
    {
        return(nota1+nota2)/2;
    }

    // Situacao
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado"; // Poderia neste caso ter utilizado o comando if, mas podemos também utilizar os operadores ternarios para o codigo ficar mais enxuto
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a media
        double obtermedia = media();

        // Obter a situacao
           string obterSituacao = situacao(obtermedia);

        // Mensagem
        Console.WriteLine(nome + " está " + obterSituacao + " com media " + obtermedia + ".");
    }

}