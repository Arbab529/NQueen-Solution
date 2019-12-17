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
    public partial class customer_item : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\IMS\HCI ASSIGNMENT\stockrecord.accdb;
Persist Security Info=False;");
        public customer_item()
        {
            InitializeComponent();
        }

        private void customer_item_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = 0;
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from adminview where ItemName like '%" + textBox7.Text + "%'";
            //like means is jasi value
            //%is ka darmiyan us tarhan ki jo b value ho gi bta day ga%
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();
            if (count == 0)
            {
                MessageBox.Show("Data Not Available");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lgn = new login();
            lgn.Show();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.DeepSkyBlue;
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.DeepSkyBlue;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.DeepSkyBlue;
            button8.ForeColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
            button8.ForeColor = Color.DeepSkyBlue;
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
           button3.BackColor = Color.DeepSkyBlue;
           button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.DeepSkyBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            feedback fb = new feedback();
            fb.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.DeepSkyBlue;
        }
    }
}
