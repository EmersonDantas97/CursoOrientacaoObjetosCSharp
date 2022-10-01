
using System;

class Pessoa 
{
    // Atributos
    public double peso, altura;

    // Metodo
    public double calculo()
    {
        return peso/(altura * altura);
    }

    public string situacao(double IMC)
    {
        // Variavel
        string retorno;

        // Condicionais
        if(IMC < 18.5)
        {
            retorno =  "Abaixo do peso.";
        }
        else if(IMC < 25)
        {
            retorno =  "Peso normal.";
        }
        else if(IMC < 30)
        {
            retorno =  "Acima do peso.";
        }
        else if(IMC < 35)
        {
            retorno =  "Obesidade I.";
        }
        else if(IMC < 40)
        {
            retorno =  "Obesidade II.";
        }
        else
        {
            retorno =  "Obesidade III.";
        }  

        return retorno;
                           
    }

    public void mensagem()
    {
        // Obter calculo
        double obterCalculo = calculo();

        // Obter situacao
        string obterSituacao = situacao(obterCalculo);

        // Retornando mensagem 
        Console.WriteLine("Seu IMC é de: " + obterCalculo + ".");
        Console.WriteLine("Sua situação é: " + obterSituacao + ".");

    }
}

/*
Exercicio
    01. Criar uma pasta chamada 04Exercicio
    02. Acessar a pasta
    03. Criar um projeto via terminal: dotnet new console
    04. Criar uma classe chamada pessoa
    05. Na classe pessoa, adicionar os atributos: peso e altura
    06. Criar um metodo para retornar o IMC, sera um metodo double com o calculo: peso / (altura * altura)
    07. Criar um metodo para retornar o IMC, sera um metodo double
        < 18.5 - Abaixo do peso
        < 25 - Peso normal
        < 30 - Acima do peso
        < 35 - Obesidade I
        < 40 - Obesidade II
        >= 40 - Obesidade III
    08. Criar um metodo de mensagem para exibir o calculo e a situacao 
    09. Instanciar um objeto na classe Program
*/

