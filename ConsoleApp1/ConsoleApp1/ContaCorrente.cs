﻿using ByteBank.titular;
namespace ByteBank;

public class ContaCorrente
{
    public Cliente Titular { get; set; }
  
    public string conta { get; set; }

    public int numero_agencia { get; set; }

    public string nome_agencia { get; set; }

    private double saldo { get; set; }

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

    //public void setSaldo(double valor)
    //{
    //    if (valor < 0)
    //    {
    //        return;
    //    }
    //    else
    //    {
    //        saldo = saldo + valor;
    //    }
    //}

    //public double getSaldo()
    //{
    //    return saldo;
    //}

    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            } saldo = value;
        }
    }

}




