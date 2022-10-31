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
    public partial class Ex2Form : Form
    {
        public Ex2Form()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void AccBtn_Click(object sender, EventArgs e)
        {
            int res = 0;
            char[] Alph = { 'а', 'у', 'о', 'ы', 'э', 'я', 'ю', 'ё', 'и', 'е' };
            char[] Line = MainTb.Text.ToLower().Replace(" ", "").ToCharArray();
            foreach (char ch in Line)
                foreach (char al in Alph)
                    if (ch == al)
                    {
                        res++;
                        break;
                    }

            OutputLbl.Text = res.ToString();
        }
    }
}
