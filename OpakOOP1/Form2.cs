using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpakOOP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            numericUpDown2.Visible = false;
            numericUpDown1.Visible = false;
        }
        SportovecProfesional Ondra;

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown1.Visible = true;
            Ondra = new SportovecProfesional("Ondřej Zelený", 86, 180, dateTimePicker1.Value, Convert.ToDouble(textBox1.Text));
            label1.Text= Ondra.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ondra.Trenuj((int)numericUpDown1.Value);
            label1.Text= Ondra.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Ondra.StupenVykonosti=(int)numericUpDown2.Value;
        }
    }
}
