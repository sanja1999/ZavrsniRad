using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool menuBarExpand = true;
        public Form1()
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuBarTimer.Start();
        }
    }
}
