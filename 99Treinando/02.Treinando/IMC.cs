using System;

class IMC()
{
    // Atributos
    public string nome;
    public double peso, altura;

    // Metodos
    public double calculo()
    {
        return peso / (altura * altura);
    }

    public string aviso(double calculo)
    {
        
        string retorno;

        if (calculo < 18.5)
        {
            retorno = "Abaixo do peso.";
        } 
        else if (calculo < 25)
        {
            retorno = "Peso normal.";
        }
        else if (calculo < 30)
        {
            retorno = "Acima do peso.";
        }
        else if (calculo < 35)
        {
            retorno = "Obesidade I.";
        }
        else if (calculo < 40)
        {
            retorno = "Obesidade II.";
        }
        else if (calculo >= 40)
        {
            retorno = "Obesidade III.";
        }
        return retorno;
    }

    Public void mensagem()
    {
        Console.WriteLine($"Olá {nome}!");
        Console.WriteLine($"Sua altura é de {altura}.");
        Console.WriteLine($"Seu peso é de {peso}.");
        Console.WriteLine($"Seu IMC indica:{aviso}.");
    }

}