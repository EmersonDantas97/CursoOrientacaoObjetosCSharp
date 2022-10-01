using System; /* Futuramente será exibido msg, por isso carregar esse pacote */

class Pessoa /* C# Colocamos a chave abaixo do comando, são boas práticas */
{

    // Atributos
    public string nome; // quando utilizo o comando public, qualquer arquivo .cs terá acesso/visibilidade

    public int idade;

    // Metodos = funções
    public void mensagem() // void = nulo, quando não queremos armazenar, apenas exibir valores utilizamos este comando
    {
        Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos.");
    }



}

