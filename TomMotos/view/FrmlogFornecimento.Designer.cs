
namespace TomMotos.view
{
    partial class FrmlogFornecimento
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dg_log_fornecimento = new System.Windows.Forms.DataGridView();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cxbData = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_log_fornecimento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(448, 114);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(326, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO LOG DE FORNECIMENTO",
            "NOME DO PRODUTO",
            "NOME DO FORNECEDOR"});
            this.cbxBuscar.Location = new System.Drawing.Point(282, 113);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbxBuscar.TabIndex = 1;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisar.Location = new System.Drawing.Point(592, 146);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(88, 39);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_log_fornecimento
            // 
            this.dg_log_fornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_log_fornecimento.Location = new System.Drawing.Point(-1, 278);
            this.dg_log_fornecimento.MultiSelect = false;
            this.dg_log_fornecimento.Name = "dg_log_fornecimento";
            this.dg_log_fornecimento.ReadOnly = true;
            this.dg_log_fornecimento.Size = new System.Drawing.Size(1048, 381);
            this.dg_log_fornecimento.TabIndex = 31;
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btn_mostrar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_tudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(686, 146);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(88, 39);
            this.btn_mostrar_tudo.TabIndex = 7;
            this.btn_mostrar_tudo.Text = "MOSTRAR TUDO";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = false;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(313, 179);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(228, 20);
            this.dtp1.TabIndex = 4;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(313, 205);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(228, 20);
            this.dtp2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "ATÉ";
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbData.Location = new System.Drawing.Point(282, 156);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(174, 20);
            this.cxbData.TabIndex = 3;
            this.cxbData.Text = "DATA DO FORNECIMENTO";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 83);
            this.panel1.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(189, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONSULTA DE LOG FORNECIMENTO";
            // 
            // FrmlogFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cxbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btn_mostrar_tudo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dg_log_fornecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmlogFornecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmlogFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_log_fornecimento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dg_log_fornecimento;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cxbData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}