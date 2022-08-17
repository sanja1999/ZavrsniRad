
using System.Windows.Forms;

namespace zavrsniMongo
{
    partial class CategoriesForm
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
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nodeDepthLabel = new System.Windows.Forms.Label();
            this.fullPathNameLabel = new System.Windows.Forms.Label();
            this.leftNodeLabel = new System.Windows.Forms.Label();
            this.categoryIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nodeDepthTextBox = new System.Windows.Forms.TextBox();
            this.fullPathNameTextBox = new System.Windows.Forms.TextBox();
            this.leftNodeTextBox = new System.Windows.Forms.TextBox();
            this.rightNodeTextBox = new System.Windows.Forms.TextBox();
            this.parentIdTextBox = new System.Windows.Forms.TextBox();
            this.createTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeStampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rightNodeLabel = new System.Windows.Forms.Label();
            this.parentIdLabel = new System.Windows.Forms.Label();
            this.createTimeLabel = new System.Windows.Forms.Label();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToAddRows = false;
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Location = new System.Drawing.Point(28, 59);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            this.categoriesDataGridView.Size = new System.Drawing.Size(860, 214);
            this.categoriesDataGridView.TabIndex = 0;
            this.categoriesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDataGridView_CellClick);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::zavrsniMongo.Properties.Resources.imageedit_45_8938306716;
            this.closeButton.Location = new System.Drawing.Point(878, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(28, 363);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 15);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(28, 379);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(63, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(108, 363);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(68, 15);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "CategoryId:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(182, 363);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            // 
            // nodeDepthLabel
            // 
            this.nodeDepthLabel.AutoSize = true;
            this.nodeDepthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeDepthLabel.Location = new System.Drawing.Point(263, 363);
            this.nodeDepthLabel.Name = "nodeDepthLabel";
            this.nodeDepthLabel.Size = new System.Drawing.Size(71, 15);
            this.nodeDepthLabel.TabIndex = 12;
            this.nodeDepthLabel.Text = "NodeDepth:";
            // 
            // fullPathNameLabel
            // 
            this.fullPathNameLabel.AutoSize = true;
            this.fullPathNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullPathNameLabel.Location = new System.Drawing.Point(340, 363);
            this.fullPathNameLabel.Name = "fullPathNameLabel";
            this.fullPathNameLabel.Size = new System.Drawing.Size(85, 15);
            this.fullPathNameLabel.TabIndex = 14;
            this.fullPathNameLabel.Text = "FullPathName:";
            // 
            // leftNodeLabel
            // 
            this.leftNodeLabel.AutoSize = true;
            this.leftNodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftNodeLabel.Location = new System.Drawing.Point(422, 363);
            this.leftNodeLabel.Name = "leftNodeLabel";
            this.leftNodeLabel.Size = new System.Drawing.Size(59, 15);
            this.leftNodeLabel.TabIndex = 16;
            this.leftNodeLabel.Text = "LeftNode:";
            // 
            // categoryIdTextBox
            // 
            this.categoryIdTextBox.Location = new System.Drawing.Point(106, 379);
            this.categoryIdTextBox.Name = "categoryIdTextBox";
            this.categoryIdTextBox.Size = new System.Drawing.Size(63, 20);
            this.categoryIdTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(185, 379);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(63, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // nodeDepthTextBox
            // 
            this.nodeDepthTextBox.Location = new System.Drawing.Point(265, 379);
            this.nodeDepthTextBox.Name = "nodeDepthTextBox";
            this.nodeDepthTextBox.Size = new System.Drawing.Size(63, 20);
            this.nodeDepthTextBox.TabIndex = 19;
            // 
            // fullPathNameTextBox
            // 
            this.fullPathNameTextBox.Location = new System.Drawing.Point(343, 379);
            this.fullPathNameTextBox.Name = "fullPathNameTextBox";
            this.fullPathNameTextBox.Size = new System.Drawing.Size(63, 20);
            this.fullPathNameTextBox.TabIndex = 20;
            // 
            // leftNodeTextBox
            // 
            this.leftNodeTextBox.Location = new System.Drawing.Point(422, 379);
            this.leftNodeTextBox.Name = "leftNodeTextBox";
            this.leftNodeTextBox.Size = new System.Drawing.Size(63, 20);
            this.leftNodeTextBox.TabIndex = 21;
            // 
            // rightNodeTextBox
            // 
            this.rightNodeTextBox.Location = new System.Drawing.Point(503, 379);
            this.rightNodeTextBox.Name = "rightNodeTextBox";
            this.rightNodeTextBox.Size = new System.Drawing.Size(63, 20);
            this.rightNodeTextBox.TabIndex = 22;
            // 
            // parentIdTextBox
            // 
            this.parentIdTextBox.Location = new System.Drawing.Point(581, 379);
            this.parentIdTextBox.Name = "parentIdTextBox";
            this.parentIdTextBox.Size = new System.Drawing.Size(63, 20);
            this.parentIdTextBox.TabIndex = 23;
            // 
            // createTimeDateTimePicker
            // 
            this.createTimeDateTimePicker.CustomFormat = "";
            this.createTimeDateTimePicker.Location = new System.Drawing.Point(657, 381);
            this.createTimeDateTimePicker.Name = "createTimeDateTimePicker";
            this.createTimeDateTimePicker.Size = new System.Drawing.Size(63, 20);
            this.createTimeDateTimePicker.TabIndex = 25;
            this.createTimeDateTimePicker.Value = new System.DateTime(2022, 8, 4, 0, 0, 0, 0);
            // 
            // timeStampDateTimePicker
            // 
            this.timeStampDateTimePicker.CustomFormat = "YYYY-mm-dd THH:MM:ss";
            this.timeStampDateTimePicker.Location = new System.Drawing.Point(737, 379);
            this.timeStampDateTimePicker.Name = "timeStampDateTimePicker";
            this.timeStampDateTimePicker.Size = new System.Drawing.Size(63, 20);
            this.timeStampDateTimePicker.TabIndex = 26;
            // 
            // rightNodeLabel
            // 
            this.rightNodeLabel.AutoSize = true;
            this.rightNodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightNodeLabel.Location = new System.Drawing.Point(499, 363);
            this.rightNodeLabel.Name = "rightNodeLabel";
            this.rightNodeLabel.Size = new System.Drawing.Size(67, 15);
            this.rightNodeLabel.TabIndex = 27;
            this.rightNodeLabel.Text = "RightNode:";
            // 
            // parentIdLabel
            // 
            this.parentIdLabel.AutoSize = true;
            this.parentIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentIdLabel.Location = new System.Drawing.Point(578, 363);
            this.parentIdLabel.Name = "parentIdLabel";
            this.parentIdLabel.Size = new System.Drawing.Size(54, 15);
            this.parentIdLabel.TabIndex = 28;
            this.parentIdLabel.Text = "ParentId:";
            // 
            // createTimeLabel
            // 
            this.createTimeLabel.AutoSize = true;
            this.createTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTimeLabel.Location = new System.Drawing.Point(654, 363);
            this.createTimeLabel.Name = "createTimeLabel";
            this.createTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.createTimeLabel.TabIndex = 29;
            this.createTimeLabel.Text = "CreateTime:";
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStampLabel.Location = new System.Drawing.Point(734, 363);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(70, 15);
            this.timeStampLabel.TabIndex = 30;
            this.timeStampLabel.Text = "TimeStamp:";
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.insertButton.FlatAppearance.BorderSize = 0;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(544, 449);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(98, 36);
            this.insertButton.TabIndex = 31;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(667, 449);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 36);
            this.updateButton.TabIndex = 32;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(790, 449);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 36);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(949, 531);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.timeStampLabel);
            this.Controls.Add(this.createTimeLabel);
            this.Controls.Add(this.parentIdLabel);
            this.Controls.Add(this.rightNodeLabel);
            this.Controls.Add(this.timeStampDateTimePicker);
            this.Controls.Add(this.createTimeDateTimePicker);
            this.Controls.Add(this.parentIdTextBox);
            this.Controls.Add(this.rightNodeTextBox);
            this.Controls.Add(this.leftNodeTextBox);
            this.Controls.Add(this.fullPathNameTextBox);
            this.Controls.Add(this.nodeDepthTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.categoryIdTextBox);
            this.Controls.Add(this.leftNodeLabel);
            this.Controls.Add(this.fullPathNameLabel);
            this.Controls.Add(this.nodeDepthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.categoriesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.Button closeButton;
        private Label idLabel;
        private TextBox idTextBox;
        private Label categoryLabel;
        private Label nameLabel;
        private Label nodeDepthLabel;
        private Label fullPathNameLabel;
        private Label leftNodeLabel;
        private TextBox categoryIdTextBox;
        private TextBox nameTextBox;
        private TextBox nodeDepthTextBox;
        private TextBox fullPathNameTextBox;
        private TextBox leftNodeTextBox;
        private TextBox rightNodeTextBox;
        private TextBox parentIdTextBox;
        private DateTimePicker createTimeDateTimePicker;
        private DateTimePicker timeStampDateTimePicker;
        private Label rightNodeLabel;
        private Label parentIdLabel;
        private Label createTimeLabel;
        private Label timeStampLabel;
        private Button insertButton;
        private Button updateButton;
        private Button deleteButton;
    }
}