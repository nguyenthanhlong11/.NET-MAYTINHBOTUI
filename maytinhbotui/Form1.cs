using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinhbotui
{
    public partial class Form1 : Form
    {
        private bool KiemTra;
        private string PhepToan, LastValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "4";
            KiemTra = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "6";
            KiemTra = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(LastValue);
            b = Convert.ToDouble(khungketqua.Text);

            if (PhepToan == "+")
                khungketqua.Text = Convert.ToString(a + b);
            else if (PhepToan == "-")
                khungketqua.Text = Convert.ToString(a - b);
            else if (PhepToan == "*")
                khungketqua.Text = Convert.ToString(a * b);
            else if (PhepToan == "/")
                khungketqua.Text = Convert.ToString(a / b);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            khungketqua.Clear();
        }

        private void button_so1_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "1";
            KiemTra = false;
        }

        private void button_so2_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "2";
            KiemTra = false;
        }

        private void button_so3_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "3";
            KiemTra = false;
        }

        private void button_so5_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "5";
            KiemTra = false;
        }

        private void button_so7_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "7";
            KiemTra = false;
        }

        private void button_so8_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "8";
            KiemTra = false;
        }

        private void button_so9_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "9";
            KiemTra = false;
        }

        private void button_Cong_Click(object sender, EventArgs e)
        {
            LastValue = khungketqua.Text;
            KiemTra = true;
            PhepToan = "+";
        }

        private void button_Tru_Click(object sender, EventArgs e)
        {
            LastValue = khungketqua.Text;
            KiemTra = true;
            PhepToan = "-";
        }

        private void button_Nhan_Click(object sender, EventArgs e)
        {
            LastValue = khungketqua.Text;
            KiemTra = true;
            PhepToan = "*";
        }

        private void button_Chia_Click(object sender, EventArgs e)
        {
            LastValue = khungketqua.Text;
            KiemTra = true;
            PhepToan = "/";
        }

        private void button_so0_Click(object sender, EventArgs e)
        {
            if (KiemTra) khungketqua.Clear();
            khungketqua.Text = khungketqua.Text + "0";
            KiemTra = false;
        }
    }
}
