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
            this.rb_Func = new System.Windows.Forms.RadioButton();
            this.rb_Sp = new System.Windows.Forms.RadioButton();
            this.rb_Pv = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Location = new System.Drawing.Point(12, 255);
            this.dgVenda.MultiSelect = false;
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(1076, 293);
            this.dgVenda.TabIndex = 0;
            this.dgVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenda_CellClick);
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbData.Location = new System.Drawing.Point(145, 174);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(123, 20);
            this.cxbData.TabIndex = 3;
            this.cxbData.Text = "DATA DA VENDA";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "ATÉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "DE";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(177, 226);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(231, 20);
            this.dtp2.TabIndex = 5;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(177, 200);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(231, 20);
            this.dtp1.TabIndex = 4;
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btn_mostrar_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_tudo.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_tudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(545, 169);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(88, 36);
            this.btn_mostrar_tudo.TabIndex = 7;
            this.btn_mostrar_tudo.Text = "MOSTRAR TUDO";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = false;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(293, 131);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(340, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO ORÇAMENTO",
            "NOME DO CLIENTE",
            "CPF DO CLIENTE",
            "CNPJ DO CLIENTE"});
            this.cbxBuscar.Location = new System.Drawing.Point(146, 131);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(141, 24);
            this.cbxBuscar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Location = new System.Drawing.Point(442, 169);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 36);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(185, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIBIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 8;
            // 
            // lblnomecliente
            // 
            this.lblnomecliente.AutoSize = true;
            this.lblnomecliente.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecliente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblnomecliente.Location = new System.Drawing.Point(187, 21);
            this.lblnomecliente.Name = "lblnomecliente";
            this.lblnomecliente.Size = new System.Drawing.Size(89, 16);
            this.lblnomecliente.TabIndex = 67;
            this.lblnomecliente.Text = "ID DA VENDA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Func);
            this.groupBox1.Controls.Add(this.rb_Sp);
            this.groupBox1.Controls.Add(this.rb_Pv);
            this.groupBox1.Controls.Add(this.lblnomecliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(716, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 131);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLE DE EXIBIÇÃO";
            // 
            // rb_Func
            // 
            this.rb_Func.AutoSize = true;
            this.rb_Func.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Func.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_Func.Location = new System.Drawing.Point(10, 83);
            this.rb_Func.Name = "rb_Func";
            this.rb_Func.Size = new System.Drawing.Size(116, 20);
            this.rb_Func.TabIndex = 70;
            this.rb_Func.TabStop = true;
            this.rb_Func.Text = "FUNCIONÁRIOS";
            this.rb_Func.UseVisualStyleBackColor = true;
            // 
            // rb_Sp
            // 
            this.rb_Sp.AutoSize = true;
            this.rb_Sp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Sp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_Sp.Location = new System.Drawing.Point(10, 57);
            this.rb_Sp.Name = "rb_Sp";
            this.rb_Sp.Size = new System.Drawing.Size(160, 20);
            this.rb_Sp.TabIndex = 69;
            this.rb_Sp.TabStop = true;
            this.rb_Sp.Text = "SERVIÇOS PRESTADOS";
            this.rb_Sp.UseVisualStyleBackColor = true;
            // 
            // rb_Pv
            // 
            this.rb_Pv.AutoSize = true;
            this.rb_Pv.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Pv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_Pv.Location = new System.Drawing.Point(10, 32);
            this.rb_Pv.Name = "rb_Pv";
            this.rb_Pv.Size = new System.Drawing.Size(156, 20);
            this.rb_Pv.TabIndex = 68;
            this.rb_Pv.TabStop = true;
            this.rb_Pv.Text = "PRODUTOS VENDIDOS";
            this.rb_Pv.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 83);
            this.panel1.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(359, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONSULTA DE VENDA";
            // 
            // FmrVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 560);
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
        private System.Windows.Forms.RadioButton rb_Func;
        private System.Windows.Forms.RadioButton rb_Sp;
        private System.Windows.Forms.RadioButton rb_Pv;
    }
}