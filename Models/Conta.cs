using SistemaBancario_uvv.Models;
using System;

public class Conta
{
    public string Numero { get; set; }
    public double Saldo { get; set; }
    public Cliente Cliente { get; set; }

    public virtual void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser maior que zero.");
        }

        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do saque deve ser maior que zero.");
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para o saque.");
        }

        Saldo -= valor;
    }

    public virtual void Transferir(Conta contaDestino, double valor)
    {
        if (contaDestino == null)
        {
            throw new ArgumentNullException(nameof(contaDestino), "A conta de destino não pode ser nula.");
        }
        if (valor <= 0)
        {
            throw new ArgumentException("O valor da transferência deve ser maior que zero.");
        }
        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para a transferência.");
        }
        Sacar(valor);
        contaDestino.Depositar(valor);
    }
}
