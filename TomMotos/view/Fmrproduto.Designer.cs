
namespace TomMotos.view
{
    partial class Fmrproduto
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
            this.ptb_perfil = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_valor_produto = new System.Windows.Forms.TextBox();
            this.np_quantidade = new System.Windows.Forms.NumericUpDown();
            this.txt_marca_produto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descricao_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_produto = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_perfil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_perfil
            // 
            this.ptb_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_perfil.Image = global::TomMotos.Properties.Resources.SAM_3321;
            this.ptb_perfil.Location = new System.Drawing.Point(107, 263);
            this.ptb_perfil.Name = "ptb_perfil";
            this.ptb_perfil.Size = new System.Drawing.Size(100, 107);
            this.ptb_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_perfil.TabIndex = 0;
            this.ptb_perfil.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(104, 384);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(41, 15);
            this.lblCaminho.TabIndex = 2;
            this.lblCaminho.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_valor_produto);
            this.groupBox1.Controls.Add(this.lblCaminho);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.np_quantidade);
            this.groupBox1.Controls.Add(this.ptb_perfil);
            this.groupBox1.Controls.Add(this.txt_marca_produto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_descricao_produto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 485);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREENCHER DADOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "IMAGEM:";
            // 
            // txt_valor_produto
            // 
            this.txt_valor_produto.Location = new System.Drawing.Point(95, 158);
            this.txt_valor_produto.Name = "txt_valor_produto";
            this.txt_valor_produto.Size = new System.Drawing.Size(110, 21);
            this.txt_valor_produto.TabIndex = 34;
            // 
            // np_quantidade
            // 
            this.np_quantidade.Location = new System.Drawing.Point(95, 121);
            this.np_quantidade.Name = "np_quantidade";
            this.np_quantidade.Size = new System.Drawing.Size(86, 21);
            this.np_quantidade.TabIndex = 32;
            // 
            // txt_marca_produto
            // 
            this.txt_marca_produto.Location = new System.Drawing.Point(93, 192);
            this.txt_marca_produto.Name = "txt_marca_produto";
            this.txt_marca_produto.Size = new System.Drawing.Size(112, 21);
            this.txt_marca_produto.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "MARCA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "*VALOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "*QUANTIDADE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.DarkOrange;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(95, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(46, 21);
            this.txt_id.TabIndex = 0;
            // 
            // txt_descricao_produto
            // 
            this.txt_descricao_produto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descricao_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricao_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao_produto.ForeColor = System.Drawing.Color.White;
            this.txt_descricao_produto.Location = new System.Drawing.Point(95, 84);
            this.txt_descricao_produto.Name = "txt_descricao_produto";
            this.txt_descricao_produto.Size = new System.Drawing.Size(160, 21);
            this.txt_descricao_produto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "* DESCRIÇÃO:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cadastro de Produto";
            // 
            // dg_produto
            // 
            this.dg_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_produto.Location = new System.Drawing.Point(415, 56);
            this.dg_produto.Name = "dg_produto";
            this.dg_produto.Size = new System.Drawing.Size(502, 314);
            this.dg_produto.TabIndex = 20;
            this.dg_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_produto_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(450, 428);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 46);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(620, 428);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 46);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(785, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 43);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Fmrproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 593);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dg_produto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fmrproduto";
            this.Text = "Fmrproduto";
            this.Load += new System.EventHandler(this.Fmrproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_perfil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_perfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_valor_produto;
        private System.Windows.Forms.NumericUpDown np_quantidade;
        private System.Windows.Forms.TextBox txt_marca_produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_descricao_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_produto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}