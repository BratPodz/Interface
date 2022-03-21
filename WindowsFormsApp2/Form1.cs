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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudnik s = new Sotrudnik(textBox1.Text,textBox2.Text,textBox3.Text);
            listBox1.Items.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }

    interface IMoloko
    {
        void sotrudnik();
    }

    class Sotrudnik : IMoloko
    {
        public string fio;
        public string doljnost;
        public string oklad;

        public Sotrudnik(string FIO, string DOLJNOST, string OKLAD)
        {
            fio = FIO;
            doljnost = DOLJNOST;
            oklad = OKLAD;
        }

        public void sotrudnik()
        {
            MessageBox.Show($"Сотрудник {fio}\nУспешно добавлен");
        }
    }
}