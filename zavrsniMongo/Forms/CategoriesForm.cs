using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using zavrsniMongo.Models;
using System.Configuration;


namespace zavrsniMongo
{
    public partial class CategoriesForm : Form
    {
        static readonly IMongoCollection<Category> collection= Connection.db.GetCollection<Category>("categories");

        public void ReadAllDocuments()
        {
            List<Category> list = collection.AsQueryable().ToList<Category>();
            categoriesDataGridView.DataSource = list;

        }

        public CategoriesForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Builders<SalePayment> filterDefinition;
            var selected = comboBox.Text;
            switch (selected)
            {
                case "PaymentTypeId":
                    var filterDefinition = Builders<SalePayment>.Filter.Eq(a => a.PaymentTypeId, int.Parse(textBox1.Text));
                    break;
                case "Type":
                    var filterDefinition = Builders<SalePayment>.Filter.Eq(a => a.Type, textBox1.Text);
                    break;

                    
            }
            var products = collection.Find(filterDefinition).ToList();
            categoriesDataGridView.DataSource = products;
            */

            /* FILTER KOJI RADI 
            var filterDefinition = Builders<Category>.Filter.Eq(a => a.PaymentTypeId, 72251);
            //var filterDefinition = Builders<SalePayment>.Filter.Eq(a => a.PaymentTypeId, int.Parse(textBox1.Text));
            var products = collection.Find(filterDefinition).ToList();
            categoriesDataGridView.DataSource = products;
            */

            /* SORT KOJI RADI
            var filterDefinition1 = Builders<SalePayment>.Filter.Empty;
            var filterDefinition = Builders<SalePayment>.Sort.Ascending(a => a.Type);
            var products = collection.Find(filterDefinition1).Sort(filterDefinition).ToList();
            categoriesDataGridView.DataSource = products;
            */
        }

        private void LoadData()
        {
            /*
            var filterDefinition = Builders<SalePayment>.Filter.Eq(a => a.Type, "Room");
            var products = collection.Find(filterDefinition).ToList();
            categoriesDataGridView.DataSource = filterDefinition;
            categoriesDataGridView.DataSource = products;
            */
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
