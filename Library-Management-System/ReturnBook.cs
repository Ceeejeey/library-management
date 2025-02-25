﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void txtSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=library;Integrated Security=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from IRBook where std_enroll = '" + txtEnterEnroll.Text + "' and book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();

        }

        String bname;
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=localhost;Database=library;Integrated Security=True;TrustServerCertificate=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            con.Open();
            cmd.CommandText = "update IRBook set book_return_date = '" + dateTimePicker1.Text + "' where std_enroll = '"+txtEnterEnroll.Text+"' and id = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Successful.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            ReturnBook_Load(this, null);
        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtEnterEnroll.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }
    }
}
