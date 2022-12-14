using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using zavrsniMongo.Models;

namespace zavrsniMongo.Forms
{
    public partial class ItemsForm : Form
    {
        static readonly IMongoCollection<Item> collection = Connection.db.GetCollection<Item>("items");
        public void ReadAllDocuments()
        {
            List<Item> list = collection.AsQueryable().ToList<Item>();
            itemsDataGridView.DataSource = list;

        }

        public ItemsForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void closeItemsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusRichTextBox_TextChanged(object sender, EventArgs e)
        {
            var filter = Builders<Item>.Filter.Regex("description", new MongoDB.Bson.BsonRegularExpression(searchRichTextBox.Text, "i"));
            var query = collection.Find(filter).ToList();
            itemsDataGridView.DataSource = query;
        }
    }
}
