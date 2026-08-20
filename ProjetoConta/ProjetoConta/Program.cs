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


        // Dados das contas

        conta1.nome = "João";
        conta1.numero = "001";
        conta1.limite = 1000;
        conta1.Deposita(1000);

        conta2.nome = "Maria";
        conta2.numero = "002";
        conta2.limite = 1000;
        conta2.Deposita(2000);

        caixinha1.nome = "Pedro";
        caixinha1.numero = "003";
        caixinha1.lucro = 100;
        caixinha1.Deposita(500);

        caixinha2.nome = "Ana";
        caixinha2.numero = "004";
        caixinha2.lucro = 200;
        caixinha2.Deposita(800);


        // Saldos Iniciais

        Console.WriteLine("--- Saldos Iniciais ---");
        Console.WriteLine();

        conta1.MostrarSaldo();
        Console.WriteLine();

        conta2.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();
        Console.WriteLine();

        caixinha2.MostrarSaldo();


        // Saque

        Console.WriteLine();
        Console.WriteLine("--- Saque ---");
        Console.WriteLine();

        decimal valorSaque = 200;

        if (conta1.Saca(valorSaque))
        {
            Console.WriteLine("Conta: " + conta1.numero);
            Console.WriteLine("Nome: " + conta1.nome);
            Console.WriteLine("Valor sacado: R$ " + valorSaque);
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine();

            Console.WriteLine("Saldo após o saque:");
            conta1.MostrarSaldo();
        }
        else
        {
            Console.WriteLine("Não foi possível realizar o saque.");
        }


        // Saque com erro

        Console.WriteLine();
        Console.WriteLine("--- Saque com erro ---");
        Console.WriteLine();

        decimal saqueErro = 1000;

        if (conta1.Saca(saqueErro))
        {
            Console.WriteLine("Saque realizado!");
        }
        else
        {
            Console.WriteLine("Não foi possível realizar o saque.");
            Console.WriteLine("Saldo insuficiente para sacar R$ " + saqueErro);
        }

        Console.WriteLine();
        Console.WriteLine("Saldo da conta:");
        conta1.MostrarSaldo();


        // Transferência

        Console.WriteLine();
        Console.WriteLine("--- Transferência ---");
        Console.WriteLine();

        decimal valorTransferencia = 300;

        if (conta1.Transfere(valorTransferencia, caixinha1))
        {
            Console.WriteLine("Origem:");
            Console.WriteLine("Nome: " + conta1.nome);
            Console.WriteLine("Conta: " + conta1.numero);

            Console.WriteLine();

            Console.WriteLine("Destino:");
            Console.WriteLine("Nome: " + caixinha1.nome);
            Console.WriteLine("Conta: " + caixinha1.numero);

            Console.WriteLine();

            Console.WriteLine("Valor transferido: R$ " + valorTransferencia);
            Console.WriteLine("Transferência realizada com sucesso!");

            Console.WriteLine();

            Console.WriteLine("Saldo da conta de origem:");
            conta1.MostrarSaldo();

            Console.WriteLine();

            Console.WriteLine("Saldo da conta de destino:");
            caixinha1.MostrarSaldo();
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a transferência.");
        }

        // TRANSFERÊNCIA COM ERRO

        Console.WriteLine();
        Console.WriteLine("--- Transferência com erro");
        Console.WriteLine();

        decimal transferenciaErro = 1000;

        if (conta1.Transfere(transferenciaErro, caixinha1))
        {
            Console.WriteLine("Transferência realizada!");
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a transferência.");
            Console.WriteLine("Saldo insuficiente para transferir R$ " + transferenciaErro);
        }

        Console.WriteLine();
        Console.WriteLine("Saldo da conta de origem:");
        conta1.MostrarSaldo();

        Console.WriteLine();
        Console.WriteLine("Saldo da conta de destino:");
        caixinha1.MostrarSaldo();

        // Saldos Finais

        Console.WriteLine();
        Console.WriteLine("--- Saldos Finais ---");
        Console.WriteLine();

        conta1.MostrarSaldo();
        Console.WriteLine();

        conta2.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();
        Console.WriteLine();

        caixinha2.MostrarSaldo();
    }
}