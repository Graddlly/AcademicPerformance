using System;
using System.IO;
using System.Windows.Forms;

namespace AcademicPerformance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var variables = new Variables();

            try
            {
                variables.Tb3 = Convert.ToInt32(textBox3.Text);
                variables.Tb4 = Convert.ToInt32(textBox4.Text);
                variables.Tb5 = Convert.ToInt32(textBox5.Text);
                variables.Tb6 = Convert.ToInt32(textBox6.Text);
                variables.Tb7 = Convert.ToInt32(textBox7.Text);
                variables.Tb8 = Convert.ToInt32(textBox8.Text);
            }
            catch
            {
                throw new Exception("Ошибка: Добавление данных невозможно!");
            }

            TextWriter txt = new StreamWriter("students.txt", true);

            txt.Write(textBox1.Text + Convert.ToString("/"));
            txt.Write(textBox2.Text + Convert.ToString("/"));
            txt.Write(variables.Tb3 + Convert.ToString("/"));
            txt.Write(variables.Tb4 + Convert.ToString("/"));
            txt.Write(variables.Tb5 + Convert.ToString("/"));
            txt.Write(variables.Tb6 + Convert.ToString("/"));
            txt.Write(variables.Tb7 + Convert.ToString("/"));
            txt.Write(variables.Tb8);
            txt.Write("\r");

            txt.Close();
            Close();
        }
    }
}