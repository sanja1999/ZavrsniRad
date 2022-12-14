using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using zavrsniMongo.Models;

namespace zavrsniMongo.Forms
{
    public partial class CustomersForm : Form
    {
        static readonly IMongoCollection<Customer> collection = Connection.db.GetCollection<Customer>("customers");
        public void ReadAllDocuments()
        {
            List<Customer> list = collection.AsQueryable().ToList<Customer>();
            customersDataGridView.DataSource = list;
        }

        public CustomersForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            var sortType = sortTypeComboBox.SelectedItem.ToString();
            var sortValue = sortComboBox.SelectedItem.ToString();
            if (sortValue == "Silazno")
            {

                var filterDefinition = Builders<Customer>.Filter.Empty;
                var sortDefinition = Builders<Customer>.Sort.Ascending(sortType);
                var query = collection.Find(filterDefinition).Sort(sortDefinition).ToList();
                customersDataGridView.DataSource = query;
            }
            else
            {
                var filterDefinition1 = Builders<Customer>.Filter.Empty;
                var filterDefinition = Builders<Customer>.Sort.Descending(sortType);
                var query = collection.Find(filterDefinition1).Sort(filterDefinition).ToList();
                customersDataGridView.DataSource = query;
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sortComboBox.SelectedIndex >= 0 && sortTypeComboBox.SelectedIndex >= 0)
            {
                sortButton.Enabled = true;
            }
            else
            {
                sortButton.Enabled = false;
            }
        }
        private void sortTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortTypeComboBox.SelectedIndex >= 0 && sortComboBox.SelectedIndex >= 0)
            {
                sortButton.Enabled = true;
            }
            else
            {
                sortButton.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ReadAllDocuments();
            sortComboBox.SelectedIndex = -1;
            sortTypeComboBox.SelectedIndex = -1;
        }
    }
}
