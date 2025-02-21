using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
			
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtSex.Clear();
            txtNIC.Clear();
            txtAddress.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnrollment.Text != "" && txtContact.Text != "" &&
                txtEmail.Text != "" && txtSex.Text != "" && txtNIC.Text != "" && txtAddress.Text != "")
            {
                try
                {
                    String name = txtName.Text;
                    String enroll = txtEnrollment.Text;
                    Int64 mobile = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String sex = txtSex.Text;
                    String nic = txtNIC.Text;
                    String address = txtAddress.Text;

                    using (SqlConnection con = new SqlConnection("Server=localhost;Database=library;Integrated Security=True;TrustServerCertificate=True;"))
                    {
                        string query = "INSERT INTO NewStudent (sname, enroll, contact, email, sex, nic, address) " +
                                       "VALUES (@name, @enroll, @mobile, @email, @sex, @nic, @address)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@enroll", enroll);
                            cmd.Parameters.AddWithValue("@mobile", mobile);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@sex", sex);
                            cmd.Parameters.AddWithValue("@nic", nic);
                            cmd.Parameters.AddWithValue("@address", address);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    MessageBox.Show("Data has been Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e); // Clear fields after saving
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Empty Field(s)!", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
