using System;
using System.IO;
using System.Windows.Forms;

namespace AcademicPerformance
{
    public partial class Form2 : Form
    {
        Form1 fgrid;
        public Form2(Form1 fg)
        {
            InitializeComponent();
            fgrid = fg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("students.txt",true);

            txt.Write(textBox1.Text + Convert.ToString("/"));
            txt.Write(textBox2.Text + Convert.ToString("/"));
            txt.Write(textBox3.Text + Convert.ToString("/"));
            txt.Write(textBox4.Text + Convert.ToString("/"));
            txt.Write(textBox5.Text + Convert.ToString("/"));
            txt.Write(textBox6.Text + Convert.ToString("/"));
            txt.Write(textBox7.Text + Convert.ToString("/"));
            txt.Write(textBox8.Text);
            txt.Write("\r");
               
            txt.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}