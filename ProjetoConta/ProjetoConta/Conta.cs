using System;

class Conta
{
    public string nome;
    public string numero;
    private decimal saldo;

    public bool Saca(decimal valor)
    {
        if (valor <= saldo)
        {
            saldo = saldo - valor;
            return true;
        }

        return false;
    }

    public void Deposita(decimal valor)
    {
        saldo = saldo + valor;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Número: " + numero);
        Console.WriteLine("Saldo: R$ " + saldo);
    }

    public bool Transfere(decimal valor, Conta conta)
    {
        if (Saca(valor))
        {
            conta.Deposita(valor);
            return true;
        }

        return false;
    }
}