namespace TomMotos.view
{
    partial class Fmrcaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmrcaixa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtPrU = new System.Windows.Forms.TextBox();
            this.txtPt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDescServ = new System.Windows.Forms.RichTextBox();
            this.txt_pmo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_desconto_pro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ptb_imagem = new System.Windows.Forms.PictureBox();
            this.btnFinalizaVenda = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.ch_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServicos = new System.Windows.Forms.DataGridView();
            this.ch_itemServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_vl_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndesconto = new System.Windows.Forms.Button();
            this.btnCancelDesc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_id_veiculo = new System.Windows.Forms.Label();
            this.lbl_fk_cliente = new System.Windows.Forms.Label();
            this.lbl_BuscarVeiculo = new System.Windows.Forms.Label();
            this.lbl_buscarCliente = new System.Windows.Forms.Label();
            this.lblSubitotal = new System.Windows.Forms.Label();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.btn_buscarVeiculo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxOrcamento = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1057, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COD. PRODUTO";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(35, 32);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(243, 20);
            this.txtIdProduto.TabIndex = 4;
            this.txtIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdProduto_KeyDown);
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProduto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUANTIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "PREÇO UNITARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "PREÇO TOTAL";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(35, 71);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(243, 20);
            this.txtqtd.TabIndex = 10;
            this.txtqtd.Text = "1";
            this.txtqtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqtd_KeyDown);
            this.txtqtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtd_KeyPress);
            this.txtqtd.Leave += new System.EventHandler(this.txtqtd_Leave);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(1066, 464);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(102, 20);
            this.txtdesc.TabIndex = 11;
            this.txtdesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesc_KeyDown);
            this.txtdesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesc_KeyPress);
            // 
            // txtPrU
            // 
            this.txtPrU.Location = new System.Drawing.Point(35, 149);
            this.txtPrU.Name = "txtPrU";
            this.txtPrU.Size = new System.Drawing.Size(243, 20);
            this.txtPrU.TabIndex = 12;
            this.txtPrU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrU_KeyDown);
            // 
            // txtPt
            // 
            this.txtPt.Location = new System.Drawing.Point(35, 189);
            this.txtPt.Name = "txtPt";
            this.txtPt.Size = new System.Drawing.Size(243, 20);
            this.txtPt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtDescServ);
            this.groupBox1.Controls.Add(this.txt_pmo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(849, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 215);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviço";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(2, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "F6";
            // 
            // txtDescServ
            // 
            this.txtDescServ.Location = new System.Drawing.Point(24, 32);
            this.txtDescServ.Name = "txtDescServ";
            this.txtDescServ.Size = new System.Drawing.Size(299, 104);
            this.txtDescServ.TabIndex = 21;
            this.txtDescServ.Text = "";
            this.txtDescServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescServ_KeyDown);
            // 
            // txt_pmo
            // 
            this.txt_pmo.Location = new System.Drawing.Point(24, 155);
            this.txt_pmo.Name = "txt_pmo";
            this.txt_pmo.Size = new System.Drawing.Size(254, 20);
            this.txt_pmo.TabIndex = 13;
            this.txt_pmo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pmo_KeyDown);
            this.txt_pmo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pmo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "PREÇO DA MÃO DE OBRA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DESCRIÇÃO DO SERVIÇO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisarProduto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_desconto_pro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIdProduto);
            this.groupBox2.Controls.Add(this.txtPt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrU);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(326, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 244);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.BackgroundImage")));
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(284, 29);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(41, 24);
            this.btnPesquisarProduto.TabIndex = 44;
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "F6";
            // 
            // txt_desconto_pro
            // 
            this.txt_desconto_pro.Location = new System.Drawing.Point(35, 110);
            this.txt_desconto_pro.Name = "txt_desconto_pro";
            this.txt_desconto_pro.Size = new System.Drawing.Size(243, 20);
            this.txt_desconto_pro.TabIndex = 22;
            this.txt_desconto_pro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_desconto_pro_KeyDown);
            this.txt_desconto_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desconto_pro_KeyPress);
            this.txt_desconto_pro.Leave += new System.EventHandler(this.txt_desconto_pro_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "DESCONTO (%)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ptb_imagem);
            this.groupBox3.Location = new System.Drawing.Point(12, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 197);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMAGEM";
            // 
            // ptb_imagem
            // 
            this.ptb_imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_imagem.Location = new System.Drawing.Point(8, 18);
            this.ptb_imagem.Name = "ptb_imagem";
            this.ptb_imagem.Size = new System.Drawing.Size(202, 173);
            this.ptb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_imagem.TabIndex = 5;
            this.ptb_imagem.TabStop = false;
            // 
            // btnFinalizaVenda
            // 
            this.btnFinalizaVenda.Location = new System.Drawing.Point(1006, 515);
            this.btnFinalizaVenda.Name = "btnFinalizaVenda";
            this.btnFinalizaVenda.Size = new System.Drawing.Size(166, 56);
            this.btnFinalizaVenda.TabIndex = 24;
            this.btnFinalizaVenda.Text = "Finalizar venda";
            this.btnFinalizaVenda.UseVisualStyleBackColor = true;
            this.btnFinalizaVenda.Click += new System.EventHandler(this.btnFinalizaVenda_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_item,
            this.ch_id,
            this.ch_desc,
            this.ch_qtd,
            this.ch_unit,
            this.vl_item,
            this.Column6});
            this.dgProdutos.Location = new System.Drawing.Point(12, 272);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(734, 170);
            this.dgProdutos.TabIndex = 25;
            this.dgProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProdutos_KeyDown);
            this.dgProdutos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgProdutos_MouseDown);
            // 
            // ch_item
            // 
            this.ch_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ch_item.HeaderText = "ITEM";
            this.ch_item.Name = "ch_item";
            // 
            // ch_id
            // 
            this.ch_id.HeaderText = "CODIGO";
            this.ch_id.Name = "ch_id";
            // 
            // ch_desc
            // 
            this.ch_desc.HeaderText = "DESCRIÇÃO";
            this.ch_desc.Name = "ch_desc";
            // 
            // ch_qtd
            // 
            this.ch_qtd.HeaderText = "QTD";
            this.ch_qtd.Name = "ch_qtd";
            // 
            // ch_unit
            // 
            this.ch_unit.HeaderText = "VL.UNIT.(R$)";
            this.ch_unit.Name = "ch_unit";
            // 
            // vl_item
            // 
            this.vl_item.HeaderText = "DESCONTO(%)";
            this.vl_item.Name = "vl_item";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "VL.ITEM.(R$)";
            this.Column6.Name = "Column6";
            // 
            // dgServicos
            // 
            this.dgServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_itemServ,
            this.ch_des,
            this.ch_vl_ser});
            this.dgServicos.Location = new System.Drawing.Point(801, 272);
            this.dgServicos.Name = "dgServicos";
            this.dgServicos.Size = new System.Drawing.Size(455, 170);
            this.dgServicos.TabIndex = 26;
            this.dgServicos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgServicos_KeyDown);
            this.dgServicos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgServicos_MouseDown);
            // 
            // ch_itemServ
            // 
            this.ch_itemServ.HeaderText = "ITEM";
            this.ch_itemServ.Name = "ch_itemServ";
            // 
            // ch_des
            // 
            this.ch_des.HeaderText = "DESCRIÇÃO";
            this.ch_des.Name = "ch_des";
            // 
            // ch_vl_ser
            // 
            this.ch_vl_ser.HeaderText = "VALOR(R$)";
            this.ch_vl_ser.Name = "ch_vl_ser";
            // 
            // btndesconto
            // 
            this.btndesconto.Location = new System.Drawing.Point(1178, 461);
            this.btndesconto.Name = "btndesconto";
            this.btndesconto.Size = new System.Drawing.Size(78, 23);
            this.btndesconto.TabIndex = 28;
            this.btndesconto.Text = "CALCULAR";
            this.btndesconto.UseVisualStyleBackColor = true;
            this.btndesconto.Click += new System.EventHandler(this.button1_Click_1);
            this.btndesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btndesconto_KeyDown);
            // 
            // btnCancelDesc
            // 
            this.btnCancelDesc.Location = new System.Drawing.Point(1262, 461);
            this.btnCancelDesc.Name = "btnCancelDesc";
            this.btnCancelDesc.Size = new System.Drawing.Size(57, 23);
            this.btnCancelDesc.TabIndex = 29;
            this.btnCancelDesc.Text = "CANCELAR";
            this.btnCancelDesc.UseVisualStyleBackColor = true;
            this.btnCancelDesc.Click += new System.EventHandler(this.button2_Click);
            this.btnCancelDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancelDesc_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "PRESSIONE ENTER PARA ADD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(36, 596);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "F5: FINALIZAR VENDA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Veiculo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Cliente";
            // 
            // lbl_id_veiculo
            // 
            this.lbl_id_veiculo.AutoSize = true;
            this.lbl_id_veiculo.Location = new System.Drawing.Point(53, 208);
            this.lbl_id_veiculo.Name = "lbl_id_veiculo";
            this.lbl_id_veiculo.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_veiculo.TabIndex = 36;
            // 
            // lbl_fk_cliente
            // 
            this.lbl_fk_cliente.AutoSize = true;
            this.lbl_fk_cliente.Location = new System.Drawing.Point(56, 237);
            this.lbl_fk_cliente.Name = "lbl_fk_cliente";
            this.lbl_fk_cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_fk_cliente.TabIndex = 37;
            // 
            // lbl_BuscarVeiculo
            // 
            this.lbl_BuscarVeiculo.AutoSize = true;
            this.lbl_BuscarVeiculo.Location = new System.Drawing.Point(56, 208);
            this.lbl_BuscarVeiculo.Name = "lbl_BuscarVeiculo";
            this.lbl_BuscarVeiculo.Size = new System.Drawing.Size(21, 13);
            this.lbl_BuscarVeiculo.TabIndex = 40;
            this.lbl_BuscarVeiculo.Text = "(id)";
            // 
            // lbl_buscarCliente
            // 
            this.lbl_buscarCliente.AutoSize = true;
            this.lbl_buscarCliente.Location = new System.Drawing.Point(53, 238);
            this.lbl_buscarCliente.Name = "lbl_buscarCliente";
            this.lbl_buscarCliente.Size = new System.Drawing.Size(21, 13);
            this.lbl_buscarCliente.TabIndex = 41;
            this.lbl_buscarCliente.Text = "(id)";
            // 
            // lblSubitotal
            // 
            this.lblSubitotal.AutoSize = true;
            this.lblSubitotal.Location = new System.Drawing.Point(1129, 499);
            this.lblSubitotal.Name = "lblSubitotal";
            this.lblSubitotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubitotal.TabIndex = 43;
            this.lblSubitotal.Text = "0";
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCliente.BackgroundImage")));
            this.btn_BuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(100, 232);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(41, 24);
            this.btn_BuscarCliente.TabIndex = 39;
            this.btn_BuscarCliente.UseVisualStyleBackColor = false;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            this.btn_BuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_BuscarCliente_KeyDown);
            // 
            // btn_buscarVeiculo
            // 
            this.btn_buscarVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscarVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarVeiculo.BackgroundImage")));
            this.btn_buscarVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscarVeiculo.Location = new System.Drawing.Point(100, 202);
            this.btn_buscarVeiculo.Name = "btn_buscarVeiculo";
            this.btn_buscarVeiculo.Size = new System.Drawing.Size(41, 24);
            this.btn_buscarVeiculo.TabIndex = 38;
            this.btn_buscarVeiculo.UseVisualStyleBackColor = false;
            this.btn_buscarVeiculo.Click += new System.EventHandler(this.btn_buscarVeiculo_Click);
            this.btn_buscarVeiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_buscarVeiculo_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(162, 596);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "DEL: EXCLUIR ITEM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(293, 596);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "F6: QUANTIDADE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(406, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "ENTER: ADICIONAR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(542, 595);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "F2: PROCURAR PRODUTO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(705, 595);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "CTRL+V: PESQUISAR VEICULO";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(888, 595);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(164, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "CTRL+C: PESQUISAR CLIENTE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(1067, 596);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "CTRL+S: SERVIÇO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "DESCONTO (%)";
            // 
            // cBoxOrcamento
            // 
            this.cBoxOrcamento.AutoSize = true;
            this.cBoxOrcamento.Location = new System.Drawing.Point(1200, 12);
            this.cBoxOrcamento.Name = "cBoxOrcamento";
            this.cBoxOrcamento.Size = new System.Drawing.Size(86, 17);
            this.cBoxOrcamento.TabIndex = 52;
            this.cBoxOrcamento.Text = "É orçamento";
            this.cBoxOrcamento.UseVisualStyleBackColor = true;
            // 
            // Fmrcaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 635);
            this.Controls.Add(this.cBoxOrcamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSubitotal);
            this.Controls.Add(this.lbl_buscarCliente);
            this.Controls.Add(this.lbl_BuscarVeiculo);
            this.Controls.Add(this.btn_BuscarCliente);
            this.Controls.Add(this.btn_buscarVeiculo);
            this.Controls.Add(this.lbl_fk_cliente);
            this.Controls.Add(this.lbl_id_veiculo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelDesc);
            this.Controls.Add(this.btndesconto);
            this.Controls.Add(this.dgServicos);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnFinalizaVenda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Fmrcaixa";
            this.Load += new System.EventHandler(this.Fmrcaixa_Load);
            this.Shown += new System.EventHandler(this.Fmrcaixa_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fmrcaixa_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fmrcaixa_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_imagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtPrU;
        private System.Windows.Forms.TextBox txtPt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_pmo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtDescServ;
        private System.Windows.Forms.Button btnFinalizaVenda;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridView dgServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_itemServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_vl_ser;
        private System.Windows.Forms.Button btndesconto;
        private System.Windows.Forms.Button btnCancelDesc;
        private System.Windows.Forms.TextBox txt_desconto_pro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_id_veiculo;
        private System.Windows.Forms.Label lbl_fk_cliente;
        private System.Windows.Forms.Button btn_buscarVeiculo;
        private System.Windows.Forms.Button btn_BuscarCliente;
        public System.Windows.Forms.Label lbl_BuscarVeiculo;
        public System.Windows.Forms.Label lbl_buscarCliente;
        public System.Windows.Forms.Label lblSubitotal;
        private System.Windows.Forms.Button btnPesquisarProduto;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBoxOrcamento;
    }
}