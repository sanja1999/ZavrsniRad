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
    }
}
