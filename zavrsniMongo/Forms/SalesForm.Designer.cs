
namespace zavrsniMongo.Forms
{
    partial class SalesForm
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
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.statusRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(59, 160);
            this.salesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.Size = new System.Drawing.Size(960, 436);
            this.salesDataGridView.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = global::zavrsniMongo.Properties.Resources.search;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(59, 94);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(281, 45);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Pretraži po statusu";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeButton.Location = new System.Drawing.Point(939, 14);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 44);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // statusRichTextBox
            // 
            this.statusRichTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusRichTextBox.Location = new System.Drawing.Point(346, 100);
            this.statusRichTextBox.Name = "statusRichTextBox";
            this.statusRichTextBox.Size = new System.Drawing.Size(333, 39);
            this.statusRichTextBox.TabIndex = 10;
            this.statusRichTextBox.Text = "";
            this.statusRichTextBox.TextChanged += new System.EventHandler(this.statusRichTextBox_TextChanged);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1034, 632);
            this.Controls.Add(this.statusRichTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.salesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox statusRichTextBox;
    }
}