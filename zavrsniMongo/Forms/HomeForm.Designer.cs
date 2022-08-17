﻿
namespace zavrsniMongo.Forms
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customerButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.itemButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.salePaymentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.menuBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelNewForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelNewForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menuBar.Controls.Add(this.panel1);
            this.menuBar.Controls.Add(this.HomeContainer);
            this.menuBar.Controls.Add(this.panel3);
            this.menuBar.Controls.Add(this.panel4);
            this.menuBar.Controls.Add(this.panel5);
            this.menuBar.Controls.Add(this.panel6);
            this.menuBar.Controls.Add(this.panel2);
            this.menuBar.Controls.Add(this.panel7);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.MaximumSize = new System.Drawing.Size(210, 550);
            this.menuBar.MinimumSize = new System.Drawing.Size(58, 550);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(210, 550);
            this.menuBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 81);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "  Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::zavrsniMongo.Properties.Resources.Menu1;
            this.menuButton.Location = new System.Drawing.Point(9, 24);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(32, 30);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.HomeContainer.Controls.Add(this.buttonHome);
            this.HomeContainer.Location = new System.Drawing.Point(3, 90);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(197, 47);
            this.HomeContainer.TabIndex = 2;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(197, 47);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "           Početna";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.categoriesButton);
            this.panel3.Location = new System.Drawing.Point(3, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 47);
            this.panel3.TabIndex = 3;
            // 
            // categoriesButton
            // 
            this.categoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.Image = global::zavrsniMongo.Properties.Resources.category;
            this.categoriesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.Location = new System.Drawing.Point(0, 0);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.categoriesButton.Size = new System.Drawing.Size(197, 47);
            this.categoriesButton.TabIndex = 1;
            this.categoriesButton.Text = "           Categories";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.customerButton);
            this.panel4.Location = new System.Drawing.Point(3, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 47);
            this.panel4.TabIndex = 4;
            // 
            // customerButton
            // 
            this.customerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(0, 0);
            this.customerButton.Name = "customerButton";
            this.customerButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.customerButton.Size = new System.Drawing.Size(197, 47);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "           Customer";
            this.customerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.itemButton);
            this.panel5.Location = new System.Drawing.Point(3, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 47);
            this.panel5.TabIndex = 3;
            // 
            // itemButton
            // 
            this.itemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemButton.FlatAppearance.BorderSize = 0;
            this.itemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemButton.ForeColor = System.Drawing.Color.White;
            this.itemButton.Image = global::zavrsniMongo.Properties.Resources.item;
            this.itemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemButton.Location = new System.Drawing.Point(0, 0);
            this.itemButton.Name = "itemButton";
            this.itemButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.itemButton.Size = new System.Drawing.Size(197, 47);
            this.itemButton.TabIndex = 1;
            this.itemButton.Text = "           Proizvodi";
            this.itemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.salePaymentButton);
            this.panel6.Location = new System.Drawing.Point(3, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 47);
            this.panel6.TabIndex = 5;
            // 
            // salePaymentButton
            // 
            this.salePaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salePaymentButton.FlatAppearance.BorderSize = 0;
            this.salePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salePaymentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePaymentButton.ForeColor = System.Drawing.Color.White;
            this.salePaymentButton.Image = global::zavrsniMongo.Properties.Resources.salePayment;
            this.salePaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salePaymentButton.Location = new System.Drawing.Point(0, 0);
            this.salePaymentButton.Name = "salePaymentButton";
            this.salePaymentButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.salePaymentButton.Size = new System.Drawing.Size(197, 47);
            this.salePaymentButton.TabIndex = 1;
            this.salePaymentButton.Text = "           Plaćanje";
            this.salePaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salePaymentButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saleButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 47);
            this.panel2.TabIndex = 6;
            // 
            // saleButton
            // 
            this.saleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saleButton.FlatAppearance.BorderSize = 0;
            this.saleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.ForeColor = System.Drawing.Color.White;
            this.saleButton.Image = global::zavrsniMongo.Properties.Resources.sale;
            this.saleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.Location = new System.Drawing.Point(0, 0);
            this.saleButton.Name = "saleButton";
            this.saleButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.saleButton.Size = new System.Drawing.Size(197, 47);
            this.saleButton.TabIndex = 2;
            this.saleButton.Text = "           Prodano";
            this.saleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-23, 9);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(224, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "           ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.aboutButton);
            this.panel7.Location = new System.Drawing.Point(3, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 47);
            this.panel7.TabIndex = 7;
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = global::zavrsniMongo.Properties.Resources.about;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 0);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(197, 47);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "           O aplikaciji";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // menuBarTimer
            // 
            this.menuBarTimer.Interval = 10;
            this.menuBarTimer.Tick += new System.EventHandler(this.menuBarTimer_Tick);
            // 
            // panelNewForm
            // 
            this.panelNewForm.AutoSize = true;
            this.panelNewForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.panelNewForm.Controls.Add(this.pictureBox1);
            this.panelNewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewForm.Location = new System.Drawing.Point(210, 0);
            this.panelNewForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelNewForm.Name = "panelNewForm";
            this.panelNewForm.Size = new System.Drawing.Size(409, 550);
            this.panelNewForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::zavrsniMongo.Properties.Resources.MongoDBFinal;
            this.pictureBox1.Location = new System.Drawing.Point(60, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 550);
            this.Controls.Add(this.panelNewForm);
            this.Controls.Add(this.menuBar);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.menuBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelNewForm.ResumeLayout(false);
            this.panelNewForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button salePaymentButton;
        public System.Windows.Forms.Timer menuBarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Panel panelNewForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
