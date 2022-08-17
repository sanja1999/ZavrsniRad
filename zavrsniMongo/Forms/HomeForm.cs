using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zavrsniMongo.Forms;

namespace zavrsniMongo.Forms
{
    public partial class HomeForm : Form
    {
        bool menuBarExpand = true;
        public HomeForm()
        {
            InitializeComponent();
        }
        private void menuBarTimer_Tick(object sender, EventArgs e)
        {
            if (menuBarExpand)
            {
                menuBar.Width -= 10;
                if (menuBar.Width == menuBar.MinimumSize.Width)
                {
                    menuBarExpand = false;
                    menuBarTimer.Stop();
                }
                //menuBarExpand = true;
            }
            else
            {
                menuBar.Width += 10;
                if (menuBar.Width == menuBar.MaximumSize.Width)
                {
                    menuBarExpand = true;
                    menuBarTimer.Stop();
                }
            }
        }

        private Form activeForm = null;
        // open forms in container panel
        private void openNewForm(Form newForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelNewForm.Controls.Add(newForm);
            panelNewForm.Tag = newForm;
            // in case put logo on panel
            newForm.BringToFront();
            newForm.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            openNewForm(new CategoriesForm());
            //CategoriesForm form = new CategoriesForm();
            //form.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            openNewForm(new CustomersForm());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuBarTimer.Start();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            openNewForm(new HomeForm());
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            openNewForm(new ItemsForm());
        }

        private void salePaymentButton_Click(object sender, EventArgs e)
        {
            openNewForm(new SalePaymentsForm());
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            openNewForm(new SalesForm());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            openNewForm(new AboutForm());
        }
    }
}

