﻿
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
            this.button2 = new System.Windows.Forms.Button();
            this.dg_log_fornecimento = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_mostrar_tudo = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_log_fornecimento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(210, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 20);
            this.txtBuscar.TabIndex = 37;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID DO LOG DE FORNECIMENTO",
            "NOME DO PRODUTO",
            "NOME DO FORNECEDOR",
            "DATA DO FORNECIMENTO"});
            this.cbxBuscar.Location = new System.Drawing.Point(44, 80);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cbxBuscar.TabIndex = 36;
            this.cbxBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxBuscar_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg_log_fornecimento
            // 
            this.dg_log_fornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_log_fornecimento.Location = new System.Drawing.Point(44, 130);
            this.dg_log_fornecimento.Name = "dg_log_fornecimento";
            this.dg_log_fornecimento.Size = new System.Drawing.Size(749, 288);
            this.dg_log_fornecimento.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Consulta de log de fornecimento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_mostrar_tudo
            // 
            this.btn_mostrar_tudo.Location = new System.Drawing.Point(571, 80);
            this.btn_mostrar_tudo.Name = "btn_mostrar_tudo";
            this.btn_mostrar_tudo.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar_tudo.TabIndex = 38;
            this.btn_mostrar_tudo.Text = "Mostrar tudo";
            this.btn_mostrar_tudo.UseVisualStyleBackColor = true;
            this.btn_mostrar_tudo.Click += new System.EventHandler(this.btn_mostrar_tudo_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(44, 54);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 39;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(266, 54);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "-";
            // 
            // FrmlogFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btn_mostrar_tudo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dg_log_fornecimento);
            this.Controls.Add(this.label8);
            this.Name = "FrmlogFornecimento";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmlogFornecimento_FormClosed);
            this.Load += new System.EventHandler(this.FrmlogFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_log_fornecimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dg_log_fornecimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_mostrar_tudo;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label1;
    }
}