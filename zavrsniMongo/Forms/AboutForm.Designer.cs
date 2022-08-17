
namespace zavrsniMongo.Forms
{
    partial class AboutForm
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
            this.aboutAppLabel = new System.Windows.Forms.Label();
            this.aboutCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutAppLabel
            // 
            this.aboutAppLabel.AutoSize = true;
            this.aboutAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutAppLabel.Location = new System.Drawing.Point(25, 57);
            this.aboutAppLabel.Name = "aboutAppLabel";
            this.aboutAppLabel.Size = new System.Drawing.Size(141, 32);
            this.aboutAppLabel.TabIndex = 0;
            this.aboutAppLabel.Text = "O aplikaciji";
            // 
            // aboutCloseButton
            // 
            this.aboutCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.aboutCloseButton.FlatAppearance.BorderSize = 0;
            this.aboutCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutCloseButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.aboutCloseButton.Location = new System.Drawing.Point(729, 8);
            this.aboutCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutCloseButton.Name = "aboutCloseButton";
            this.aboutCloseButton.Size = new System.Drawing.Size(60, 36);
            this.aboutCloseButton.TabIndex = 8;
            this.aboutCloseButton.UseVisualStyleBackColor = false;
            this.aboutCloseButton.Click += new System.EventHandler(this.aboutCloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutCloseButton);
            this.Controls.Add(this.aboutAppLabel);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutAppLabel;
        private System.Windows.Forms.Button aboutCloseButton;
    }
}