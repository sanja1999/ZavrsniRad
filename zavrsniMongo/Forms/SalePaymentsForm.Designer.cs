
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
            this.queryButton = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.RichTextBox();
            this.filterTextBox = new System.Windows.Forms.RichTextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutAppLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salePaymentsDataGridView
            // 
            this.salePaymentsDataGridView.AllowUserToAddRows = false;
            this.salePaymentsDataGridView.AllowUserToDeleteRows = false;
            this.salePaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salePaymentsDataGridView.Location = new System.Drawing.Point(45, 116);
            this.salePaymentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salePaymentsDataGridView.Name = "salePaymentsDataGridView";
            this.salePaymentsDataGridView.ReadOnly = true;
            this.salePaymentsDataGridView.RowTemplate.Height = 24;
            this.salePaymentsDataGridView.Size = new System.Drawing.Size(1070, 347);
            this.salePaymentsDataGridView.TabIndex = 0;
            this.salePaymentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salePaymentsDataGridView_CellClick);
            // 
            // queryButton
            // 
            this.queryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.queryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.queryButton.Enabled = false;
            this.queryButton.FlatAppearance.BorderSize = 0;
            this.queryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryButton.ForeColor = System.Drawing.Color.White;
            this.queryButton.Location = new System.Drawing.Point(1224, 476);
            this.queryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(131, 44);
            this.queryButton.TabIndex = 32;
            this.queryButton.Text = "Filtriraj";
            this.queryButton.UseVisualStyleBackColor = false;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(675, 503);
            this.queryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(177, 61);
            this.queryTextBox.TabIndex = 33;
            this.queryTextBox.Text = "";
            this.queryTextBox.TextChanged += new System.EventHandler(this.queryTextBox_TextChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(349, 503);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(177, 61);
            this.filterTextBox.TabIndex = 34;
            this.filterTextBox.Text = "";
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(184, 503);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(112, 17);
            this.filterLabel.TabIndex = 35;
            this.filterLabel.Text = "Filtriraj po stupcu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "za vrijednost:";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(1224, 541);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(131, 44);
            this.resetButton.TabIndex = 37;
            this.resetButton.Text = "Resertiraj";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeButton.Location = new System.Drawing.Point(1275, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 44);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // aboutAppLabel
            // 
            this.aboutAppLabel.AutoSize = true;
            this.aboutAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutAppLabel.Location = new System.Drawing.Point(39, 56);
            this.aboutAppLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutAppLabel.Name = "aboutAppLabel";
            this.aboutAppLabel.Size = new System.Drawing.Size(110, 32);
            this.aboutAppLabel.TabIndex = 38;
            this.aboutAppLabel.Text = "Plaćanje";
            // 
            // SalePaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1379, 624);
            this.Controls.Add(this.aboutAppLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.salePaymentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalePaymentsForm";
            this.Text = "SalePaymentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.salePaymentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salePaymentsDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.RichTextBox queryTextBox;
        private System.Windows.Forms.RichTextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label aboutAppLabel;
    }
}