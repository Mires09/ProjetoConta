using System;

class Program
{
    static void Main()
    {
        // 2 objetos da classe Corrente
        Corrente conta1 = new Corrente();
        Corrente conta2 = new Corrente();

        // 2 objetos da classe Caixinha
        Caixinha caixinha1 = new Caixinha();
        Caixinha caixinha2 = new Caixinha();

        // Conta 1
        conta1.nome = "João";
        conta1.numero = "001";
        conta1.limite = 1000;
        conta1.Deposita(1000);

        // Conta 2
        conta2.nome = "Maria";
        conta2.numero = "002";
        conta2.limite = 1000;
        conta2.Deposita(2000);

        // Caixinha 1
        caixinha1.nome = "Pedro";
        caixinha1.numero = "003";
        caixinha1.lucro = 100;
        caixinha1.Deposita(500);

        // Caixinha 2
        caixinha2.nome = "Ana";
        caixinha2.numero = "004";
        caixinha2.lucro = 200;
        caixinha2.Deposita(800);

        // Mostrar as contas
        Console.WriteLine("CONTAS");

        conta1.MostrarSaldo();
        Console.WriteLine();

        conta2.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();
        Console.WriteLine();

        caixinha2.MostrarSaldo();
        Console.WriteLine();

        // Saque
        Console.WriteLine("SAQUE");

        if (conta1.Saca(200))
        {
            Console.WriteLine("Saque realizado!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }

        // Transferência
        Console.WriteLine();
        Console.WriteLine("TRANSFERÊNCIA");

        if (conta1.Transfere(300, caixinha1))
        {
            Console.WriteLine("Transferência realizada!");
        }
        else
        {
            Console.WriteLine("Transferência não realizada!");
        }

        // Saldos finais
        Console.WriteLine();
        Console.WriteLine("SALDOS FINAIS");

        conta1.MostrarSaldo();

        Console.WriteLine();

        caixinha1.MostrarSaldo();

        Console.ReadKey();
    }
}