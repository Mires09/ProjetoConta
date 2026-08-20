class Corrente : Conta
{
    public decimal limite;

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