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
            this.SuspendLayout();
            // 
            // campoTexto
            // 
            this.campoTexto.Location = new System.Drawing.Point(32, 21);
            this.campoTexto.Multiline = true;
            this.campoTexto.Name = "campoTexto";
            this.campoTexto.Size = new System.Drawing.Size(524, 341);
            this.campoTexto.TabIndex = 0;
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(61, 379);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(75, 23);
            this.btnGrava.TabIndex = 1;
            this.btnGrava.Text = "Gravar";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 425);
            this.Controls.Add(this.btnGrava);
            this.Controls.Add(this.campoTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoTexto;
        private System.Windows.Forms.Button btnGrava;
    }
}

