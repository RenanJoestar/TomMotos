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
            this.button1 = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_FuncGet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_func)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FuncGet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_func
            // 
            this.dg_func.AllowUserToAddRows = false;
            this.dg_func.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_func.Location = new System.Drawing.Point(12, 12);
            this.dg_func.MultiSelect = false;
            this.dg_func.Name = "dg_func";
            this.dg_func.Size = new System.Drawing.Size(622, 207);
            this.dg_func.TabIndex = 0;
            this.dg_func.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_func_CellClick);
            this.dg_func.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CARGO";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOME";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // dg_FuncGet
            // 
            this.dg_FuncGet.AllowUserToAddRows = false;
            this.dg_FuncGet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_FuncGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_FuncGet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dg_FuncGet.Location = new System.Drawing.Point(12, 282);
            this.dg_FuncGet.Name = "dg_FuncGet";
            this.dg_FuncGet.Size = new System.Drawing.Size(622, 173);
            this.dg_FuncGet.TabIndex = 2;
            this.dg_FuncGet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_FuncGet_CellContentClick);
            // 
            // FmrAddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(646, 496);
            this.Controls.Add(this.dg_FuncGet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_func);
            this.Name = "FmrAddFunc";
            this.Text = "FmrAddFunc";
            this.Load += new System.EventHandler(this.FmrAddFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_func)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_FuncGet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_func;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dg_FuncGet;
    }
}