using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckKentang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKentang.Checked == true)
            {
                tbKentang.Enabled = true;
            }
            if (ckKentang.Checked == false)
            {
                tbKentang.Enabled = false;
                tbKentang.Text = "0";
            }
        }

        private void ckBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBurger.Checked == true)
            {
                tbBurger.Enabled = true;
            }
            if (ckBurger.Checked == false)
            {
                tbBurger.Enabled = false;
                tbBurger.Text = "0";
            }
        }

        private void ckSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSalad.Checked == true)
            {
                tbSalad.Enabled = true;
            }
            if (ckSalad.Checked == false)
            {
                tbSalad.Enabled = false;
                tbSalad.Text = "0";
            }
        }

        private void ckLapis_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLapis.Checked == true)
            {
                tbLapis.Enabled = true;
            }
            if (ckLapis.Checked == false)
            {
                tbLapis.Enabled = false;
                tbLapis.Text = "0";
            }
        }

        private void ckAyam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAyam.Checked == true)
            {
                tbAyam.Enabled = true;
            }
            if (ckAyam.Checked == false)
            {
                tbAyam.Enabled = false;
                tbAyam.Text = "0";
            }

        }

        private void ckKeju_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKeju.Checked == true)
            {
                tbKeju.Enabled = true;
            }
            if (ckKeju.Checked == false)
            {
                tbKeju.Enabled = false;
                tbKeju.Text = "0";
            }

        }

        private void ckTeh_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTeh.Checked == true)
            {
                tbTeh.Enabled = true;
            }
            if (ckTeh.Checked == false)
            {
                tbTeh.Enabled = false;
                tbTeh.Text = "0";
            }

        }

        private void ckSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSoda.Checked == true)
            {
                tbSoda.Enabled = true;
            }
            if (ckSoda.Checked == false)
            {
                tbSoda.Enabled = false;
                tbSoda.Text = "0";
            }

        }

        private void ckAir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAir.Checked == true)
            {
                tbAir.Enabled = true;
            }
            if (ckAir.Checked == false)
            {
                tbAir.Enabled = false;
                tbAir.Text = "0";
            }

        }

        private void ckCoklat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCoklat.Checked == true)
            {
                tbCoklat.Enabled = true;
            }
            if (ckCoklat.Checked == false)
            {
                tbCoklat.Enabled = false;
                tbCoklat.Text = "0";
            }

        }

        private void ckCake_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCake.Checked == true)
            {
                tbCake.Enabled = true;
            }
            if (ckCake.Checked == false)
            {
                tbCake.Enabled = false;
                tbCake.Text = "0";
            }

        }

        private void ckOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOrange.Checked == true)
            {
                tbOrange.Enabled = true;
            }
            if (ckOrange.Checked == false)
            {
                tbOrange.Enabled = false;
                tbOrange.Text = "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ckKentang.Checked = false;
            ckBurger.Checked = false;
            ckSalad.Checked = false;
            ckLapis.Checked = false;
            ckAyam.Checked = false;
            ckKeju.Checked = false;
            ckTeh.Checked = false;
            ckAir.Checked = false;
            ckSoda.Checked = false;
            ckCoklat.Checked = false;
            ckCake.Checked = false;
            ckOrange.Checked = false;
            lblsub.Text = "Rp.--";
            lbltax.Text = "Rp.--";
            lbltotal.Text = "Rp.--";
            RecieptTb.Clear();

        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RecieptTb.Text + " \nSub Total " + lblsub.Text + " Tax: " + lbltax.Text + " Total " + lbltotal.Text, new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //Declare unit price to different meal and drinks
        int friesup = 10000, burgerup = 20000, saladup = 25000, sandwichup = 15000, chikenup = 20000, cheeseup = 25000;
        double waterup = 5000, teaup = 10000, sodaup = 10000, chocolateup = 15500, pancakesup = 26000, orangeup = 18000;

        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwiichtp, chikentp, cheesetp, watertp, teatp, sodatp, chocolatetp, pancakestp, orangetp;
        double Subtotal = 0, tax, grdtotal;

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(tbKentang.Text);
            burgertp = burgerup * Convert.ToDouble(tbBurger.Text);
            saladtp = saladup * Convert.ToDouble(tbSalad.Text);
            sandwiichtp = sandwichup * Convert.ToDouble(tbLapis.Text);
            chikentp = chikenup * Convert.ToDouble(tbAyam.Text);
            cheesetp = cheeseup * Convert.ToDouble(tbKeju.Text);
            // Sama untuk minuman
            watertp = waterup * Convert.ToDouble(tbAir.Text);
            teatp = teaup * Convert.ToDouble(tbTeh.Text);
            sodatp = sodaup * Convert.ToDouble(tbSoda.Text);
            chocolatetp = chocolateup * Convert.ToDouble(tbCoklat.Text);
            pancakestp = pancakesup * Convert.ToDouble(tbCake.Text);
            orangetp = orangeup * Convert.ToDouble(tbOrange.Text);
            //Add
            RecieptTb.Clear();
            Subtotal = 0;
            RecieptTb.AppendText(Environment.NewLine);
            RecieptTb.AppendText("\t\tCODESPACE RESTAURANT\t\t"+tbDate.Text + Environment.NewLine);
            RecieptTb.AppendText("\t\t====================" + Environment.NewLine);

            //Kondisi
            if(ckKentang.Checked == true)
            {
                RecieptTb.AppendText(" Kentang Goreng:\t" + "Rp " + friestp + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                lblsub.Text = "" + Subtotal;

            }
            if (ckBurger.Checked == true)
            {
                RecieptTb.AppendText(" Burger:\t\t\t" + "Rp " + burgertp + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckSalad.Checked == true)
            {
                RecieptTb.AppendText(" Salad:\t\t\t" + "Rp " + saladtp + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckLapis.Checked == true)
            {
                RecieptTb.AppendText(" Roti Lapis:\t\t" + "Rp " + sandwiichtp + Environment.NewLine);
                Subtotal = Subtotal + sandwiichtp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckAyam.Checked == true)
            {
                RecieptTb.AppendText(" Ayam Goreng:\t\t" + "Rp " + chikentp + Environment.NewLine);
                Subtotal = Subtotal + chikentp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckKeju.Checked == true)
            {
                RecieptTb.AppendText(" Cheese:\t\t" + "Rp " + cheesetp + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckAir.Checked == true)
            {
                RecieptTb.AppendText(" Air:\t\t\t" + "Rp " + watertp + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckTeh.Checked == true)
            {
                RecieptTb.AppendText(" Teh:\t\t\t" + "Rp " + teatp + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckSoda.Checked == true)
            {
                RecieptTb.AppendText(" Soda:\t\t\t" + "Rp " + sodatp + Environment.NewLine);
                Subtotal = Subtotal + sodatp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckCoklat.Checked == true)
            {
                RecieptTb.AppendText(" Chocolate:\t\t" + "Rp " + chocolatetp + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckCake.Checked == true)
            {
                RecieptTb.AppendText(" Pancakes:\t\t" + "Rp " + pancakestp + Environment.NewLine);
                Subtotal = Subtotal + pancakestp;
                lblsub.Text = "" + Subtotal;
            }
            if (ckOrange.Checked == true)
            {
                RecieptTb.AppendText(" Jus Jeruk:\t\t" + "Rp " + orangetp + Environment.NewLine);
                Subtotal = Subtotal + orangetp;
                lblsub.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.16;
            grdtotal = Subtotal + tax;
            lbltax.Text = "Rp." + tax;
            lbltotal.Text = "Rp." + grdtotal;

        }

        private void RecieptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
