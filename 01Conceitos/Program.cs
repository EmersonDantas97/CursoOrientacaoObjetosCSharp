using System; /* importando uma funcionalidade */

namespace _01Conceitos /* é a pasta onde tem os projetos */
{
    class Program
    {
        static void Main(string[] args) /* é o arquivo principal a ser executado */
        {
            // Instanciar um objeto = criar o objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Emerson";
            obj.idade = 25;
            obj.mensagem();
        }
    }
}
