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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GFG algo = new GFG();
            if (comboBox1.SelectedItem == "Pekalongan")
            {
                if (comboBox2.SelectedItem == "Cilacap")
                {
                    //algo.utama("semarang");
                    //int nilai = int.Parse(keluaran.Text); 

                    //int sekarang;
                    //sekarang = GFG.nilai;
                    //this.keluaran.Text = Convert.ToString(sekarang);

                    //ini yang dibawah ini code untuk ngetes pengkondisian aja
                    string sekarang;
                    sekarang = "pekalogan cilacap";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Klaten")
                {

                    string sekarang;
                    sekarang = "pekalogan klaten";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem =="Karang Anyar")
                {
                    string sekarang;
                    sekarang = "pekalogan karang anyar";
                    this.keluaran.Text = sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Berebes")
            {
                if (comboBox2.SelectedItem == "Purworejo")
                {
                    string sekarang;
                    sekarang = "Berebes purworejo";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Grobogan")
                {
                    string sekarang;
                    sekarang = "berebes gorobogan";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Rembang")
                {
                    string sekarang;
                    sekarang = "berebes rembang";
                    this.keluaran.Text = sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Semarang")
            {
                if (comboBox2.SelectedItem == "Banyumas")
                {
                    string sekarang;
                    sekarang = "semarang banyumas";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Rembang")
                {
                    string sekarang;
                    sekarang = "semarang rembang";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Pemalang")
                {
                    string sekarang;
                    sekarang = "semarang pemalang";
                    this.keluaran.Text = sekarang;
                }

            }
            if (comboBox1.SelectedItem == "Purworejo")
            {
                if (comboBox2.SelectedItem == "Tegal")
                {
                    string sekarang;
                    sekarang = "purworejo tegal";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Berebes")
                {
                    string sekarang;
                    sekarang = "purworejo berebes";
                    this.keluaran.Text = sekarang;
                }
                else if (comboBox2.SelectedItem == "Jepara")
                {
                    string sekarang;
                    sekarang = "purworejo jepara";
                    this.keluaran.Text = sekarang;
                }

            }


        }




    }
}
