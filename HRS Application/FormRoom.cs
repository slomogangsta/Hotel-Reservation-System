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
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
            GetStudentRecord();
            ClearRecords();
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            ClearRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void GetStudentRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from RoomsNew", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void ClearRecords()
        {
            textBoxRoomNo.Text = "0";
            textBoxRoomTypeID.Clear();
            comboBoxRoomType.Refresh();
        }

        int[] arrRoomID = { 101, 102, 103, 104, 105 };

        private void validation_RoomNo(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomNo.Text))
            {
                e.Cancel = true;
                errorProviderRoomNo.SetError(textBoxRoomNo, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxRoomNo.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderRoomNo.SetError(textBoxRoomNo, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderRoomNo.SetError(textBoxRoomNo, "");
            }
        }

        private void validation_RoomType(object sender, CancelEventArgs e)
        {
            if (comboBoxRoomType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProviderRoomType.SetError(comboBoxRoomType, "Select a valid option");
            }
            else
            {
                e.Cancel = false;
                errorProviderRoomType.SetError(comboBoxRoomType, "");
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRoomTypeID.Text = arrRoomID[comboBoxRoomType.SelectedIndex].ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxRoomNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int temp = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                comboBoxRoomType.SelectedIndex = arrRoomID.findIndex(temp);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");
            }

            //temp = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
            //if (temp == 1) textBoxCheckinStatus.Text = "True";
            //else textBoxCheckinStatus.Text = "False";
            //temp = (int)dataGridView1.SelectedRows[0].Cells[3].Value;
            //if (temp == 1) textBoxResStatus.Text = "True";
            //else textBoxResStatus.Text = "False";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) & textBoxRoomNo.Text!="0" & textBoxRoomTypeID.Text!="0")
            {
                SqlCommand cmd = new SqlCommand(@"Insert into RoomsNew values (@rno, @rid)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rno", textBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("@rid", textBoxRoomTypeID.Text);
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
            else
            {
                MessageBox.Show("Add Valid Room No", "Insert Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNo.Text != "0" & textBoxRoomTypeID.Text != "0")
            {
                SqlCommand cmd1 = new SqlCommand("Select RoomNo from ResvRooms where RoomNo = @id", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", textBoxRoomNo.Text);
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                bool flag = false;
                if (!sdr1.HasRows) flag = true;
                else flag = false;
                con.Close();
                if (flag)
                {
                    SqlCommand cmd = new SqlCommand("Delete from RoomsNew where RoomNo = @id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", textBoxRoomNo.Text);
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
                    MessageBox.Show("There are upcoming or current reservations on this room", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {   
                if(textBoxRoomNo.Text == "0")
                {
                    MessageBox.Show("Select an entry to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Room is either Reserved or currently Checkedin", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetStudentRecord();
                ClearRecords();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNo.Text != "0" & textBoxRoomTypeID.Text != "0")
            {
                SqlCommand cmd1 = new SqlCommand("Select RoomNo from ResvRooms where RoomNo = @id", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", textBoxRoomNo.Text);
                con.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                bool flag = false;
                if (!sdr1.HasRows) flag = true;
                else flag = false;
                con.Close();
                if (flag)
                {
                    SqlCommand cmd = new SqlCommand("Update RoomsNew set RoomID = @rid where RoomNo = @rno", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@rno", textBoxRoomNo.Text);
                    cmd.Parameters.AddWithValue("@rid", textBoxRoomTypeID.Text);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Inner Exception: " + ex.Message);
                        Console.WriteLine();
                        Console.WriteLine("Query Executed: " + cmd);
                        Console.WriteLine();
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
                    MessageBox.Show("There are upcoming or current reservations on this room", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textBoxRoomNo.Text == "0")
                {
                    MessageBox.Show("Select an entry to update", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Room is either Reserved or currently Checkedin", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetStudentRecord();
                ClearRecords();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearRecords();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetStudentRecord();
        }
    }

    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
}
