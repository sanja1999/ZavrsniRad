
namespace zavrsniMongo.Forms
{
    partial class ItemsForm
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
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.closeItemsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(30, 89);
            this.ItemsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowTemplate.Height = 24;
            this.ItemsDataGridView.Size = new System.Drawing.Size(480, 122);
            this.ItemsDataGridView.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeButton.Location = new System.Drawing.Point(842, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 36);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // closeItemsButton
            // 
            this.closeItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeItemsButton.FlatAppearance.BorderSize = 0;
            this.closeItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeItemsButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeItemsButton.Location = new System.Drawing.Point(719, 11);
            this.closeItemsButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeItemsButton.Name = "closeItemsButton";
            this.closeItemsButton.Size = new System.Drawing.Size(60, 36);
            this.closeItemsButton.TabIndex = 6;
            this.closeItemsButton.UseVisualStyleBackColor = false;
            this.closeItemsButton.Click += new System.EventHandler(this.closeItemsButton_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(790, 418);
            this.Controls.Add(this.closeItemsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ItemsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button closeItemsButton;
    }
}