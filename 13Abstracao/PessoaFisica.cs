using System;

class PessoaFisica : Padrao
{
    // Metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de emprestimo para pessoa física R$ {valor*0.1}.");
    }
}