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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Zamestnanec Ondra;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Zamestnanec ondra = new Zamestnanec("Miloš", "Ondřej Zelený", 200000, dateTimePicker1.Value);
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            try
            {
             Ondra = new Zamestnanec("Miloš", "Ondřej Zelený", 200000, dateTimePicker1.Value);
                MessageBox.Show(Ondra.ToString());
            }
            catch (Exception)
                    { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Zamestnanec ondra = new Zamestnanec("Miloš", "Ondřej Zelený", 200000, dateTimePicker1.Value);
            Ondra.zvysOsobni((int)numericUpDown1.Value);
            MessageBox.Show(Ondra.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ondra.odpracHod((int)numericUpDown2.Value);
            MessageBox.Show(Ondra.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ondra.relaxace(24);
            MessageBox.Show(Ondra.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
