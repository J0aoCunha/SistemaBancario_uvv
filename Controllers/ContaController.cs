using SistemaBancario_uvv.Models;
using System;

namespace SistemaBancarioUVV.Controllers
{
    public class ContaController
    {
        public void CriarContaCorrente(Cliente cliente, string numeroConta, double taxa)
        {
            var novaConta = new Conta
            {
                Numero = numeroConta,
                Saldo = 0,
                Cliente = cliente
            };

            // Adicionar a conta à lista de contas do cliente
            cliente.Contas.Add(novaConta);
        }

        public void Depositar(Conta conta, double valor)
        {
            if (conta == null)
                throw new ArgumentNullException(nameof(conta), "Conta não pode ser nula.");

            conta.Depositar(valor);
        }

        public void Sacar(Conta conta, double valor)
        {
            if (conta == null)
                throw new ArgumentNullException(nameof(conta), "Conta não pode ser nula.");

            conta.Sacar(valor);
        }

        public void Transferir(Conta origem, Conta destino, double valor)
        {
            if (origem == null || destino == null)
            {
                throw new ArgumentNullException("As contas de origem e destino não podem ser nulas.");
            }

            if (valor <= 0)
            {
                throw new ArgumentException("O valor da transferência deve ser maior que zero.");
            }

            if (origem.Saldo < valor)
            {
                throw new InvalidOperationException("Saldo insuficiente na conta de origem.");
            }

            // Subtrair o valor da conta de origem
            origem.Saldo = origem.Saldo - valor;

            // Adicionar o valor à conta de destino
            destino.Saldo = destino.Saldo+valor;
        }

    }
}
