using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13_лабка_2_Варіант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillTestData();
            Show(_db.GetAll());
        }
        private DirectoryDatabase _db = new DirectoryDatabase();
        private void FillTestData()
        {
            _db.Add(new Directory("Ужгород", "адрес", "380562932", "менеджер", 9));
            _db.Add(new Directory("Лвів", "адрес", "38099237213", "колектор", 10));
            _db.Add(new Directory("Київ", "адрес", "380952132", "офіціант", 8));
        }
        private void Show(List<Directory> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нема що виводити");
                return;
            }
            dataGridView1.RowCount = list.Count;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].name;
                dataGridView1.Rows[i].Cells[1].Value = list[i].adress;
                dataGridView1.Rows[i].Cells[2].Value = list[i].phone;
                dataGridView1.Rows[i].Cells[3].Value = list[i].specialization;
                dataGridView1.Rows[i].Cells[4].Value = list[i].working_hours;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Directory directory = new Directory(
                             textBox1.Text,
                             textBox2.Text,
                             "",
                             "",
                             0);
            _db.Add(directory);
            Show(_db.GetAll());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            Directory DirectoryToDelete = _db.GetByIndex(i);
            _db.Remove(DirectoryToDelete);
            Show(_db.GetAll());

        }

        private void зберегтиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                SW.WriteLine(dataGridView1.ColumnCount);
                SW.WriteLine(dataGridView1.RowCount);
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {

                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {

                        SW.WriteLine(dataGridView1[i, 0].Value);
                    }
                }
                SW.Close();
            }
        }
    }
}
