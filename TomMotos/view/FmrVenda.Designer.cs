namespace TomMotos.view
{
    partial class FmrVenda
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
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.cxbData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblnomecliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVenda
            // 
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Location = new System.Drawing.Point(-1, 278);
            this.dgVenda.MultiSelect = false;
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(1048, 381);
            this.dgVenda.TabIndex = 0;
            this.dgVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenda_CellClick);
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbData.Location = new System.Drawing.Point(33, 173);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(122, 20);
            this.cxbData.TabIndex = 3;
            this.cxbData.Text = "DATA DA VENDA";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "ATÉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "DE";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(65, 225);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(231, 20);
            this.dtp2.TabIndex = 5;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(65, 199);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(231, 20);
            this.dtp1.TabIndex = 4;
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btn_mostrar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_tudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(433, 165);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(88, 39);
            this.btn_mostrar_tudo.TabIndex = 7;
            this.btn_mostrar_tudo.Text = "MOSTRAR TUDO";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = false;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(181, 130);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(340, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO ORÇAMENTO",
            "NOME DO CLIENTE",
            "CPF DO CLIENTE",
            "CNPJ DO CLIENTE"});
            this.cbxBuscar.Location = new System.Drawing.Point(34, 130);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(141, 21);
            this.cbxBuscar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Location = new System.Drawing.Point(330, 165);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 39);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(63, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIBIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblnomecliente
            // 
            this.lblnomecliente.AutoSize = true;
            this.lblnomecliente.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.lblnomecliente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblnomecliente.Location = new System.Drawing.Point(59, 21);
            this.lblnomecliente.Name = "lblnomecliente";
            this.lblnomecliente.Size = new System.Drawing.Size(99, 18);
            this.lblnomecliente.TabIndex = 67;
            this.lblnomecliente.Text = "ID DA VENDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnomecliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(715, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 135);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRUPO DE FUNCIONÁRIOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 83);
            this.panel1.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(311, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONSULTA DE VENDA";
            // 
            // FmrVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cxbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btn_mostrar_tudo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrVenda";
            this.Load += new System.EventHandler(this.FmrVendacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.CheckBox cxbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblnomecliente;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}