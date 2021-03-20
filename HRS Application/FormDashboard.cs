using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HRS_Application
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            GetCheckInList();
            GetCheckOutList();
            GetActiveReservationList();
            GetStudentRecord();
            GetpercatList();
        }

       
        

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void GetStudentRecord()
        {
            string query = "Select count(RoomNo) AS AvailableRooms from RoomsNew where RoomNo in (Select RoomNo from RoomsNew where RoomNo not in (Select RoomNo from ResvRooms where NOT(@Checkin > ResvoutDate or @Checkout < ResvinDate)))";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Checkin", dateTimePickerInDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Checkout", dateTimePickerOutDate.Value.ToString("yyyy-MM-dd"));
            DataTable dt = new DataTable();
            con.Open();
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                textBoxAvailable.Text = sdr["AvailableRooms"].ToString();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                //sdr.Close();
            }
            finally
            {

                con.Close();
            }
            
            
        }


        private void GetCheckInList()
        {
            string query = "select RoomID,RoomName,CustomerID,FirstName,LastName,Email,Mobile,Aadhaar from ResvHistory where ResvinDate=cast(getdate() AS Date)";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewcheckin.DataSource = dt;
        }
        private void GetCheckOutList()
        {
            string query = "select RoomID,RoomName,CustomerID,FirstName,LastName,Email,Mobile,Aadhaar from ResvHistory where ResoutDate=cast(getdate() AS Date)";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewCheckOut.DataSource = dt;
        }

        private void GetActiveReservationList()
        {
            string query = "select count(*) AS Active from ResvHistory where ResvinDate >=cast(getdate() AS Date)";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            textBoxActive.Text = sdr["Active"].ToString();
            con.Close();
            
        }

        private void dateTimePickerInDate_ValueChanged(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void dateTimePickerOutDate_ValueChanged(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetpercatList()
        {
            string query = "SELECT cast(RoomInfo.RoomName AS nvarchar(100))RoomName,count(cast(RoomsNew.RoomID AS int)) AS NumberOfRooms FROM RoomsNew LEFT JOIN RoomInfo ON RoomsNew.RoomID = RoomInfo.RoomID GROUP BY cast(RoomName AS nvarchar(100))";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridViewpercat.DataSource = dt;
        }

        private void textBoxActive_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
