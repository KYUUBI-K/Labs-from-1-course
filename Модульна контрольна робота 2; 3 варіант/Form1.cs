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

namespace Тест
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillTestData();
            Show(_db.GetAll());
        }

        private NewsDatabase _db = new NewsDatabase();
        private void FillTestData()
        {
            _db.Add(new News("Новина", "все про все", "ми знаєе", "29 січня 2020", 129));
            _db.Add(new News("Щось", "все про нас", "Текст", "21 березня 2019", 95));
            _db.Add(new News("Модуль", "все про все", "якийсь текс", "13 листопада 2013", 20303));
        }
        private void Show(List<News> list)
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
                dataGridView1.Rows[i].Cells[0].Value = list[i].heading;
                dataGridView1.Rows[i].Cells[1].Value = list[i].content;
                dataGridView1.Rows[i].Cells[2].Value = list[i].text;
                dataGridView1.Rows[i].Cells[3].Value = list[i].date_of_publication;
                dataGridView1.Rows[i].Cells[4].Value = list[i].Numbers_of_views;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            News news = new News(
                     textBox1.Text,
                     textBox2.Text,
                     "",
                     "",
                     0);
            _db.Add(news);
            Show(_db.GetAll());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            News NewsToDelete = _db.GetByIndex(i);
            _db.Remove(NewsToDelete);
            Show(_db.GetAll());
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //1.Відкрили файл для читання
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                //2.Читаємо дані
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = Convert.ToInt32(SR.ReadLine());
                }
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = SR.ReadLine();
                }
                //3. Закриваємо
                SR.Close();*/
            }

        private void наДіаграмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
               
                    chart1.Series[0].Points.AddXY(i, Convert.ToInt32(dataGridView1[i, 4].Value));
            }
            
        }
    }








    }


    

