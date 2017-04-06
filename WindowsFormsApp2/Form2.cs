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
    public partial class Form2 : Form
    {
        public static List<bool> checkedB;
        public Form2()
        {
            InitializeComponent();
            init();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            Select select = new Select("localhost", "root", "airplane", "3306", "");
            Form3 form = new Form3();
            Console.WriteLine(form.getId());
            List < string > list = new List<string>(select.SelectS(form.getId()));
            for(int i = 0; i < 71; i++)
            {
                if (Convert.ToBoolean(list[i]))
                {
                    int index = i + 1;
                    string check = "checkBox" + index;
                    CheckBox checkBox = this.Controls.Find(check, true).FirstOrDefault() as CheckBox;
                    checkBox.Checked = true;
                    checkBox.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Select select = new Select("localhost", "root", "airplane", "3306", "");
            setList();
            Form3 form = new Form3();
            select.Update(form.getId());
            MessageBox.Show("Змінено");
            this.Hide();
            new Form1().ShowDialog();
            

        }
        public List<bool> getList()
        {
            return checkedB;
        }

        private void setList()
        {
            List<bool> list = new List<bool>();
            for (int i = 0; i < 71; i++)
            {
                int index = i + 1;
                string check = "checkBox" + index;
                CheckBox checkBox = this.Controls.Find(check, true).FirstOrDefault() as CheckBox;
                list.Add(checkBox.Checked);
            }
            checkedB = list;
        }

       
    }
}
