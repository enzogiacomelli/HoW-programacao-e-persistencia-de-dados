namespace handsOnWorkIII
{
    partial class FormDefinirNumeroDeMesas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumeroMesas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o número total de mesas";
            // 
            // txtBoxNumeroMesas
            // 
            this.txtBoxNumeroMesas.Location = new System.Drawing.Point(12, 25);
            this.txtBoxNumeroMesas.Mask = "000";
            this.txtBoxNumeroMesas.Name = "txtBoxNumeroMesas";
            this.txtBoxNumeroMesas.Size = new System.Drawing.Size(75, 20);
            this.txtBoxNumeroMesas.TabIndex = 3;
            // 
            // FormDefinirNumeroDeMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 147);
            this.Controls.Add(this.txtBoxNumeroMesas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.Name = "FormDefinirNumeroDeMesas";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormDefinirNumeroDeMesas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxNumeroMesas;
    }
}