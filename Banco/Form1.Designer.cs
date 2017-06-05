namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.numeroContaLabel = new System.Windows.Forms.Label();
            this.titularLabel = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botaoTransferencia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTransferencia = new System.Windows.Forms.ComboBox();
            this.transferenciaValorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.btnCalculoImpostos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nomeBuscaBox = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saldoLabel);
            this.groupBox1.Controls.Add(this.numeroContaLabel);
            this.groupBox1.Controls.Add(this.titularLabel);
            this.groupBox1.Controls.Add(this.Valor);
            this.groupBox1.Controls.Add(this.valorBox);
            this.groupBox1.Controls.Add(this.botaoSacar);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Location = new System.Drawing.Point(141, 109);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saldoLabel.Size = new System.Drawing.Size(45, 13);
            this.saldoLabel.TabIndex = 12;
            this.saldoLabel.Text = "Escolha";
            // 
            // numeroContaLabel
            // 
            this.numeroContaLabel.AutoSize = true;
            this.numeroContaLabel.Location = new System.Drawing.Point(141, 70);
            this.numeroContaLabel.Name = "numeroContaLabel";
            this.numeroContaLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numeroContaLabel.Size = new System.Drawing.Size(45, 13);
            this.numeroContaLabel.TabIndex = 11;
            this.numeroContaLabel.Text = "Escolha";
            // 
            // titularLabel
            // 
            this.titularLabel.AutoSize = true;
            this.titularLabel.Location = new System.Drawing.Point(141, 36);
            this.titularLabel.Name = "titularLabel";
            this.titularLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titularLabel.Size = new System.Drawing.Size(45, 13);
            this.titularLabel.TabIndex = 10;
            this.titularLabel.Text = "Escolha";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(11, 147);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 9;
            this.Valor.Text = "Valor";
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(94, 147);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 8;
            this.valorBox.Text = "0";
            // 
            // botaoSacar
            // 
            this.botaoSacar.Enabled = false;
            this.botaoSacar.Location = new System.Drawing.Point(108, 191);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 7;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Enabled = false;
            this.botaoDepositar.Location = new System.Drawing.Point(12, 191);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 6;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.nomeBuscaBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(36, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(94, 19);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(100, 21);
            this.comboContas.TabIndex = 3;
            this.comboContas.Text = "Selecione";
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Titular da Conta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botaoTransferencia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboTransferencia);
            this.groupBox3.Controls.Add(this.transferenciaValorBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(36, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transferência";
            // 
            // botaoTransferencia
            // 
            this.botaoTransferencia.Enabled = false;
            this.botaoTransferencia.Location = new System.Drawing.Point(65, 75);
            this.botaoTransferencia.Name = "botaoTransferencia";
            this.botaoTransferencia.Size = new System.Drawing.Size(75, 23);
            this.botaoTransferencia.TabIndex = 4;
            this.botaoTransferencia.Text = "Transferir";
            this.botaoTransferencia.UseVisualStyleBackColor = true;
            this.botaoTransferencia.Click += new System.EventHandler(this.botaoTransferencia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Destinatário";
            // 
            // comboTransferencia
            // 
            this.comboTransferencia.FormattingEnabled = true;
            this.comboTransferencia.Location = new System.Drawing.Point(94, 44);
            this.comboTransferencia.Name = "comboTransferencia";
            this.comboTransferencia.Size = new System.Drawing.Size(100, 21);
            this.comboTransferencia.TabIndex = 2;
            this.comboTransferencia.Text = "Selecione";
            this.comboTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboTransferencia_SelectedIndexChanged);
            // 
            // transferenciaValorBox
            // 
            this.transferenciaValorBox.Location = new System.Drawing.Point(94, 17);
            this.transferenciaValorBox.Name = "transferenciaValorBox";
            this.transferenciaValorBox.Size = new System.Drawing.Size(100, 20);
            this.transferenciaValorBox.TabIndex = 1;
            this.transferenciaValorBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(36, 488);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 3;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // btnCalculoImpostos
            // 
            this.btnCalculoImpostos.Location = new System.Drawing.Point(136, 488);
            this.btnCalculoImpostos.Name = "btnCalculoImpostos";
            this.btnCalculoImpostos.Size = new System.Drawing.Size(100, 23);
            this.btnCalculoImpostos.TabIndex = 4;
            this.btnCalculoImpostos.Text = "Calcular Impostos";
            this.btnCalculoImpostos.UseVisualStyleBackColor = true;
            this.btnCalculoImpostos.Click += new System.EventHandler(this.btnCalculoImpostos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "BuscarPorNome";
            // 
            // nomeBuscaBox
            // 
            this.nomeBuscaBox.Location = new System.Drawing.Point(94, 45);
            this.nomeBuscaBox.Name = "nomeBuscaBox";
            this.nomeBuscaBox.Size = new System.Drawing.Size(100, 20);
            this.nomeBuscaBox.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(108, 68);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(63, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 575);
            this.Controls.Add(this.btnCalculoImpostos);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Label titularLabel;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label numeroContaLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botaoTransferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTransferencia;
        private System.Windows.Forms.TextBox transferenciaValorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button btnCalculoImpostos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox nomeBuscaBox;
        private System.Windows.Forms.Label label7;
    }
}

