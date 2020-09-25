namespace handsOnWorkIII
{
    partial class FormVisualizarMesas
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
            this.dataGridMesas = new System.Windows.Forms.DataGridView();
            this.ColumnID_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMesas
            // 
            this.dataGridMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_mesa,
            this.ColumnID_reserva});
            this.dataGridMesas.Location = new System.Drawing.Point(12, 12);
            this.dataGridMesas.Name = "dataGridMesas";
            this.dataGridMesas.Size = new System.Drawing.Size(243, 426);
            this.dataGridMesas.TabIndex = 1;
            // 
            // ColumnID_mesa
            // 
            this.ColumnID_mesa.HeaderText = "Número da mesa";
            this.ColumnID_mesa.Name = "ColumnID_mesa";
            this.ColumnID_mesa.ReadOnly = true;
            // 
            // ColumnID_reserva
            // 
            this.ColumnID_reserva.HeaderText = "Reserva";
            this.ColumnID_reserva.Name = "ColumnID_reserva";
            this.ColumnID_reserva.ReadOnly = true;
            // 
            // FormVisualizarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.dataGridMesas);
            this.MaximizeBox = false;
            this.Name = "FormVisualizarMesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.FormVisualizarMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_reserva;
    }
}