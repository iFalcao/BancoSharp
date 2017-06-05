namespace Banco
{
    partial class FormRelatorios
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
            this.btnSaldoMaiorQue500 = new System.Windows.Forms.Button();
            this.listaResultados = new System.Windows.Forms.ListBox();
            this.btnNumeroContaAte10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaiorSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMediaSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenorSaldo = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaldoMaiorQue500
            // 
            this.btnSaldoMaiorQue500.Location = new System.Drawing.Point(41, 278);
            this.btnSaldoMaiorQue500.Name = "btnSaldoMaiorQue500";
            this.btnSaldoMaiorQue500.Size = new System.Drawing.Size(122, 23);
            this.btnSaldoMaiorQue500.TabIndex = 1;
            this.btnSaldoMaiorQue500.Text = "Saldo Maior que 500";
            this.btnSaldoMaiorQue500.UseVisualStyleBackColor = true;
            this.btnSaldoMaiorQue500.Click += new System.EventHandler(this.btnSaldoMaiorQue500_Click);
            // 
            // listaResultados
            // 
            this.listaResultados.FormattingEnabled = true;
            this.listaResultados.Location = new System.Drawing.Point(32, 26);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(323, 121);
            this.listaResultados.TabIndex = 2;
            // 
            // btnNumeroContaAte10
            // 
            this.btnNumeroContaAte10.Location = new System.Drawing.Point(183, 278);
            this.btnNumeroContaAte10.Name = "btnNumeroContaAte10";
            this.btnNumeroContaAte10.Size = new System.Drawing.Size(172, 23);
            this.btnNumeroContaAte10.TabIndex = 3;
            this.btnNumeroContaAte10.Text = "Número de Conta Menor que 10";
            this.btnNumeroContaAte10.UseVisualStyleBackColor = true;
            this.btnNumeroContaAte10.Click += new System.EventHandler(this.btnNumeroContaAte10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldoTotal);
            this.groupBox1.Controls.Add(this.labelx);
            this.groupBox1.Controls.Add(this.lblMenorSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMediaSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMaiorSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maior Saldo";
            // 
            // lblMaiorSaldo
            // 
            this.lblMaiorSaldo.AutoSize = true;
            this.lblMaiorSaldo.Location = new System.Drawing.Point(90, 20);
            this.lblMaiorSaldo.Name = "lblMaiorSaldo";
            this.lblMaiorSaldo.Size = new System.Drawing.Size(52, 13);
            this.lblMaiorSaldo.TabIndex = 1;
            this.lblMaiorSaldo.Text = "selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Média Saldo";
            // 
            // lblMediaSaldo
            // 
            this.lblMediaSaldo.AutoSize = true;
            this.lblMediaSaldo.Location = new System.Drawing.Point(90, 50);
            this.lblMediaSaldo.Name = "lblMediaSaldo";
            this.lblMediaSaldo.Size = new System.Drawing.Size(52, 13);
            this.lblMediaSaldo.TabIndex = 3;
            this.lblMediaSaldo.Text = "selecione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menor Saldo";
            // 
            // lblMenorSaldo
            // 
            this.lblMenorSaldo.AutoSize = true;
            this.lblMenorSaldo.Location = new System.Drawing.Point(254, 20);
            this.lblMenorSaldo.Name = "lblMenorSaldo";
            this.lblMenorSaldo.Size = new System.Drawing.Size(52, 13);
            this.lblMenorSaldo.TabIndex = 5;
            this.lblMenorSaldo.Text = "selecione";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(168, 50);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(61, 13);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "Saldo Total";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(254, 50);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(52, 13);
            this.lblSaldoTotal.TabIndex = 7;
            this.lblSaldoTotal.Text = "selecione";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(125, 153);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Resultados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 315);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNumeroContaAte10);
            this.Controls.Add(this.listaResultados);
            this.Controls.Add(this.btnSaldoMaiorQue500);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaldoMaiorQue500;
        private System.Windows.Forms.ListBox listaResultados;
        private System.Windows.Forms.Button btnNumeroContaAte10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label lblMenorSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMediaSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaiorSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
    }
}