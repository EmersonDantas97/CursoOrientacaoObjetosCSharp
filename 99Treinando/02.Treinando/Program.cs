using System;

namespace _02.Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC obj = new IMC();
            obj.peso = 75.7;
            obj.altura = 1.68;
            obj.nome = 'Emerson';
            obj.mensagem();
        }
    }
}
