
namespace TomMotos
{
    partial class Fmrsumario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmrsumario));
            this.btnDevedores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.BT_VEICULO = new System.Windows.Forms.Button();
            this.BT_CLIENTE = new System.Windows.Forms.Button();
            this.BT_CARGO = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_LOG_FORNECIMENTO = new System.Windows.Forms.Button();
            this.BT_FORNECEDOR = new System.Windows.Forms.Button();
            this.BT_ORCAMENTO = new System.Windows.Forms.Button();
            this.BT_FUNCIONARIO = new System.Windows.Forms.Button();
            this.BT_PRODUTO = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevedores
            // 
            this.btnDevedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnDevedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevedores.ForeColor = System.Drawing.Color.White;
            this.btnDevedores.Location = new System.Drawing.Point(27, 553);
            this.btnDevedores.Name = "btnDevedores";
            this.btnDevedores.Size = new System.Drawing.Size(150, 43);
            this.btnDevedores.TabIndex = 0;
            this.btnDevedores.Text = "DEVEDORES";
            this.btnDevedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevedores.UseVisualStyleBackColor = false;
            this.btnDevedores.Click += new System.EventHandler(this.btnDevedores_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.btnCaixa);
            this.panel2.Controls.Add(this.btnVendas);
            this.panel2.Controls.Add(this.panelForm);
            this.panel2.Controls.Add(this.BT_VEICULO);
            this.panel2.Controls.Add(this.BT_CLIENTE);
            this.panel2.Controls.Add(this.BT_CARGO);
            this.panel2.Controls.Add(this.btnDevedores);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BT_LOG_FORNECIMENTO);
            this.panel2.Controls.Add(this.BT_FORNECEDOR);
            this.panel2.Controls.Add(this.BT_ORCAMENTO);
            this.panel2.Controls.Add(this.BT_FUNCIONARIO);
            this.panel2.Controls.Add(this.BT_PRODUTO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 669);
            this.panel2.TabIndex = 29;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.Location = new System.Drawing.Point(27, 602);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(150, 43);
            this.btnCaixa.TabIndex = 39;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(27, 504);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(150, 43);
            this.btnVendas.TabIndex = 38;
            this.btnVendas.Text = "VENDAS";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(206, 3);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(767, 371);
            this.panelForm.TabIndex = 30;
            // 
            // BT_VEICULO
            // 
            this.BT_VEICULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_VEICULO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_VEICULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_VEICULO.ForeColor = System.Drawing.Color.White;
            this.BT_VEICULO.Image = ((System.Drawing.Image)(resources.GetObject("BT_VEICULO.Image")));
            this.BT_VEICULO.Location = new System.Drawing.Point(27, 158);
            this.BT_VEICULO.Name = "BT_VEICULO";
            this.BT_VEICULO.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BT_VEICULO.Size = new System.Drawing.Size(150, 43);
            this.BT_VEICULO.TabIndex = 31;
            this.BT_VEICULO.Text = "VEÍCULO";
            this.BT_VEICULO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_VEICULO.UseVisualStyleBackColor = false;
            this.BT_VEICULO.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_CLIENTE
            // 
            this.BT_CLIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_CLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLIENTE.ForeColor = System.Drawing.Color.White;
            this.BT_CLIENTE.Image = ((System.Drawing.Image)(resources.GetObject("BT_CLIENTE.Image")));
            this.BT_CLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_CLIENTE.Location = new System.Drawing.Point(27, 105);
            this.BT_CLIENTE.Name = "BT_CLIENTE";
            this.BT_CLIENTE.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BT_CLIENTE.Size = new System.Drawing.Size(150, 43);
            this.BT_CLIENTE.TabIndex = 30;
            this.BT_CLIENTE.Text = "CLIENTE";
            this.BT_CLIENTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_CLIENTE.UseVisualStyleBackColor = false;
            this.BT_CLIENTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_CARGO
            // 
            this.BT_CARGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_CARGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CARGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CARGO.ForeColor = System.Drawing.Color.White;
            this.BT_CARGO.Location = new System.Drawing.Point(27, 210);
            this.BT_CARGO.Name = "BT_CARGO";
            this.BT_CARGO.Size = new System.Drawing.Size(150, 43);
            this.BT_CARGO.TabIndex = 32;
            this.BT_CARGO.Text = "CARGO";
            this.BT_CARGO.UseVisualStyleBackColor = false;
            this.BT_CARGO.Click += new System.EventHandler(this.BT_CARGO_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // BT_LOG_FORNECIMENTO
            // 
            this.BT_LOG_FORNECIMENTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_LOG_FORNECIMENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_LOG_FORNECIMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LOG_FORNECIMENTO.ForeColor = System.Drawing.Color.White;
            this.BT_LOG_FORNECIMENTO.Location = new System.Drawing.Point(27, 455);
            this.BT_LOG_FORNECIMENTO.Name = "BT_LOG_FORNECIMENTO";
            this.BT_LOG_FORNECIMENTO.Size = new System.Drawing.Size(150, 43);
            this.BT_LOG_FORNECIMENTO.TabIndex = 33;
            this.BT_LOG_FORNECIMENTO.Text = "LOG FORNECIMENTO";
            this.BT_LOG_FORNECIMENTO.UseVisualStyleBackColor = false;
            this.BT_LOG_FORNECIMENTO.Click += new System.EventHandler(this.BT_LOG_FORNECIMENTO_Click);
            // 
            // BT_FORNECEDOR
            // 
            this.BT_FORNECEDOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_FORNECEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FORNECEDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_FORNECEDOR.ForeColor = System.Drawing.Color.White;
            this.BT_FORNECEDOR.Image = ((System.Drawing.Image)(resources.GetObject("BT_FORNECEDOR.Image")));
            this.BT_FORNECEDOR.Location = new System.Drawing.Point(27, 308);
            this.BT_FORNECEDOR.Name = "BT_FORNECEDOR";
            this.BT_FORNECEDOR.Size = new System.Drawing.Size(150, 43);
            this.BT_FORNECEDOR.TabIndex = 36;
            this.BT_FORNECEDOR.Text = "FORNECEDOR";
            this.BT_FORNECEDOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_FORNECEDOR.UseVisualStyleBackColor = false;
            this.BT_FORNECEDOR.Click += new System.EventHandler(this.BT_FORNECEDOR_Click);
            // 
            // BT_ORCAMENTO
            // 
            this.BT_ORCAMENTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_ORCAMENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ORCAMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ORCAMENTO.ForeColor = System.Drawing.Color.White;
            this.BT_ORCAMENTO.Image = ((System.Drawing.Image)(resources.GetObject("BT_ORCAMENTO.Image")));
            this.BT_ORCAMENTO.Location = new System.Drawing.Point(27, 406);
            this.BT_ORCAMENTO.Name = "BT_ORCAMENTO";
            this.BT_ORCAMENTO.Size = new System.Drawing.Size(150, 43);
            this.BT_ORCAMENTO.TabIndex = 34;
            this.BT_ORCAMENTO.Text = "ORÇAMENTO";
            this.BT_ORCAMENTO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_ORCAMENTO.UseVisualStyleBackColor = false;
            this.BT_ORCAMENTO.Click += new System.EventHandler(this.BT_ORCAMENTO_Click);
            // 
            // BT_FUNCIONARIO
            // 
            this.BT_FUNCIONARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_FUNCIONARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FUNCIONARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_FUNCIONARIO.ForeColor = System.Drawing.Color.White;
            this.BT_FUNCIONARIO.Image = ((System.Drawing.Image)(resources.GetObject("BT_FUNCIONARIO.Image")));
            this.BT_FUNCIONARIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_FUNCIONARIO.Location = new System.Drawing.Point(27, 259);
            this.BT_FUNCIONARIO.Name = "BT_FUNCIONARIO";
            this.BT_FUNCIONARIO.Size = new System.Drawing.Size(150, 43);
            this.BT_FUNCIONARIO.TabIndex = 37;
            this.BT_FUNCIONARIO.Text = "FUNCIONÁRIO";
            this.BT_FUNCIONARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_FUNCIONARIO.UseVisualStyleBackColor = false;
            this.BT_FUNCIONARIO.Click += new System.EventHandler(this.BT_FUNCIONARIO_Click);
            // 
            // BT_PRODUTO
            // 
            this.BT_PRODUTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.BT_PRODUTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PRODUTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_PRODUTO.ForeColor = System.Drawing.Color.White;
            this.BT_PRODUTO.Image = ((System.Drawing.Image)(resources.GetObject("BT_PRODUTO.Image")));
            this.BT_PRODUTO.Location = new System.Drawing.Point(27, 357);
            this.BT_PRODUTO.Name = "BT_PRODUTO";
            this.BT_PRODUTO.Size = new System.Drawing.Size(150, 43);
            this.BT_PRODUTO.TabIndex = 35;
            this.BT_PRODUTO.Text = "PRODUTO";
            this.BT_PRODUTO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_PRODUTO.UseVisualStyleBackColor = false;
            this.BT_PRODUTO.Click += new System.EventHandler(this.BT_PRODUTO_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(206, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(936, 540);
            this.Panel.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(919, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 49);
            this.button1.TabIndex = 31;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fmrsumario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fmrsumario";
            this.Text = "Sumário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fmrsumario_FormClosed);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDevedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_VEICULO;
        private System.Windows.Forms.Button BT_CLIENTE;
        private System.Windows.Forms.Button BT_CARGO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_LOG_FORNECIMENTO;
        private System.Windows.Forms.Button BT_FORNECEDOR;
        private System.Windows.Forms.Button BT_ORCAMENTO;
        private System.Windows.Forms.Button BT_FUNCIONARIO;
        private System.Windows.Forms.Button BT_PRODUTO;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnCaixa;
    }
}

