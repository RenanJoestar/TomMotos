
namespace TomMotos.view
{
    partial class FmrFinalizar_venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFaltaPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEmails = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DINHEIRO                         R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARTÃO DEBITO              R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CARTÃO CRÉDITO           R$";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PIX                                     R$";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(168, 33);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(100, 20);
            this.txtDinheiro.TabIndex = 4;
            this.txtDinheiro.Text = "0";
            this.txtDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDinheiro_KeyDown);
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(168, 56);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(100, 20);
            this.txtDebito.TabIndex = 5;
            this.txtDebito.Text = "0";
            this.txtDebito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebito_KeyDown);
            // 
            // txt_credito
            // 
            this.txt_credito.Location = new System.Drawing.Point(168, 82);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(100, 20);
            this.txt_credito.TabIndex = 6;
            this.txt_credito.Text = "0";
            this.txt_credito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_credito_KeyDown);
            // 
            // txtPix
            // 
            this.txtPix.Location = new System.Drawing.Point(168, 109);
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(100, 20);
            this.txtPix.TabIndex = 7;
            this.txtPix.Text = "0";
            this.txtPix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPix_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTroco);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Troco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtValorPago);
            this.groupBox2.Location = new System.Drawing.Point(205, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 94);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFaltaPagar);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Falta Pag:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOk);
            this.groupBox4.Location = new System.Drawing.Point(205, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fechamento";
            // 
            // txtFaltaPagar
            // 
            this.txtFaltaPagar.Enabled = false;
            this.txtFaltaPagar.Location = new System.Drawing.Point(36, 37);
            this.txtFaltaPagar.Name = "txtFaltaPagar";
            this.txtFaltaPagar.Size = new System.Drawing.Size(93, 20);
            this.txtFaltaPagar.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "R$";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(39, 37);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(36, 39);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(93, 20);
            this.txtTroco.TabIndex = 0;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Enabled = false;
            this.txtValorPago.Location = new System.Drawing.Point(39, 39);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "R$";
            // 
            // cbxEmails
            // 
            this.cbxEmails.FormattingEnabled = true;
            this.cbxEmails.Items.AddRange(new object[] {
            ""});
            this.cbxEmails.Location = new System.Drawing.Point(310, 49);
            this.cbxEmails.Name = "cbxEmails";
            this.cbxEmails.Size = new System.Drawing.Size(127, 21);
            this.cbxEmails.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "DIGITE O EMAIL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Subtotal";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(338, 394);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(13, 13);
            this.lblsubtotal.TabIndex = 15;
            this.lblsubtotal.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmrFinalizar_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxEmails);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPix);
            this.Controls.Add(this.txt_credito);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrFinalizar_venda";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FmrFinalizar_venda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaltaPagar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbxEmails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Button button1;
    }
}