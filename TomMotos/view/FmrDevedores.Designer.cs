namespace TomMotos.view
{
    partial class FmrDevedores
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
            this.cxbData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cxbData
            // 
            this.cxbData.AutoSize = true;
            this.cxbData.Location = new System.Drawing.Point(35, 84);
            this.cxbData.Name = "cxbData";
            this.cxbData.Size = new System.Drawing.Size(146, 17);
            this.cxbData.TabIndex = 65;
            this.cxbData.Text = "DATA DO ORÇAMENTO";
            this.cxbData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "De";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(66, 133);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 62;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(66, 107);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 61;
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(384, 78);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar_tudo.TabIndex = 60;
            this.btn_mostrar_tudo.Text = "Mostrar tudo";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(201, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 20);
            this.txtBuscar.TabIndex = 59;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO ORÇAMENTO",
            "NOME DO CLIENTE"});
            this.cbxBuscar.Location = new System.Drawing.Point(35, 41);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbxBuscar.TabIndex = 58;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(303, 77);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 57;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Consulta de devedores";
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamento.Location = new System.Drawing.Point(3, 169);
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.Size = new System.Drawing.Size(905, 279);
            this.dgOrcamento.TabIndex = 55;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Enabled = false;
            this.txtIdVenda.Location = new System.Drawing.Point(655, 42);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenda.TabIndex = 66;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(678, 77);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Update de devedores";
            // 
            // FmrDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtIdVenda);
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
            this.Name = "FmrDevedores";
            this.Text = "FmrDevedores";
            this.Load += new System.EventHandler(this.FmrDevedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cxbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}