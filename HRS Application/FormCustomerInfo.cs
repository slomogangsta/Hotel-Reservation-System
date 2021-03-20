using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HRS_Application
{
    public partial class FormCustomerInfo : Form
    {
        public FormCustomerInfo()
        {
            InitializeComponent();
            GetStudentRecord();
        }

        private void FormCustomerInfo_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            ClearRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void GetStudentRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Customer", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void ClearRecords()
        {
            textBoxAadhaar.Clear();
            textBoxEmail.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxMobile.Clear();
            textBoxCustomerID.Text = "0";
            //textBoxFirstName.Focus();
            buttonReset.Focus();
        }

        private void validation_FirstName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                e.Cancel = true;
                errorProviderFirstName.SetError(textBoxFirstName, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxFirstName.Text, "^[a-zA-Z ]"))
            {
                e.Cancel = true;
                errorProviderFirstName.SetError(textBoxFirstName, "This field only accepts alphabets");
            }
            else
            {
                e.Cancel = false;
                errorProviderFirstName.SetError(textBoxFirstName, "");
            }
        }

        private void validation_LastName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                e.Cancel = true;
                errorProviderLastName.SetError(textBoxLastName, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxLastName.Text, "^[a-zA-Z ]"))
            {
                e.Cancel = true;
                errorProviderLastName.SetError(textBoxLastName, "This field only accepts alphabets");
            }
            else
            {
                e.Cancel = false;
                errorProviderLastName.SetError(textBoxLastName, "");
            }
        }

        private void validation_Email(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(textBoxEmail, "This field cannot be empty");
            }
            else if (!reg.IsMatch(textBoxEmail.Text))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(textBoxEmail, "Enter a valid email address");
            }
            else
            {
                e.Cancel = false;
                errorProviderEmail.SetError(textBoxEmail, "");
            }
        }

        private void validation_MobileNo(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMobile.Text))
            {
                e.Cancel = true;
                errorProviderMobile.SetError(textBoxMobile, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxMobile.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderMobile.SetError(textBoxMobile, "Only numeric values are accepted");
            }
            else if (textBoxMobile.Text.Length != 10)
            {
                e.Cancel = true;
                errorProviderMobile.SetError(textBoxMobile, "Mobile number should be 10 digits");
            }
            else
            {
                e.Cancel = false;
                errorProviderMobile.SetError(textBoxMobile, "");
            }
        }

        private void validation_Aadhaar(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAadhaar.Text))
            {
                e.Cancel = true;
                errorProviderAadhaar.SetError(textBoxAadhaar, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxAadhaar.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderAadhaar.SetError(textBoxAadhaar, "Only numeric values are accepted");
            }
            else if (textBoxAadhaar.Text.Length != 12)
            {
                e.Cancel = true;
                errorProviderAadhaar.SetError(textBoxAadhaar, "Aadhaar number should be 12 digits");
            }
            else
            {
                e.Cancel = false;
                errorProviderAadhaar.SetError(textBoxAadhaar, "");
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                SqlCommand cmd = new SqlCommand("Insert into Customer values (@fname, @lname, @email, @mobile, @aadhaar)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", textBoxMobile.Text);
                cmd.Parameters.AddWithValue("@aadhaar", textBoxAadhaar.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Inner Exception: " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("Query Executed: " + cmd);
                    Console.WriteLine();
                    //sdr.Close();
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Added Successfully!", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentRecord();
                    ClearRecords();
                }

                
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearRecords();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxCustomerID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBoxMobile.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBoxAadhaar.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerID.Text != "0")
            {
                SqlCommand cmd1 = new SqlCommand("Select CustomerID from ResvRooms where CustomerID = @id", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", textBoxCustomerID.Text);
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                bool flag = false;
                if (!sdr1.HasRows) flag = true;
                else flag = false;
                con.Close();
                if (flag)
                {
                    SqlCommand cmd = new SqlCommand("Update Customer set FirstName = @fname, LastName = @lname, Email = @email, Mobile = @mobile, Aadhaar = @aadhaar where CustomerID = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@mobile", textBoxMobile.Text);
                    cmd.Parameters.AddWithValue("@aadhaar", textBoxAadhaar.Text);
                    cmd.Parameters.AddWithValue("@id", textBoxCustomerID.Text);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Inner Exception: " + ex.Message);
                        Console.WriteLine();
                        Console.WriteLine("Query Executed: " + cmd);
                        Console.WriteLine();
                        //sdr.Close();
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Updated Successfully!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetStudentRecord();
                        ClearRecords();
                    }

                    
                }
                else
                {
                    MessageBox.Show("There are upcoming or current reservations on this customer", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Select an entry to update", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetStudentRecord();
                ClearRecords();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerID.Text != "0")
            {
                SqlCommand cmd1 = new SqlCommand("Select CustomerID from ResvRooms where CustomerID = @id", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", textBoxCustomerID.Text);
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                bool flag = false;
                if (!sdr1.HasRows) flag = true;
                else flag = false;
                con.Close();
                if (flag)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Customer where CustomerID = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", textBoxCustomerID.Text);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Inner Exception: " + ex.Message);
                        Console.WriteLine();
                        Console.WriteLine("Query Executed: " + cmd);
                        Console.WriteLine();
                        //sdr.Close();
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Deleted Successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetStudentRecord();
                        ClearRecords();
                    }
                    
                }
                else
                {
                    MessageBox.Show("There are upcoming or current reservations on this customer", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Select an entry to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetStudentRecord();
                ClearRecords();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

      
    }
}
