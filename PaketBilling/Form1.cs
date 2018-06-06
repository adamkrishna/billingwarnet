using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PaketBilling
{
    public partial class Form1 : Form
    {
       int jam = 0;
       int menit = 0;
       int detik = 0;
       int milidetik = 0;
       int tarif = 0;

       public Form1()
       {
           InitializeComponent();
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                wkt = new Stopwatch();
                if (button1.Text == "LOGIN")
                    {
                    if (radioButton1.Checked)
                    {
                        label6.Text = "1 jam";
                    }
                    else if (radioButton2.Checked)
                    {
                        label6.Text = "2 jam";
                    }
                    else if (radioButton3.Checked)
                    {
                        label6.Text = "3 jam";
                    }
                    else if (radioButton4.Checked)
                    {
                        label6.Text = "4 jam";
                    }
                    label3.Visible = true;
                    wkt.Start();
                    button1.Text = "STOP";
                    label6.Visible = true;
                    button1.Text ="STOP";
                }
                else if (button1.Text == "STOP")
                {
                    wkt.Start();
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("Jumlah tagihan anda sebesar Rp 2000", "Total Tagihan Paket Regular");
                    }
                    if (radioButton2.Checked)
                    {
                        MessageBox.Show("Jumlah Tagihan anda sebesar Rp 3000", "Total Tahihan Paket Hemat");
                    }
                    if (radioButton3.Checked)
                    {
                        MessageBox.Show("Jumlah Tagihan anda sebesar Rp 4000", "Total Tahihan Paket Game 1");
                    }
                    if (radioButton4.Checked)
                    {
                        MessageBox.Show("Jumlah Tagihan anda sebesar Rp 5000", "Total Tahihan Paket Game 2");
                    }
                    wkt.Reset();
                    label3.Visible = false;
                    button1.Text = "LOGIN";
                    textBox1.Text = null;
                    label6.Visible = false;
                    button1.Text = "LOGIN";

                }
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Nama Harus Diisi!!!", "Important Message");
            }

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wkt != null)
            {
                label3.Text = wkt.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }
    }
}
