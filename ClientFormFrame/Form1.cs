using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormFrame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lab4II.WebService1 ws2 = new Lab4II.WebService1();
            DateTime lt = ws2.GetCurrentDate();
            string stime = lt.Hour + ":" + lt.Minute + ":" + lt.Second + "." + lt.Millisecond;
            string sdate = lt.Month + "/" + lt.Day + "/" + lt.Year;
            label4.Text = sdate + " " + stime;
        }



        private void AddList_Click(object sender, EventArgs e)
        {
            Lab4II.WebService1 ws2 = new Lab4II.WebService1();
            listBox1.Items.AddRange(ws2.DisplayItems());

        }



        private void Euro_KeyDown(object sender, KeyEventArgs e)
        {

            double op = 0;
            Lab4II.WebService1 ws2 = new Lab4II.WebService1();
            bool isNum = double.TryParse(txtMoney2.Text, out op);
            if (isNum)
            {
                if (e.KeyCode == Keys.Enter)
                    txtMoney.Text = ws2.EtoL(op).ToString();


            }

            else txtMoney.Clear();
        }

        private void CtoF_Click_1(object sender, EventArgs e)
        {
            double op = 0;
            Lab4II.WebService1 ws2 = new Lab4II.WebService1();
            bool isNum = double.TryParse(txtC.Text, out op);
            if (isNum)
                txtRezultat.Text = ws2.CtoF(op).ToString();
            else
            {
                MessageBox.Show("Temperatura inserata in grade Celsius trebuie sa fie numar real!");
                txtRezultat.Clear();
                txtC.Clear();
            }
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            double op = 0;
            localhost.WebService1 ws2 = new localhost.WebService1();
            bool isNum = double.TryParse(txtF.Text, out op);
            if (isNum)
                txtRezultat.Text = ws2.FtoC(op).ToString();
            else
            {
                MessageBox.Show("Temperatura inserata in grade Farenheit trebuie sa fie numar real!");
                txtRezultat.Clear();
                txtF.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
