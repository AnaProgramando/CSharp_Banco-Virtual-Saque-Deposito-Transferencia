public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numConta;
    // Valor padrão do saldo inicial da conta é de 100 e não 0
    public double saldo = 100;


    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
            this.saldo -= valor;
            return true;
    }


    //Void, pois a função não tem retorno
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
          this.saldo -= valor;
          contaDestino.Depositar(valor);
          return true;
     }
}
