namespace handsOnWorkIII
{
    partial class FormRealizarReservas
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
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.ColumnIDReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDefineHora = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSelecionaMesa = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSelecionaCliente = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 163);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDReserva,
            this.ColumnMesa,
            this.ColumnCliente,
            this.ColumnHorario});
            this.dataGridViewReservas.Location = new System.Drawing.Point(175, 9);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(471, 429);
            this.dataGridViewReservas.TabIndex = 1;
            // 
            // ColumnIDReserva
            // 
            this.ColumnIDReserva.HeaderText = "ID";
            this.ColumnIDReserva.Name = "ColumnIDReserva";
            this.ColumnIDReserva.ReadOnly = true;
            // 
            // ColumnMesa
            // 
            this.ColumnMesa.HeaderText = "Mesa";
            this.ColumnMesa.Name = "ColumnMesa";
            this.ColumnMesa.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            // 
            // ColumnHorario
            // 
            this.ColumnHorario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnHorario.HeaderText = "Horário";
            this.ColumnHorario.MinimumWidth = 200;
            this.ColumnHorario.Name = "ColumnHorario";
            this.ColumnHorario.ReadOnly = true;
            this.ColumnHorario.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecionar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecionar mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Definir Horário";
            // 
            // txtBoxDefineHora
            // 
            this.txtBoxDefineHora.Location = new System.Drawing.Point(15, 137);
            this.txtBoxDefineHora.Mask = "00:00:00";
            this.txtBoxDefineHora.Name = "txtBoxDefineHora";
            this.txtBoxDefineHora.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefineHora.TabIndex = 7;
            // 
            // txtBoxSelecionaMesa
            // 
            this.txtBoxSelecionaMesa.Location = new System.Drawing.Point(15, 82);
            this.txtBoxSelecionaMesa.Mask = "000";
            this.txtBoxSelecionaMesa.Name = "txtBoxSelecionaMesa";
            this.txtBoxSelecionaMesa.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSelecionaMesa.TabIndex = 8;
            // 
            // txtBoxSelecionaCliente
            // 
            this.txtBoxSelecionaCliente.Location = new System.Drawing.Point(15, 25);
            this.txtBoxSelecionaCliente.Mask = "00000000000";
            this.txtBoxSelecionaCliente.Name = "txtBoxSelecionaCliente";
            this.txtBoxSelecionaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSelecionaCliente.TabIndex = 9;
            // 
            // FormRealizarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.txtBoxSelecionaCliente);
            this.Controls.Add(this.txtBoxSelecionaMesa);
            this.Controls.Add(this.txtBoxDefineHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.Name = "FormRealizarReservas";
            this.Text = "FormRealizarReservas";
            this.Load += new System.EventHandler(this.FormRealizarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHorario;
        private System.Windows.Forms.MaskedTextBox txtBoxDefineHora;
        private System.Windows.Forms.MaskedTextBox txtBoxSelecionaMesa;
        private System.Windows.Forms.MaskedTextBox txtBoxSelecionaCliente;
    }
}