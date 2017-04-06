using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Select select = new Select("localhost", "root", "airplane", "3306", "");
            select.Insert(textBox1.Text, textBox2.Text);
            MessageBox.Show("Добавлено");
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
