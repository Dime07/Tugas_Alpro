using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace dijkstra_gui
{
    

        public partial class Form1 : Form
    {
        public string teks1, teks2;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teks1 = comboBox1.Text;
            teks2 = comboBox2.Text;
            GFG algo = new GFG();
            if (comboBox1.SelectedItem == "Pekalongan")
            {
                if (comboBox2.SelectedItem == "Cilacap")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Klaten")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem =="Karang Anyar")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Berebes")
            {
                if (comboBox2.SelectedItem == "Purworejo")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Grobogan")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Rembang")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Semarang")
            {
                if (comboBox2.SelectedItem == "Banyumas")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Rembang")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Pemalang")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Purworejo")
            {
                if (comboBox2.SelectedItem == "Tegal")
                {

                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;

                }
                else if (comboBox2.SelectedItem == "Berebes")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }
                else if (comboBox2.SelectedItem == "Jepara")
                {
                    algo.utama(teks1, teks2);

                    int harga, a;
                    string sekarang;

                    a = GFG.nilai;
                    harga = ((a / 30) * 20000);
                    sekarang = Convert.ToString(harga);
                    this.keluaran.Text = "Rp." + sekarang;
                }

            }


        }




    }
}
