
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrVeiculo_Cliente));
            this.dg_listarVeiculoOuCliente = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnMostrarTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listarVeiculoOuCliente
            // 
            this.dg_listarVeiculoOuCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listarVeiculoOuCliente.Location = new System.Drawing.Point(0, 69);
            this.dg_listarVeiculoOuCliente.MultiSelect = false;
            this.dg_listarVeiculoOuCliente.Name = "dg_listarVeiculoOuCliente";
            this.dg_listarVeiculoOuCliente.ReadOnly = true;
            this.dg_listarVeiculoOuCliente.Size = new System.Drawing.Size(800, 381);
            this.dg_listarVeiculoOuCliente.TabIndex = 0;
            this.dg_listarVeiculoOuCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentClick);
            this.dg_listarVeiculoOuCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentDoubleClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(513, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(127, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(380, 20);
            this.txtBuscar.TabIndex = 30;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Location = new System.Drawing.Point(16, 11);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(105, 21);
            this.cbxBuscar.TabIndex = 29;
            // 
            // btnMostrarTudo
            // 
            this.btnMostrarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarTudo.Location = new System.Drawing.Point(556, 10);
            this.btnMostrarTudo.Name = "btnMostrarTudo";
            this.btnMostrarTudo.Size = new System.Drawing.Size(84, 20);
            this.btnMostrarTudo.TabIndex = 50;
            this.btnMostrarTudo.Text = "Mostrar tudo";
            this.btnMostrarTudo.UseVisualStyleBackColor = true;
            this.btnMostrarTudo.Click += new System.EventHandler(this.btnMostrarTudo_Click);
            // 
            // FmrVeiculo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarTudo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.dg_listarVeiculoOuCliente);
            this.Name = "FmrVeiculo_Cliente";
            this.Text = "FmrVeiculo_Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmrVeiculo_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.FmrVeiculo_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_listarVeiculoOuCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnMostrarTudo;
    }
}