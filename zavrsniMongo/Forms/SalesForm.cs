using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zavrsniMongo.Models;

namespace zavrsniMongo.Forms
{
    public partial class SalesForm : Form
    {
        static readonly IMongoCollection<Sale> collection = Connection.db.GetCollection<Sale>("sales2");

        public void ReadAllDocuments()
        {
            List<Sale> list = collection.AsQueryable().ToList<Sale>();
            salesDataGridView.DataSource = list;

        }
        public SalesForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //var filterDefinition = Builders<Sale>.Filter.Eq(a => a.Status.Contains(searchTextBox.Text), searchTextBox.Text);
            //var query = collection.Find(filterDefinition).ToList();

            // TOČAN REG EX var filter = Builders<Sale>.Filter.Regex("saleid", new MongoDB.Bson.BsonRegularExpression(searchTextBox.Text));
            
            var filter = Builders<Sale>.Filter.Regex("status", new MongoDB.Bson.BsonRegularExpression(searchTextBox.Text, "i"));
            var query =collection.Find(filter).ToList();
            salesDataGridView.DataSource = query;
            
        }
        */

        private void statusRichTextBox_TextChanged(object sender, EventArgs e)
        {
            var filter = Builders<Sale>.Filter.Regex("status", new MongoDB.Bson.BsonRegularExpression(statusRichTextBox.Text, "i"));
            var query = collection.Find(filter).ToList();
            salesDataGridView.DataSource = query;
        }
    }
}
