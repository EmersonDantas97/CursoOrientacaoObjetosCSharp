using System;

class Exemplo
{
    /*Quando coloco o atributo static, no arquivo program, não preciso instanciar o objeto*/

    public static string nome = "Emerson"; 

    public static void soma(int n1, int n2)
    {
        Console.WriteLine(n1+n2);
    }

}