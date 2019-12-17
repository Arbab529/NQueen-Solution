using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Threading;
namespace HCI_ASSIGNMENT
{
    public partial class Form1 : Form
    {
        login obj1 = new login();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{


        //    this.Hide();
        //    login login = new login();
        //    login.Show();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button1_MouseEnter(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.DodgerBlue;
        //    button1.ForeColor = Color.White;
        //}

        //private void button1_MouseLeave(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.DeepSkyBlue;
        //    button1.ForeColor = Color.White;
        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
