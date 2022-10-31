using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ex1btn_Click(object sender, EventArgs e)
        {
            Ex1Form ex1 = new Ex1Form();
            this.Hide();
            ex1.ShowDialog();
            this.Close();
        }

        private void Ex2btn_Click(object sender, EventArgs e)
        {
            Ex2Form ex2 = new Ex2Form();
            this.Hide();
            ex2.ShowDialog();
            this.Close();
        }
    }
}
