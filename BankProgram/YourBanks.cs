using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProgram
{
    public partial class YourBanks : Form
    {
        public YourBanks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count - 1;
            int choice = comboBox1.SelectedIndex;

            Obcyj[] arr = new Obcyj[n];
            for (int i = 0; i < n; i++)
            {
                
                string name_ = dataGridView1.Rows[i].Cells[0].Value.ToString();

                string credit_ = dataGridView1.Rows[i].Cells[1].Value.ToString();

                int procent_ = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                string city_ = dataGridView1.Rows[i].Cells[3].Value.ToString();

                int date_ = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);


                arr[i] = new Obcyj(name_, credit_, procent_, city_, date_);
               

            }
            dataGridView2.Rows.Clear();
            switch (choice)
            {
                case 0:
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        SameCredit(textBox1.Text, arr);
                    break;
                case 1:
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        SameCity(textBox1.Text, arr);
                    break;
                case 2:
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        SameProcent(Convert.ToInt16(textBox1.Text), arr);
                    break;
                case 3:
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        SameDate(Convert.ToInt16(textBox1.Text), arr);
                    break;
                case 4:
                    MaxProcent(arr);
                    break;
                case 5:
                    MaxDate(arr);
                    break;
                case 6:
                    if (textBox2.Text =="" || textBox3.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        diapozonProcent(arr);
                    break;
                case 7:
                    if (textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Кто писать будет?");
                    }
                    else
                        diapozonDate(arr);
                    break;
                default:
                    break;
            }

              
           }
        private void MaxProcent(Obcyj[] arr)
        {
            

            int Max = arr[0].procent;
            int n = arr.Length;

            int fMax = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i].procent > Max)
                {
                    Max = arr[i].procent;
                    fMax = i;
                }
            }
            dataGridView2.Rows.Add(arr[fMax].name, arr[fMax].credit, arr[fMax].procent, arr[fMax].city, arr[fMax].date);
        }
        private void SameCredit(string item, Obcyj[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].credit == item)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }

        private void SameCity(string item, Obcyj[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].city == item)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }

        private void SameProcent(int item, Obcyj[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].procent == item)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }
        private void SameDate(int item, Obcyj[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].date == item)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }

       



        private void MaxDate(Obcyj[] arr)
        {
          
            int Max = arr[0].date;
            int n = arr.Length;
            int fMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i].date > Max)
                {
                    Max = arr[i].date;
                    fMax = i;
                }
            }
            dataGridView2.Rows.Add(arr[fMax].name, arr[fMax].credit, arr[fMax].procent, arr[fMax].city, arr[fMax].date);
        }
        private void diapozonProcent (Obcyj[] arr)
        {
           
            int n = arr.Length;
            int q = Convert.ToInt16(textBox2.Text);
            int p = Convert.ToInt16(textBox3.Text);
            for (int i = 0; i < n; i++)
            {
                if (arr[i].procent >= q && arr[i].procent <= p)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }
        private void diapozonDate(Obcyj[] arr)
        {

            int n = arr.Length;
            int q = Convert.ToInt16(textBox2.Text);
            int p = Convert.ToInt16(textBox3.Text);
            for (int i = 0; i < n; i++)
            {
                if (arr[i].date >= q && arr[i].date <= p)
                {
                    dataGridView2.Rows.Add(arr[i].name, arr[i].credit, arr[i].procent, arr[i].city, arr[i].date);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ПриватБанк", "Студентский", "10", "Киев", "90");
            dataGridView1.Rows.Add("ОщадБанк", "Студентский", "4", "Харьков", "70");
            dataGridView1.Rows.Add("СильверБанк", "Терпеливый", "30", "Одесса", "40");
            dataGridView1.Rows.Add("УкрГазБанк", "Терпеливый", "10", "Ужгород", "60");
            dataGridView1.Rows.Add("ПумбБанк", "Бессконечный", "4", "Хатяновка", "90");
            dataGridView1.Rows.Add("МоноБанк", "Оффник", "30", "Киев", "60");
            dataGridView1.Rows.Add("ГуливерБанк", "Оффник", "8", "Чернігов", "40");
        }
    }
}


