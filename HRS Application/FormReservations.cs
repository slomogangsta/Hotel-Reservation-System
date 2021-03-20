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
    public partial class FormReservations : Form
    {
        public FormReservations()
        {
            InitializeComponent();
            SetDateTimeParameters();
            SetDefaultComboBox();
            GetResvRoomsList();
            GetStudentRecord();
            GetCustomerList();
        }

        int[] arrRoomID = { 101, 102, 103, 104, 105 };

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void GetStudentRecord()
        {
            string query = "Select * from RoomsNew where RoomNo in (Select RoomNo from RoomsNew where RoomNo not in (Select RoomNo from ResvRooms where NOT(@Checkin > ResvoutDate or @Checkout < ResvinDate))) and RoomID = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Checkin", dateTimePickerInDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Checkout", dateTimePickerOutDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@id", arrRoomID[comboBoxRoomType.SelectedIndex]);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewRooms.DataSource = dt;
        }

        private void GetResvRoomsList()
        {
            string query = "Select * from ResvRooms";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewResvRooms.DataSource = dt;
        }

        private void GetCustomerList()
        {
            string query = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewCustomers.DataSource = dt;
        }

        private void buttonSearchRooms_Click(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void SetDateTimeParameters()
        {
            dateTimePickerInDate.MinDate = DateTime.Parse("2020-01-01");
            dateTimePickerInDate.MaxDate = DateTime.Today.AddYears(1);
            dateTimePickerOutDate.MinDate = DateTime.Parse("2020-01-01");
            dateTimePickerOutDate.MaxDate = DateTime.Today.AddYears(1);
        }

        private void SetDefaultComboBox()
        {
            comboBoxRoomType.SelectedIndex = 0;
        }

        private void SearchButtonPress()
        {
            string query = "SELECT * FROM Customer";
            query += " WHERE FirstName LIKE '%' + @FName + '%'";
            query += " OR @FName = ''";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FName", textBoxSearchCustomer.Text.Trim());
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewCustomers.DataSource = dt;
        }

        private void SearchResvRooms()
        {
            string query = "Select * from ResvRooms where CustomerID = @cid or RoomNo = @rno";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cid", textBoxCustomerID.Text);
            cmd.Parameters.AddWithValue("@rno", textBoxRoomNo.Text);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewResvRooms.DataSource = dt;
        }

        private void ClearRecordsSelected()
        {
            dateTimePickerInDate.Value = DateTime.Today;
            dateTimePickerOutDate.Value = DateTime.Today;
            textBoxCustomerID.Text = "0";
            textBoxRoomNo.Text = "0";
            textBoxResvNo.Text = "0";
            RefreshData();
            textBoxSearchCustomer.Clear();
        }

        private void RefreshData()
        {
            GetStudentRecord();
            GetResvRoomsList();
            GetCustomerList();
        }

        private void WriteIntoHistory()
        {
            string rno = textBoxRoomNo.Text;
            string cid = textBoxCustomerID.Text;
            string checkind = dateTimePickerInDate.Value.ToString("yyyy-MM-dd");
            string checkoutd = dateTimePickerOutDate.Value.ToString("yyyy-MM-dd");

            string query = "Select Top 1 ResvNo from ResvRooms ORDER BY ResvNo DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string resvno = sdr["ResvNo"].ToString();
            con.Close();

            query = "Select RoomID from RoomsNew Where RoomNo = @rno";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rno", rno);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string rid = sdr["RoomID"].ToString();
            con.Close();

            query = "Select RoomName, RoomCapacity, RoomPrice, RoomFeatures from RoomInfo Where RoomID = @rid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rid", rid);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string rname = sdr["RoomName"].ToString();
            string rcap = sdr["RoomCapacity"].ToString();
            string rprice = sdr["RoomPrice"].ToString();
            string rfeatures = sdr["RoomFeatures"].ToString();
            con.Close();

            query = "Select FirstName, LastName, Email, Mobile, Aadhaar from Customer Where CustomerID = @cid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cid", cid);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string fname = sdr["FirstName"].ToString();
            string lname = sdr["LastName"].ToString();
            string email = sdr["Email"].ToString();
            string mobileno = sdr["Mobile"].ToString();
            string aadhaar = sdr["Aadhaar"].ToString();
            con.Close();

            query = "Insert into ResvHistory Values (@resvno, @checkind, @checkoutd, @rno, @rid, @rname, @rcap, @rprice, @rfeatures, @cid, @fname, @lname, @email, @mobileno, @aadhaar)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@resvno", resvno);
            cmd.Parameters.AddWithValue("@checkind", checkind);
            cmd.Parameters.AddWithValue("@checkoutd", checkoutd);
            cmd.Parameters.AddWithValue("@rno", rno);
            cmd.Parameters.AddWithValue("@rid", rid);
            cmd.Parameters.AddWithValue("@rname", rname);
            cmd.Parameters.AddWithValue("@rcap", rcap);
            cmd.Parameters.AddWithValue("@rprice", rprice);
            cmd.Parameters.AddWithValue("@rfeatures", rfeatures);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@aadhaar", aadhaar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void UpdatingHistory()
        {
            string resvno = textBoxResvNo.Text;
            string rno = textBoxRoomNo.Text;
            string cid = textBoxCustomerID.Text;
            string checkind = dateTimePickerInDate.Value.ToString("yyyy-MM-dd");
            string checkoutd = dateTimePickerOutDate.Value.ToString("yyyy-MM-dd");

            string query = "Select RoomID from RoomsNew Where RoomNo = @rno";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rno", rno);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string rid = sdr["RoomID"].ToString();
            con.Close();

            query = "Select RoomName, RoomCapacity, RoomPrice, RoomFeatures from RoomInfo Where RoomID = @rid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rid", rid);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string rname = sdr["RoomName"].ToString();
            string rcap = sdr["RoomCapacity"].ToString();
            string rprice = sdr["RoomPrice"].ToString();
            string rfeatures = sdr["RoomFeatures"].ToString();
            con.Close();

            query = "Select FirstName, LastName, Email, Mobile, Aadhaar from Customer Where CustomerID = @cid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cid", cid);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            string fname = sdr["FirstName"].ToString();
            string lname = sdr["LastName"].ToString();
            string email = sdr["Email"].ToString();
            string mobileno = sdr["Mobile"].ToString();
            string aadhaar = sdr["Aadhaar"].ToString();
            con.Close();

            query = "Update ResvHistory Set ResvinDate = @checkind, ResoutDate = @checkoutd, RoomNo = @rno, RoomID = @rid, RoomName = @rname, RoomCapacity = @rcap, RoomPrice = @rprice, RoomFeatures = @rfeatures, CustomerID = @cid, FirstName = @fname, LastName = @lname, Email = @email, Mobile = @mobileno, Aadhaar = @aadhaar where ResvNo = @resvno";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@resvno", resvno);
            cmd.Parameters.AddWithValue("@checkind", checkind);
            cmd.Parameters.AddWithValue("@checkoutd", checkoutd);
            cmd.Parameters.AddWithValue("@rno", rno);
            cmd.Parameters.AddWithValue("@rid", rid);
            cmd.Parameters.AddWithValue("@rname", rname);
            cmd.Parameters.AddWithValue("@rcap", rcap);
            cmd.Parameters.AddWithValue("@rprice", rprice);
            cmd.Parameters.AddWithValue("@rfeatures", rfeatures);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@aadhaar", aadhaar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxRoomNo.Text = dataGridViewRooms.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");

            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxCustomerID.Text = dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");
            }


        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchButtonPress();
        }

        private void dateTimePickerInDate_ValueChanged(object sender, EventArgs e)
        {
            GetStudentRecord();
            //SearchButtonPress();
        }

        private void dateTimePickerOutDate_ValueChanged(object sender, EventArgs e)
        {
            GetStudentRecord();
            //SearchButtonPress();
        }

        private bool CheckDates()
        {
            if(dateTimePickerInDate.Value <= dateTimePickerOutDate.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dataGridViewResvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxResvNo.Text = dataGridViewResvRooms.SelectedRows[0].Cells[0].Value.ToString();
                textBoxRoomNo.Text = dataGridViewResvRooms.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCustomerID.Text = dataGridViewResvRooms.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePickerOutDate.Value = DateTime.Parse(dataGridViewResvRooms.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePickerInDate.Value = DateTime.Parse(dataGridViewResvRooms.SelectedRows[0].Cells[3].Value.ToString());
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearRecordsSelected();
        }

        private void buttonSearchResvRooms_Click(object sender, EventArgs e)
        {
            SearchResvRooms();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(textBoxRoomNo.Text!="0" & textBoxCustomerID.Text!="0" & CheckDates())
            {
                SqlCommand cmd = new SqlCommand(@"Insert into ResvRooms values (@rno, @cid, @cind, @coud)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rno", textBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("@cid", textBoxCustomerID.Text);
                cmd.Parameters.AddWithValue("@cind", dateTimePickerInDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@coud", dateTimePickerOutDate.Value.ToString("yyyy-MM-dd"));
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
                    WriteIntoHistory();
                    MessageBox.Show("Added Successfully!", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                    ClearRecordsSelected();
                }


            }
            else
            {
                if(textBoxCustomerID.Text=="0")
                {
                    MessageBox.Show("Select a customer", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!CheckDates())
                {
                    MessageBox.Show("Checkin date should be less than checkout date", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Select a room", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxResvNo.Text != "0")
            {
                SqlCommand cmd = new SqlCommand(@"Delete from ResvRooms where ResvNo = @rid", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rid", textBoxResvNo.Text);
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
                    MessageBox.Show("Deleted Successfully!", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                    ClearRecordsSelected();
                }

                
            }
            else
            {
                MessageBox.Show("Select an entry to delete", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxResvNo.Text != "0" & textBoxRoomNo.Text != "0" & textBoxCustomerID.Text != "0" & CheckDates())
            {
                SqlCommand cmd = new SqlCommand(@"Update ResvRooms SET RoomNo = @rno, CustomerID = @cid, ResvinDate = @cind, ResvoutDate = @coud where ResvNo = @rid", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rid", textBoxResvNo.Text);
                cmd.Parameters.AddWithValue("@rno", textBoxRoomNo.Text);
                cmd.Parameters.AddWithValue("@cid", textBoxCustomerID.Text);
                cmd.Parameters.AddWithValue("@cind", dateTimePickerInDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@coud", dateTimePickerOutDate.Value.ToString("yyyy-MM-dd"));
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
                    UpdatingHistory();
                    MessageBox.Show("Updated Successfully!", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                    ClearRecordsSelected();
                }

                
            }
            else
            {
                if(textBoxResvNo.Text=="0")
                {
                    MessageBox.Show("Select an entry to update", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxCustomerID.Text=="0")
                {
                    MessageBox.Show("Select customer", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!CheckDates())
                {
                    MessageBox.Show("Checkin date should be less than checkout date", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Select room", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            FormHistory fh = new FormHistory();
            fh.Show();
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelInDate_Click(object sender, EventArgs e)
        {

        }

        private void labelOutDate_Click(object sender, EventArgs e)
        {

        }
    }

}
