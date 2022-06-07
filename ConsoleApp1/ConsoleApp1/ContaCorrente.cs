

using ByteBank.titular;

namespace ByteBank;

public class ContaCorrente
{
    public Cliente titular;
    public string titular_cpf;
    public string titular_profissao;
    public string conta;
    public int numero_agencia;
    public string nome_agencia;
    public double saldo;

    public bool sacar(double valor)
    {
        if (saldo < valor)
        {
            return false;
        }
        if (valor < 0)
        {
            return false;

        }

        else
        {
            saldo = saldo - valor;
            return true;
        }


    }

public void Depositar(double valor)
    {
        saldo = saldo + valor;
 
   }

public bool transferir (double valor , ContaCorrente destino)
    {
        if(saldo < valor)
        {
            return false;
        }if(valor < 0)
        {
            return false;
        }
        else
        {
            saldo = saldo - valor;
            destino.saldo = destino.saldo + valor;
            return true;
        }
    }
}




