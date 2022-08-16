
namespace zavrsniMongo.Forms
{
    partial class SalePaymentsForm
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
            this.salePaymentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salePaymentsDataGridView
            // 
            this.salePaymentsDataGridView.AllowUserToAddRows = false;
            this.salePaymentsDataGridView.AllowUserToDeleteRows = false;
            this.salePaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salePaymentsDataGridView.Location = new System.Drawing.Point(15, 30);
            this.salePaymentsDataGridView.Name = "salePaymentsDataGridView";
            this.salePaymentsDataGridView.ReadOnly = true;
            this.salePaymentsDataGridView.RowTemplate.Height = 24;
            this.salePaymentsDataGridView.Size = new System.Drawing.Size(720, 352);
            this.salePaymentsDataGridView.TabIndex = 0;
            // 
            // SalePaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salePaymentsDataGridView);
            this.Name = "SalePaymentsForm";
            this.Text = "SalePaymentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salePaymentsDataGridView;
    }
}