using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace HCI_ASSIGNMENT
{
    public partial class login : Form
    {
       
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\IMS\HCI ASSIGNMENT\stockrecord.accdb;
Persist Security Info=False;");
        public login()
        {
            //Thread sleepy = new Thread(new ThreadStart(splashscreen));
            //sleepy.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
           //sleepy.Abort();
        }
        //public void splashscreen()
        //{
        //    Application.Run(new Form1());
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ////if ((textBox1.Text)==null)
            ////{
            ////    MessageBox.Show("Please fill the required fields");
            ////}

            ////if ((textBox2.Text) == null)
            ////{
            ////    MessageBox.Show("Please fill the required fields");
            ////}
            if (comboBox1.Text=="Admin")
            {

                if (textBox1.Text=="Admin"&&textBox2.Text=="admin")
                {
                    //MessageBox.Show("Password Correct");
                    this.Hide();
                    adminlist adminlist = new adminlist();
                    adminlist.Show();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }
                  
               
                
            }
            else if (comboBox1.Text=="Customer")
            {
                int count = 0;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from signup where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                OleDbDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                   count= count + 1;
                }
                if (count==1)
                {
                    MessageBox.Show("Password Correct");
                     this.Hide();
                    customer_item customerlist = new customer_item();
                    customerlist.Show();
                }
                else 
                {
                    MessageBox.Show("Password Incorrect");
                }
                connection.Close();

            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox3.Image = bit;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.DeepSkyBlue;
            textBox2.ForeColor = Color.DeepSkyBlue;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.DeepSkyBlue;
            textBox1.ForeColor = Color.DeepSkyBlue;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.DeepSkyBlue;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DeepSkyBlue;
            button2.ForeColor = Color.White;
        }
       
        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.DeepSkyBlue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                return;
            }
            textBox2.UseSystemPasswordChar = true;
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox1.Text==null)
        //    {
        //        textBox1.Text = "Enter UserName";
        //    }
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    textBox2.Text = textBox3.Text;
        //}

        //private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        //{
        //    textBox2.Hide();
        //}

        //private void pictureBox4_MouseEnter(object sender, EventArgs e)
        //{
        //    textBox2.Show()
        //}

        //private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
