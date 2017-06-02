namespace Primeiro_App
{
    partial class Opcoes
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
            this.titularSaqueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saqueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titularSaqueBox
            // 
            this.titularSaqueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titularSaqueBox.Location = new System.Drawing.Point(38, 83);
            this.titularSaqueBox.Name = "titularSaqueBox";
            this.titularSaqueBox.Size = new System.Drawing.Size(100, 20);
            this.titularSaqueBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome do Titular";
            // 
            // saqueBox
            // 
            this.saqueBox.Location = new System.Drawing.Point(38, 131);
            this.saqueBox.Name = "saqueBox";
            this.saqueBox.Size = new System.Drawing.Size(100, 20);
            this.saqueBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quanto deseja sacar?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(52, 171);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 12;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 262);
            this.Controls.Add(this.titularSaqueBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saqueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoSaque);
            this.Name = "Opcoes";
            this.Text = "Opcoes";
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularSaqueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saqueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoSaque;
    }
}