
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_listarVeiculoOuCliente
            // 
            this.dg_listarVeiculoOuCliente.AllowUserToAddRows = false;
            this.dg_listarVeiculoOuCliente.AllowUserToDeleteRows = false;
            this.dg_listarVeiculoOuCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_listarVeiculoOuCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_listarVeiculoOuCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_listarVeiculoOuCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listarVeiculoOuCliente.Location = new System.Drawing.Point(19, 188);
            this.dg_listarVeiculoOuCliente.MultiSelect = false;
            this.dg_listarVeiculoOuCliente.Name = "dg_listarVeiculoOuCliente";
            this.dg_listarVeiculoOuCliente.ReadOnly = true;
            this.dg_listarVeiculoOuCliente.Size = new System.Drawing.Size(1069, 360);
            this.dg_listarVeiculoOuCliente.TabIndex = 0;
            this.dg_listarVeiculoOuCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentClick);
            this.dg_listarVeiculoOuCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_listarVeiculoOuCliente_CellContentDoubleClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(791, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 39);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Location = new System.Drawing.Point(318, 136);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(467, 20);
            this.txtBuscar.TabIndex = 30;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Location = new System.Drawing.Point(170, 136);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(142, 21);
            this.cbxBuscar.TabIndex = 29;
            // 
            // btnMostrarTudo
            // 
            this.btnMostrarTudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnMostrarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTudo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTudo.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTudo.Location = new System.Drawing.Point(839, 126);
            this.btnMostrarTudo.Name = "btnMostrarTudo";
            this.btnMostrarTudo.Size = new System.Drawing.Size(88, 39);
            this.btnMostrarTudo.TabIndex = 50;
            this.btnMostrarTudo.Text = "MOSTRAR TUDO";
            this.btnMostrarTudo.UseVisualStyleBackColor = false;
            this.btnMostrarTudo.Click += new System.EventHandler(this.btnMostrarTudo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.lblPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 85);
            this.panel1.TabIndex = 51;
            // 
            // X
            // 
            this.X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X.BackColor = System.Drawing.Color.White;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.X.Location = new System.Drawing.Point(1013, 16);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(73, 49);
            this.X.TabIndex = 49;
            this.X.Text = "< VOLTAR";
            this.X.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPesquisa.ForeColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(366, 20);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(336, 44);
            this.lblPesquisa.TabIndex = 19;
            this.lblPesquisa.Text = "PESQUISA CLIENTE";
            // 
            // FmrVeiculo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrarTudo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.dg_listarVeiculoOuCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrVeiculo_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrVeiculo_Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmrVeiculo_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.FmrVeiculo_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listarVeiculoOuCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_listarVeiculoOuCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnMostrarTudo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label lblPesquisa;
    }
}