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
    }
}
