
namespace TomMotos.view
{
    partial class Fmrcargo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgCargo = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txt_salario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 366);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREENCHER DADOS";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(21, 127);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 15);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "* SALARIO:";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(95, 124);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(133, 21);
            this.txt_salario.TabIndex = 24;
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
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.DarkOrange;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.White;
            this.txt_nome.Location = new System.Drawing.Point(95, 84);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(133, 21);
            this.txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "* NOME:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cadastro de Cargo";
            // 
            // dgCargo
            // 
            this.dgCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargo.Location = new System.Drawing.Point(344, 92);
            this.dgCargo.Name = "dgCargo";
            this.dgCargo.Size = new System.Drawing.Size(493, 267);
            this.dgCargo.TabIndex = 20;
            this.dgCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCargo_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(344, 400);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 43);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(540, 400);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 43);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(736, 400);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 43);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(459, 37);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(228, 20);
            this.txtFiltro.TabIndex = 24;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID",
            "NOME"});
            this.cbxBuscar.Location = new System.Drawing.Point(395, 36);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(58, 21);
            this.cbxBuscar.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(710, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Fmrcargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 513);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fmrcargo";
            this.Text = "Fmrcargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fmrcargo_FormClosed);
            this.Load += new System.EventHandler(this.Fmrcargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgCargo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}