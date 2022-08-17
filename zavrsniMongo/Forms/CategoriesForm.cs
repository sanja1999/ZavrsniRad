﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using zavrsniMongo.Models;

namespace zavrsniMongo
{
    public partial class CategoriesForm : Form
    {
        static readonly IMongoCollection<Category> collection= Connection.db.GetCollection<Category>("categories");

        public void ReadAllDocuments()
        {
            List<Category> list = collection.AsQueryable().ToList<Category>();
            categoriesDataGridView.DataSource = list;

            idTextBox.Text = categoriesDataGridView.Rows[0].Cells[0].Value.ToString();
            categoryIdTextBox.Text = categoriesDataGridView.Rows[0].Cells[1].Value.ToString();
            nameTextBox.Text = categoriesDataGridView.Rows[0].Cells[2].Value.ToString();
            nodeDepthTextBox.Text = categoriesDataGridView.Rows[0].Cells[3].Value.ToString();
            fullPathNameTextBox.Text = categoriesDataGridView.Rows[0].Cells[4].Value.ToString();
            leftNodeTextBox.Text = categoriesDataGridView.Rows[0].Cells[5].Value.ToString();
            rightNodeTextBox.Text = categoriesDataGridView.Rows[0].Cells[6].Value.ToString();
            parentIdTextBox.Text = categoriesDataGridView.Rows[0].Cells[7].Value.ToString();
            createTimeDateTimePicker.Text = categoriesDataGridView.Rows[0].Cells[8].Value.ToString();
            timeStampDateTimePicker.Text = categoriesDataGridView.Rows[0].Cells[9].Value.ToString();

        }

        public CategoriesForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            categoryIdTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            nodeDepthTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            fullPathNameTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            leftNodeTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            rightNodeTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            parentIdTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            createTimeDateTimePicker.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            timeStampDateTimePicker.Text = categoriesDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category(nameTextBox.Text, int.Parse(nodeDepthTextBox.Text), fullPathNameTextBox.Text,
                int.Parse(leftNodeTextBox.Text), int.Parse(rightNodeTextBox.Text), int.Parse(parentIdTextBox.Text),
                DateTime.Parse(createTimeDateTimePicker.Value.Date.ToString()), DateTime.Parse(timeStampDateTimePicker.Value.Date.ToString()));

                collection.InsertOne(category);
                ReadAllDocuments();
            }
            catch(FormatException)
            {
                MessageBox.Show("Upisano u neispravnom formatu!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var updateDef = Builders<Category>.Update.Set("name", nameTextBox.Text).Set("nodeDepth", nodeDepthTextBox.Text)
                    .Set("fullPathName", fullPathNameTextBox.Text).Set("leftNode", leftNodeTextBox.Text)
                    .Set("rightNode", rightNodeTextBox.Text).Set("parentID", parentIdTextBox.Text)
                    .Set("createTime", DateTime.Parse(createTimeDateTimePicker.Value.Date.ToString())).Set("timeStamp", DateTime.Parse(timeStampDateTimePicker.Value.Date.ToString()));
                collection.UpdateOne(category => category.Id == ObjectId.Parse(idTextBox.Text) && category.CategoryID == int.Parse(categoryIdTextBox.Text), updateDef);
                ReadAllDocuments();
            }
            catch(FormatException)
            {
                MessageBox.Show("Upisano u neispravnom formatu!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(category => category.Id == ObjectId.Parse(idTextBox.Text));
            ReadAllDocuments();
        }
    }
}