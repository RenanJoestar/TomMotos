
namespace TomMotos.view
{
    partial class FmrVeiculo_Cliente
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
            this.dg_listarVeiculoOuCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listarVeiculoOuCliente
            // 
            this.dg_listarVeiculoOuCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listarVeiculoOuCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_listarVeiculoOuCliente.Location = new System.Drawing.Point(0, 0);
            this.dg_listarVeiculoOuCliente.Name = "dg_listarVeiculoOuCliente";
            this.dg_listarVeiculoOuCliente.Size = new System.Drawing.Size(800, 450);
            this.dg_listarVeiculoOuCliente.TabIndex = 0;
            this.dg_listarVeiculoOuCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentClick);
            this.dg_listarVeiculoOuCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentDoubleClick);
            // 
            // FmrVeiculo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_listarVeiculoOuCliente);
            this.Name = "FmrVeiculo_Cliente";
            this.Text = "FmrVeiculo_Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmrVeiculo_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.FmrVeiculo_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_listarVeiculoOuCliente;
    }
}