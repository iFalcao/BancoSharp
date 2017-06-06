namespace EditorSublinha
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
            this.campoTexto = new System.Windows.Forms.TextBox();
            this.btnGrava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campoFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.campoReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnMaiuscula = new System.Windows.Forms.Button();
            this.btnMinuscula = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoTexto
            // 
            this.campoTexto.Location = new System.Drawing.Point(32, 21);
            this.campoTexto.Multiline = true;
            this.campoTexto.Name = "campoTexto";
            this.campoTexto.Size = new System.Drawing.Size(348, 209);
            this.campoTexto.TabIndex = 0;
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(51, 236);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(75, 23);
            this.btnGrava.TabIndex = 1;
            this.btnGrava.Text = "Gravar";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.campoReplace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.campoFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(170, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // campoFind
            // 
            this.campoFind.Location = new System.Drawing.Point(73, 23);
            this.campoFind.Name = "campoFind";
            this.campoFind.Size = new System.Drawing.Size(100, 20);
            this.campoFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(23, 76);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace";
            // 
            // campoReplace
            // 
            this.campoReplace.Location = new System.Drawing.Point(73, 50);
            this.campoReplace.Name = "campoReplace";
            this.campoReplace.Size = new System.Drawing.Size(100, 20);
            this.campoReplace.TabIndex = 4;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(98, 76);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnMaiuscula
            // 
            this.btnMaiuscula.Location = new System.Drawing.Point(19, 19);
            this.btnMaiuscula.Name = "btnMaiuscula";
            this.btnMaiuscula.Size = new System.Drawing.Size(75, 23);
            this.btnMaiuscula.TabIndex = 3;
            this.btnMaiuscula.Text = "Maiúscula";
            this.btnMaiuscula.UseVisualStyleBackColor = true;
            this.btnMaiuscula.Click += new System.EventHandler(this.btnMaiuscula_Click);
            // 
            // btnMinuscula
            // 
            this.btnMinuscula.Location = new System.Drawing.Point(19, 47);
            this.btnMinuscula.Name = "btnMinuscula";
            this.btnMinuscula.Size = new System.Drawing.Size(75, 23);
            this.btnMinuscula.TabIndex = 4;
            this.btnMinuscula.Text = "Minúscula";
            this.btnMinuscula.UseVisualStyleBackColor = true;
            this.btnMinuscula.Click += new System.EventHandler(this.btnMinuscula_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMaiuscula);
            this.groupBox2.Controls.Add(this.btnMinuscula);
            this.groupBox2.Location = new System.Drawing.Point(32, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SelecionarTexto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.campoTexto);
            this.Name = "Form1";
            this.Text = "Editor Sublinha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoTexto;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox campoFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox campoReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaiuscula;
        private System.Windows.Forms.Button btnMinuscula;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

