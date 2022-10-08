// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lista de desconto de vale alimentação e vale transporte:");

// Instanciar estagiario
Imposto objetoE = new Estagiario();
objetoE.valeAlimentacao(1000);
objetoE.valeTransporte(1000);
Console.WriteLine("------------------------------");

// Instanciar gerente
Imposto objetoG = new Gerente();
objetoG.valeAlimentacao(5000);
objetoG.valeTransporte(5000);
Console.WriteLine("------------------------------");

// Instanciar atendente
Imposto objetoA = new Atendente();
objetoA.valeAlimentacao(2000);
objetoA.valeTransporte(2000);
Console.WriteLine("------------------------------");