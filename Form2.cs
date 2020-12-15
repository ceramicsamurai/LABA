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
        public String ФИО { get; set; }
        public String Группа { get; set; }
        public String Балл { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ФИО = textBox1.Text;
            Группа = textBox2.Text;
            Балл = textBox3.Text;

            DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ФИО = "ФИО";
            Группа = "Группа";
            Балл = "Средний балл";

            textBox1.Text = ФИО;
            textBox2.Text = Группа;
            textBox3.Text = Балл;      
        }
    }
}
