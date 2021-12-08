
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtBuscar.Location = new System.Drawing.Point(475, 114);
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
            this.cbxBuscar.Location = new System.Drawing.Point(309, 113);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbxBuscar.TabIndex = 1;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisar.Location = new System.Drawing.Point(619, 146);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(88, 39);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_log_fornecimento
            // 
            this.dg_log_fornecimento.AllowUserToAddRows = false;
            this.dg_log_fornecimento.AllowUserToDeleteRows = false;
            this.dg_log_fornecimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_log_fornecimento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_log_fornecimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_log_fornecimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_log_fornecimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_log_fornecimento.ColumnHeadersHeight = 36;
            this.dg_log_fornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_log_fornecimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_log_fornecimento.EnableHeadersVisualStyles = false;
            this.dg_log_fornecimento.GridColor = System.Drawing.Color.Black;
            this.dg_log_fornecimento.Location = new System.Drawing.Point(12, 243);
            this.dg_log_fornecimento.MultiSelect = false;
            this.dg_log_fornecimento.Name = "dg_log_fornecimento";
            this.dg_log_fornecimento.ReadOnly = true;
            this.dg_log_fornecimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_log_fornecimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_log_fornecimento.Size = new System.Drawing.Size(1076, 305);
            this.dg_log_fornecimento.TabIndex = 31;
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btn_mostrar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_tudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(713, 146);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(88, 39);
            this.btn_mostrar_tudo.TabIndex = 7;
            this.btn_mostrar_tudo.Text = "MOSTRAR TUDO";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = false;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(340, 179);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(228, 20);
            this.dtp1.TabIndex = 4;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(340, 205);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(228, 20);
            this.dtp2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "ATÉ";
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbData.Location = new System.Drawing.Point(309, 156);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(175, 20);
            this.cxbData.TabIndex = 3;
            this.cxbData.Text = "DATA DO FORNECIMENTO";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 83);
            this.panel1.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(229, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(643, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONSULTA DE LOG FORNECIMENTO";
            // 
            // FrmlogFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 560);
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