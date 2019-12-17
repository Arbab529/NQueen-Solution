using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HCI_ASSIGNMENT
{
    public partial class signup : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\IMS\HCI ASSIGNMENT\stockrecord.accdb;
Persist Security Info=False;");
        public signup()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from signup where username='" + textBox0.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already taken");
                textBox0.Text = string.Empty;
                connection.Close();
                return;
            }
            cmd.CommandText = "insert into signup values('" + textBox0.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Successfully Signed Up!!! ");
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void textBox0_Click(object sender, EventArgs e)
        {
            textBox0.Clear();
            textBox0.ForeColor = Color.DeepSkyBlue;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.DeepSkyBlue;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.DeepSkyBlue;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DeepSkyBlue;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.DeepSkyBlue;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.DeepSkyBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                return;
            }
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
