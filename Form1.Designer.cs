namespace SistemaBancario_uvv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarCliente = new Button();
            btnCriarConta = new Button();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTaxa = new TextBox();
            text = new TextBox();
            label6 = new Label();
            label9 = new Label();
            txtValor = new TextBox();
            label10 = new Label();
            btnDepositar = new Button();
            lblSaldoAtual = new Label();
            btnSacar = new Button();
            lblOrigem = new Label();
            label12 = new Label();
            label13 = new Label();
            txtValorTransferencia = new TextBox();
            label14 = new Label();
            btnTransferir = new Button();
            txt_NumeroConta = new TextBox();
            label15 = new Label();
            txtContaDestino = new TextBox();
            textBox_conta_destino = new TextBox();
            ValorEmconta = new Label();
            label17 = new Label();
            lblClienteInfo = new Label();
            SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(17, 203);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(106, 30);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(17, 417);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(106, 27);
            btnCriarConta.TabIndex = 1;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(151, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(17, 116);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(151, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(17, 174);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(151, 23);
            txtEndereco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 41);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "CPf Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 156);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Cidade Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 9);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 8;
            label4.Text = "Cadastrar Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 283);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 9;
            label5.Text = "Criar conta corrente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 370);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 14;
            label7.Text = "Taxa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 313);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 13;
            label8.Text = "Numero da Conta";
            // 
            // txtTaxa
            // 
            txtTaxa.Location = new Point(17, 388);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(151, 23);
            txtTaxa.TabIndex = 11;
            // 
            // text
            // 
            text.Location = new Point(17, 331);
            text.Name = "text";
            text.Size = new Size(151, 23);
            text.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 598);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 20;
            label6.Text = "Saldo atual:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 554);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 19;
            label9.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(17, 572);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(151, 23);
            txtValor.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 473);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 16;
            label10.Text = "Operacoes bancarias";
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(17, 625);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(102, 27);
            btnDepositar.TabIndex = 15;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Location = new Point(91, 598);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(44, 15);
            lblSaldoAtual.TabIndex = 21;
            lblSaldoAtual.Text = "R$ 0,00";
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(125, 625);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(82, 27);
            btnSacar.TabIndex = 22;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(15, 702);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(96, 15);
            lblOrigem.TabIndex = 24;
            lblOrigem.Text = "Conta de origem";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 679);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 25;
            label12.Text = "Transferencia";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 779);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 27;
            label13.Text = "Conta de destino";
            // 
            // txtValorTransferencia
            // 
            txtValorTransferencia.Location = new Point(17, 854);
            txtValorTransferencia.Name = "txtValorTransferencia";
            txtValorTransferencia.Size = new Size(151, 23);
            txtValorTransferencia.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 836);
            label14.Name = "label14";
            label14.Size = new Size(120, 15);
            label14.TabIndex = 29;
            label14.Text = "Valor a ser transferido";
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(16, 894);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(136, 27);
            btnTransferir.TabIndex = 30;
            btnTransferir.Text = "Realiza a transferência\n";
            btnTransferir.UseVisualStyleBackColor = true;
            // 
            // txt_NumeroConta
            // 
            txt_NumeroConta.Location = new Point(17, 519);
            txt_NumeroConta.Name = "txt_NumeroConta";
            txt_NumeroConta.Size = new Size(152, 23);
            txt_NumeroConta.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 501);
            label15.Name = "label15";
            label15.Size = new Size(141, 15);
            label15.TabIndex = 32;
            label15.Text = "digite o numero da conta";
            // 
            // txtContaDestino
            // 
            txtContaDestino.Location = new Point(17, 720);
            txtContaDestino.Name = "txtContaDestino";
            txtContaDestino.Size = new Size(139, 23);
            txtContaDestino.TabIndex = 33;
            txtContaDestino.TextChanged += txtContaDestino_TextChanged;
            // 
            // textBox_conta_destino
            // 
            textBox_conta_destino.Location = new Point(19, 797);
            textBox_conta_destino.Name = "textBox_conta_destino";
            textBox_conta_destino.Size = new Size(139, 23);
            textBox_conta_destino.TabIndex = 34;
            // 
            // ValorEmconta
            // 
            ValorEmconta.AutoSize = true;
            ValorEmconta.Location = new Point(93, 746);
            ValorEmconta.Name = "ValorEmconta";
            ValorEmconta.Size = new Size(44, 15);
            ValorEmconta.TabIndex = 36;
            ValorEmconta.Text = "R$ 0,00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(19, 746);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 35;
            label17.Text = "Saldo atual:";
            // 
            // lblClienteInfo
            // 
            lblClienteInfo.AutoSize = true;
            lblClienteInfo.Location = new Point(19, 250);
            lblClienteInfo.Name = "lblClienteInfo";
            lblClienteInfo.Size = new Size(0, 15);
            lblClienteInfo.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 958);
            Controls.Add(lblClienteInfo);
            Controls.Add(ValorEmconta);
            Controls.Add(label17);
            Controls.Add(textBox_conta_destino);
            Controls.Add(txtContaDestino);
            Controls.Add(label15);
            Controls.Add(txt_NumeroConta);
            Controls.Add(btnTransferir);
            Controls.Add(label14);
            Controls.Add(txtValorTransferencia);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblOrigem);
            Controls.Add(btnSacar);
            Controls.Add(lblSaldoAtual);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(txtValor);
            Controls.Add(label10);
            Controls.Add(btnDepositar);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtTaxa);
            Controls.Add(text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(btnCriarConta);
            Controls.Add(btnCadastrarCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarCliente;
        private Button btnCriarConta;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtTaxa;
        private TextBox text;
        private Label label6;
        private Label label9;
        private TextBox txtValor;
        private Label label10;
        private Button btnDepositar;
        private Label lblSaldoAtual;
        private Button btnSacar;
        private Label lblOrigem;
        private Label label12;
        private Label label13;
        private TextBox txtValorTransferencia;
        private Label label14;
        private Button btnTransferir;
        private TextBox txt_NumeroConta;
        private Label label15;
        private TextBox txtContaDestino;
        private TextBox textBox_conta_destino;
        private Label ValorEmconta;
        private Label label17;
        private Label lblClienteInfo;
    }
}
