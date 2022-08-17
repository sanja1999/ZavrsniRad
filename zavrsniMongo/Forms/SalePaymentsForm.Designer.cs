
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
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salePaymentsDataGridView
            // 
            this.salePaymentsDataGridView.AllowUserToAddRows = false;
            this.salePaymentsDataGridView.AllowUserToDeleteRows = false;
            this.salePaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salePaymentsDataGridView.Location = new System.Drawing.Point(11, 60);
            this.salePaymentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salePaymentsDataGridView.Name = "salePaymentsDataGridView";
            this.salePaymentsDataGridView.ReadOnly = true;
            this.salePaymentsDataGridView.RowTemplate.Height = 24;
            this.salePaymentsDataGridView.Size = new System.Drawing.Size(540, 286);
            this.salePaymentsDataGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeButton.Location = new System.Drawing.Point(529, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SalePaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.salePaymentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalePaymentsForm";
            this.Text = "SalePaymentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salePaymentsDataGridView;
        private System.Windows.Forms.Button closeButton;
    }
}