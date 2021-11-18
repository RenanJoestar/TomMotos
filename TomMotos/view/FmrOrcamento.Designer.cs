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
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cxbData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamento.Location = new System.Drawing.Point(0, 183);
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.Size = new System.Drawing.Size(1154, 470);
            this.dgOrcamento.TabIndex = 0;
            this.dgOrcamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrcamento_CellDoubleClick);
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(383, 88);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar_tudo.TabIndex = 49;
            this.btn_mostrar_tudo.Text = "Mostrar tudo";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = true;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(200, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 20);
            this.txtBuscar.TabIndex = 48;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO ORÇAMENTO",
            "NOME DO CLIENTE"});
            this.cbxBuscar.Location = new System.Drawing.Point(34, 51);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbxBuscar.TabIndex = 47;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(302, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 46;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Consulta de orçamento";
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Location = new System.Drawing.Point(34, 94);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(146, 17);
            this.cxbData.TabIndex = 54;
            this.cxbData.Text = "DATA DO ORÇAMENTO";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "De";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(65, 143);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 51;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(65, 117);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 50;
            // 
            // FmrOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 660);
            this.Controls.Add(this.cxbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btn_mostrar_tudo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgOrcamento);
            this.Name = "FmrOrcamento";
            this.Text = "FmOrcamento";
            this.Load += new System.EventHandler(this.FmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cxbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}