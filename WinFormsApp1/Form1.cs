using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string name;
        public string population;
        public string area;
        public string mayor;
        public string Skyscrapers;
        public string selectedDestination;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("���������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDestination = comboBox1.SelectedItem.ToString();
            name = textBox1.Text;
            population = textBox2.Text;
            area = textBox3.Text;
            mayor = textBox4.Text;
            Skyscrapers = textBox5.Text;
            ����� place;
            switch (selectedDestination)
            {
                case "�����":
                    place = new �����(name, population);
                    textBox6.Text = (place.Info);
                    break;
                case "�������":
                    ������� region = new �������(name, population, textBox3.Text);
                    textBox6.Text = (region.Info);
                    break;
                case "�����":
                    ����� city = new �����(name, population, textBox4.Text);
                    textBox6.Text = (city.Info);
                    MessageBox.Show(selectedDestination);
                    break;
                case "���������":
                    ��������� metropolis = new ���������(name, population, textBox4.Text, textBox5.Text);
                    textBox6.Text = (metropolis.Info);
                    break;
            }
        }
    }
}