﻿namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
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
    }
}