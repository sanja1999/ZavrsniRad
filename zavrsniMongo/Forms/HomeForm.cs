using System;
using System.Windows.Forms;

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
            newForm.BringToFront();
            newForm.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            openNewForm(new CategoriesForm());
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            openNewForm(new CustomersForm());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuBarTimer.Start();
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

