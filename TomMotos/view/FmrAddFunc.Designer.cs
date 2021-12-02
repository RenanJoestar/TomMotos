namespace TomMotos.view
{
    partial class FmrAddFunc
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
            this.dg_func = new System.Windows.Forms.DataGridView();
            this.dg_FuncGet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_func)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FuncGet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_func
            // 
            this.dg_func.AllowUserToAddRows = false;
            this.dg_func.AllowUserToDeleteRows = false;
            this.dg_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_func.Location = new System.Drawing.Point(12, 12);
            this.dg_func.Name = "dg_func";
            this.dg_func.Size = new System.Drawing.Size(482, 150);
            this.dg_func.TabIndex = 0;
            this.dg_func.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_func_CellContentClick);
            // 
            // dg_FuncGet
            // 
            this.dg_FuncGet.AllowUserToAddRows = false;
            this.dg_FuncGet.AllowUserToDeleteRows = false;
            this.dg_FuncGet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_FuncGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_FuncGet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dg_FuncGet.Location = new System.Drawing.Point(12, 194);
            this.dg_FuncGet.Name = "dg_FuncGet";
            this.dg_FuncGet.Size = new System.Drawing.Size(482, 150);
            this.dg_FuncGet.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOME";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CARGO";
            this.Column3.Name = "Column3";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FmrAddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dg_FuncGet);
            this.Controls.Add(this.dg_func);
            this.Name = "FmrAddFunc";
            this.Text = "FmrAddFunc";
            this.Load += new System.EventHandler(this.FmrAddFunc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dg_func)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FuncGet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_func;
        private System.Windows.Forms.DataGridView dg_FuncGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAdd;
    }
}