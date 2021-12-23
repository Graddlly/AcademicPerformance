using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AcademicPerformance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            var lines = File.ReadAllLines("students.txt");

            Array.Sort(lines);

            foreach (var t in lines)
            {
                var values = t.Split('/');
                var row = new string[values.Length];

                for(var j = 0; j < 8; j++)
                {
                    row[j] = values[j].Trim();
                }

                double sum = 0, median;

                var valuesn = t.Split('/');
                var rown = new double[valuesn.Length];

                for (var j = 2; j < valuesn.Length - 1; j++)
                {       
                    rown[j] = Convert.ToDouble(valuesn[j].Trim());
                    sum += Convert.ToDouble(valuesn[j]);
                }

                var average = sum / 5;
                Array.Sort(rown);
                
                if (rown.Length % 2 != 0)
                { 
                    median = rown[2];
                }
                else
                {
                    median = (Convert.ToDouble(rown[(rown.Length + 3) / 2]) + Convert.ToDouble(rown[(rown.Length + 2) / 2])) / 2.0;
                }
                
                valuesn = t.Split('/');
                var rown1 = new string[valuesn.Length];
                
                for (var j = 7; j < valuesn.Length; j++)
                {
                    rown1[j] = valuesn[j].Trim();
                }
                
                var ahw = 0.3 * average + 0.7 * Convert.ToDouble(rown1[7]);
                var mhw = 0.3 * median + 0.7 * Convert.ToDouble(rown1[7]);
                
                _table.Rows.Clear();
                _table.Rows.Add(row[0], row[1], ahw, mhw, row[2], row[3], row[4], row[5], row[6], row[7]);
            }
            
        }

        private readonly DataTable _table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            _table.Columns.Add("Фамилия", typeof(string));
            _table.Columns.Add("Имя", typeof(string));
            _table.Columns.Add("Среднее", typeof(double));
            _table.Columns.Add("Медиальное", typeof(double));
            _table.Columns.Add("КТ №1", typeof(double));
            _table.Columns.Add("КТ №2", typeof(double));
            _table.Columns.Add("КТ №3", typeof(double));
            _table.Columns.Add("КТ №4", typeof(double));
            _table.Columns.Add("КТ №5", typeof(double));
            _table.Columns.Add("Экзамен", typeof(double));
            
            dataGridView1.DataSource = _table;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var finfo = new Form2();
            finfo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("students.txt", string.Empty);
            MessageBox.Show(@"Все данные успешно стерты!");
            _table.Rows.Clear();
        }
    }
}
