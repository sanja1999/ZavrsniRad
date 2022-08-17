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
    }
}
