using SistemaBancario_uvv.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBancarioUVV.Controllers
{
    public class ClienteController
    {
        public List<Cliente> clientes { get; private set; } = new List<Cliente>();

        public void CadastrarCliente(string nome, string cpf, string endereco)
        {
            var cliente = new Cliente { Nome = nome, CPF = cpf, Endereco = endereco };
            clientes.Add(cliente);
        }

        public Cliente BuscarClientePorCPF(string cpf)
        {
            return clientes.FirstOrDefault(c => c.CPF == cpf);
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }

        public Conta BuscarContaPorNumero(string numero)
        {
            foreach (var cliente in clientes)
            {
                var conta = cliente.Contas.FirstOrDefault(c => c.Numero == numero);
                if (conta != null)
                {
                    return conta;
                }
            }
            return null;
        }
    }
}
