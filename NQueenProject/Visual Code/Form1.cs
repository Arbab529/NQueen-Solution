using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual_Code
{
    public partial class Form1 : Form
    {
        int first=0;
        bool refresh = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int L = int.Parse(txtSize.Text);
                int x = 15, y = 15;
                N = L;
            int[,] arr= new int[L,L];
           
            if (!theBoardSolver(arr, 0))
            {
                Console.WriteLine("Solution not Possible .");
            }
   
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < L; j++)
                {
                   
                    Button btn = new Button();
                    btn.Text = "Queen"+" "+i+j;
                    btn.Width = 60;
                    btn.Height = 60;
                    btn.Left = x;
                    btn.Top = y;
                    btn.Name = btn + "" + i;
                    this.Controls.Add(btn);
                    x += 75;
                    if (arr[i,j]==1)
                    {
                        btn.BackColor = Color.Red;
                    }
                   
                }
                x = 15;
                y += 75;
            }
            //RefreshData(arr);
            first++;
        }
        static int N;
       
        static Boolean toPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }
        static Boolean theBoardSolver(int[,] board, int col)
        {
            if (col >= N) return true;
            for (int i = 0; i < N; i++)
            {
                if (toPlaceOrNotToPlace(board, i, col))
                {
                    board[i, col] = 1;
                    if (theBoardSolver(board, col + 1)) return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }
        //private void RefreshData(int[,] array)
        //{
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {

        //        }
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                refresh = true;
                txtSize.Clear();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            //if (first > 0 && refresh==false)
            //{
            //    refresh = true;
            //    txtSize.Clear();
            //    Form1 f = new Form1();
            //    f.Show();
            //    this.Hide();

            //}
        }

    }
}
