using System;

namespace _99Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando objeto
            Pessoa p = new Pessoa();
            p.nome = "Emerson";
            p.idade = 25;
            p.EstadoCivil = "Casado";
            p.mensagem();
        }
    }
}
