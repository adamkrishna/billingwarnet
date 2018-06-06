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
    public partial class Billing : Form
    {
        private Stopwatch wkt = null;
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                wkt = new Stopwatch();
                if (button1.Text == "Login")
                {
                    label2.Visible = true;
                    wkt.Start();
                    button1.Text = "Stop";
                }
                else if (button1.Text == "Stop")
                {
                    wkt.Stop();
                    if (wkt.Elapsed.TotalMinutes <= 30.00)
                    {
                        MessageBox.Show("Jumlah Tagihan Anda Sebesar Rp.1000", "Total Tagihan");
                    }

                    else if (wkt.Elapsed.TotalHours <= 1.00)
                    {
                        MessageBox.Show("Jumlah Tagihan Anda Sebesar Rp.2000", "Total Tagihan");
                    }

                    wkt.Reset();
                    label2.Visible = false;
                    button1.Text = "Login";
                    textBox1.Text = null;
                }
            }

            else if (textBox1.Text == "")
            {
                MessageBox.Show("Nama Harus Di isi.....!", "Important Message");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wkt != null)
            {
                label2.Text = wkt.Elapsed.ToString(@"hh\:mm\:ss");
            }
        }

    }
}

