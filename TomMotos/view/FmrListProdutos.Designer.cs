
namespace TomMotos.view
{
    partial class FmrListProdutos
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
            this.dgListProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListProdutos
            // 
            this.dgListProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgListProdutos.Name = "dgListProdutos";
            this.dgListProdutos.Size = new System.Drawing.Size(800, 450);
            this.dgListProdutos.TabIndex = 0;
            this.dgListProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListProdutos_CellContentDoubleClick);
            
            // 
            // FmrListProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListProdutos);
            this.Name = "FmrListProdutos";
            this.Text = "FmrListProdutos";
            this.Load += new System.EventHandler(this.FmrListProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListProdutos;
    }
}