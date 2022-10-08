using System;

class PessoaJuridica : Padrao
{
    // Metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de emprestimo para pessoa jurídica R$ {valor*0.2}.");
    }
}