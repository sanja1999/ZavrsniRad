using MongoDB.Bson;
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
    public partial class SalePaymentsForm : Form
    {
        static readonly IMongoCollection<SalePayment> collection = Connection.db.GetCollection<SalePayment>("sale_payment");

        public void ReadAllDocuments()
        {
            List<SalePayment> list = collection.AsQueryable().ToList<SalePayment>();
            salePaymentsDataGridView.DataSource = list;

        }
        public SalePaymentsForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            if (filterTextBox.Text == "Type" || filterTextBox.Text == "DeviceId" || filterTextBox.Text == "StatusId")
            {
                var filterDefinition = Builders<SalePayment>.Filter.Eq(filterTextBox.Text, queryTextBox.Text);
                var query = collection.Find(filterDefinition).ToList();
                salePaymentsDataGridView.DataSource = query;
            }
            else
            {
                if(filterTextBox.Text == "Id" || filterTextBox.Text == "Saleid")
                {
                    var filterDefinition = Builders<SalePayment>.Filter.Eq(filterTextBox.Text, ObjectId.Parse(queryTextBox.Text));
                    var query = collection.Find(filterDefinition).ToList();
                    salePaymentsDataGridView.DataSource = query;
                }
                else
                {
                    var filterDefinition = Builders<SalePayment>.Filter.Eq(filterTextBox.Text, int.Parse(queryTextBox.Text));
                    var query = collection.Find(filterDefinition).ToList();
                    salePaymentsDataGridView.DataSource = query;
                }
            }
        }

        private void salePaymentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                queryTextBox.Text = salePaymentsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var currentCell = salePaymentsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                filterTextBox.Text = currentCell.OwningColumn.Name;
            }
            catch(FormatException)
            {
                MessageBox.Show("Molim označite ćelije koje nisu nazivi stupaca");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ReadAllDocuments();
            queryTextBox.Text = String.Empty;
            filterTextBox.Text = String.Empty;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filterTextBox.Text))
            {
                queryButton.Enabled = true;
            }
            else
            {
                queryButton.Enabled = false;
            }
        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(queryTextBox.Text))
            {
                queryButton.Enabled = true;
            }
            else
            {
                queryButton.Enabled = false;
            }
        }
    }
}
