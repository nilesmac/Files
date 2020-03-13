﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BudgeIt
{
    public partial class Calendar : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            try
            {
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.sqlConnection1.ConnectionString = sqlConnection.ConnectionString;
            depo.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalendarTable_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChange(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("");
            con1.Open();

            SqlCommand cmd1 = new SqlCommand("", con1);
            cmd1.Parameters.AddWithValue("", int.Parse(TextBox1.Text));
            SqlDataReader da1 = cmd1.ExecuteReader();

            con1.Close();
        }

        private void textBox2_TextChange(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("");
            con2.Open();

            SqlCommand cmd2 = new SqlCommand("", con2);
            cmd2.Parameters.AddWithValue("", int.Parse(TextBox2.Text));
            SqlDataReader da2 = cmd2.ExecuteReader();

            con2.Close();
        }

        private void textBox3_TextChange(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection("");
            con3.Open();

            SqlCommand cmd3 = new SqlCommand("", con3);
            cmd3.Parameters.AddWithValue("", int.Parse(TextBox3.Text));
            SqlDataReader da3 = cmd3.ExecuteReader();

            con3.Close();
        }

        private void textBox4_TextChange(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection("");
            con4.Open();

            SqlCommand cmd4 = new SqlCommand("", con4);
            cmd4.Parameters.AddWithValue("", TextBox4.Text);
            SqlDataReader da4 = cmd4.ExecuteReader();

            con4.Close();
        }
    }
}
