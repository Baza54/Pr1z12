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
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();
        }

        private void AccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Num = Convert.ToInt32(NumTb.Text);
                if (1 <= Num && Num <= 9999)
                {
                    OutputLbl.Text = "";

                    if (Num % 2 == 0)
                        OutputLbl.Text += "Четное ";
                    else
                        OutputLbl.Text += "Нечетное ";

                    switch (NumTb.Text.Length)
                    {
                        case 1: OutputLbl.Text += "одно"; break;
                        case 2: OutputLbl.Text += "двух"; break;
                        case 3: OutputLbl.Text += "трех"; break;
                        case 4: OutputLbl.Text += "четырех"; break;
                    }

                    OutputLbl.Text += "значное число";
                }
                else
                    MessageBox.Show("Задано число не из диапозона");
            }
            catch
            {
                MessageBox.Show("Введнено не число");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
