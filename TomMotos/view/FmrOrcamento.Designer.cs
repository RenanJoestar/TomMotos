namespace TomMotos.view
{
    partial class FmrOrcamento
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
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cxbData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.AllowUserToAddRows = false;
            this.dgOrcamento.AllowUserToDeleteRows = false;
            this.dgOrcamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrcamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrcamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrcamento.ColumnHeadersHeight = 36;
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrcamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrcamento.EnableHeadersVisualStyles = false;
            this.dgOrcamento.GridColor = System.Drawing.Color.Black;
            this.dgOrcamento.Location = new System.Drawing.Point(12, 250);
            this.dgOrcamento.MultiSelect = false;
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.ReadOnly = true;
            this.dgOrcamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrcamento.Size = new System.Drawing.Size(1076, 298);
            this.dgOrcamento.TabIndex = 0;
            this.dgOrcamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrcamento_CellDoubleClick);
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btn_mostrar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_tudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(729, 141);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(88, 39);
            this.btn_mostrar_tudo.TabIndex = 8;
            this.btn_mostrar_tudo.Text = "MOSTRAR TUDO";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = false;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(491, 109);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(326, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO ORÇAMENTO",
            "NOME DO CLIENTE"});
            this.cbxBuscar.Location = new System.Drawing.Point(325, 108);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(141, 21);
            this.cbxBuscar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Location = new System.Drawing.Point(635, 141);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 39);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.cxbData.Location = new System.Drawing.Point(325, 151);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(154, 20);
            this.cxbData.TabIndex = 4;
            this.cxbData.Text = "DATA DO ORÇAMENTO";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label2.Location = new System.Drawing.Point(322, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "ATÉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.label1.Location = new System.Drawing.Point(322, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "DE";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(356, 200);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(226, 20);
            this.dtp2.TabIndex = 6;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(356, 174);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(226, 20);
            this.dtp1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 83);
            this.panel1.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(338, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONSULTA DE ORÇAMENTO";
            // 
            // FmrOrcamento
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
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmOrcamento";
            this.Load += new System.EventHandler(this.FmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox cxbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}