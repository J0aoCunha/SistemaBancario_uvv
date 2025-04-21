using SistemaBancario_uvv.Models;
using SistemaBancarioUVV.Controllers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBancario_uvv
{
    public partial class Form1 : Form
    {
        private ClienteController clienteController = new ClienteController();
        private ContaController contaController = new ContaController();

        private Cliente clienteAtual;
        private Conta contaAtual;

        public Form1()
        {
            InitializeComponent();

            // Associar eventos TextChanged
            txtCPF.TextChanged += TxtCPF_TextChanged;
            txt_NumeroConta.TextChanged += TxtNumeroConta_TextChanged;

            // Configurar bot�es
            btnCadastrarCliente.Click += BtnCadastrarCliente_Click;
            btnCriarConta.Click += BtnCriarConta_Click;
            btnDepositar.Click += BtnDepositar_Click;
            btnSacar.Click += BtnSacar_Click;
            btnTransferir.Click += BtnTransferir_Click;
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            clienteAtual = clienteController.BuscarClientePorCPF(cpf);

            if (clienteAtual != null)
            {
                lblClienteInfo.Text = $"Cliente: {clienteAtual.Nome}, Endere�o: {clienteAtual.Endereco}";
            }
            else
            {
                lblClienteInfo.Text = "Cliente n�o encontrado.";
            }
        }

        private void TxtNumeroConta_TextChanged(object sender, EventArgs e)
        {
            string numeroConta = txt_NumeroConta.Text;
            contaAtual = clienteController.BuscarContaPorNumero(numeroConta);

            if (contaAtual != null)
            {
                lblSaldoAtual.Text = $"R$ {contaAtual.Saldo:0.00}";
            }
            else
            {
                lblSaldoAtual.Text = "Conta n�o encontrada.";
            }
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string endereco = txtEndereco.Text;

            clienteController.CadastrarCliente(nome, cpf, endereco);
            MessageBox.Show("Cliente cadastrado com sucesso!");

            // Atualizar clienteAtual ap�s o cadastro
            clienteAtual = clienteController.BuscarClientePorCPF(cpf);

            if (clienteAtual != null)
            {
                lblClienteInfo.Text = $"Cliente: {clienteAtual.Nome}, Endere�o: {clienteAtual.Endereco}";
            }
        }

        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            if (clienteAtual == null)
            {
                MessageBox.Show("Selecione um cliente v�lido.");
                return;
            }

            string numeroConta = text.Text;
            double taxa = double.Parse(txtTaxa.Text);

            contaController.CriarContaCorrente(clienteAtual, numeroConta, taxa);

            MessageBox.Show("Conta criada com sucesso!");
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Selecione uma conta v�lida.");
                return;
            }

            double valor = double.Parse(txtValor.Text);
            contaController.Depositar(contaAtual, valor);

            lblSaldoAtual.Text = $"R$ {contaAtual.Saldo:0.00}";
            MessageBox.Show("Dep�sito realizado com sucesso!");
        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Selecione uma conta v�lida.");
                return;
            }

            double valor = double.Parse(txtValor.Text);
            contaController.Sacar(contaAtual, valor);

            lblSaldoAtual.Text = $"R$ {contaAtual.Saldo:0.00}";
            MessageBox.Show("Saque realizado com sucesso!");
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Selecione uma conta de origem v�lida.");
                return;
            }

            string numeroContaDestino = txtContaDestino.Text;
            Conta contaDestino = clienteController.BuscarContaPorNumero(numeroContaDestino);

            if (contaDestino == null)
            {
                MessageBox.Show("Conta de destino n�o encontrada.");
                return;
            }

            double valor = double.Parse(txtValorTransferencia.Text);

            // Realizar a transfer�ncia
            contaController.Transferir(contaAtual, contaDestino, valor);

            // Atualizar o saldo da conta de origem na interface
            label.Text = $"R$ {contaAtual.Saldo:0.00}";

            MessageBox.Show("Transfer�ncia realizada com sucesso!");
        }

        private void txtContaDestino_TextChanged(object sender, EventArgs e)
        {
            string numeroConta = txtContaDestino.Text;
            contaAtual = clienteController.BuscarContaPorNumero(numeroConta);

            if (contaAtual != null)
            {
                label.Text = $"R$ {contaAtual.Saldo:0.00}";
            }
            else
            {
                label.Text = "Conta n�o encontrada.";
            }
        }
    }
}
