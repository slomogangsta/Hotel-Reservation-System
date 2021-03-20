using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace HRS_Application
{
    public partial class FormPrice : Form
    {

        public FormPrice()
        {
            InitializeComponent();
        }

        int[] arrRoomID = { 101, 102, 103, 104, 105 };

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void validation_Days(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDays.Text) || textBoxDays.Text=="0")
            {
                e.Cancel = true;
                errorProviderDays.SetError(textBoxDays, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxDays.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderDays.SetError(textBoxDays, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderDays.SetError(textBoxDays, "");
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRoomID.Text = arrRoomID[comboBoxRoomType.SelectedIndex].ToString();
            SqlCommand cmd = new SqlCommand("Select RoomPrice from RoomInfo where RoomID = @rid", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@rid", int.Parse(textBoxRoomID.Text));
            con.Open();
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                textBoxPrice.Text = sdr["RoomPrice"].ToString();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + cmd);
                Console.WriteLine();
               
            }
            finally
            {

                con.Close();
            }
        }

        private void ClearRecords()
        {
            textBoxPrice.Text = "0";
            textBoxDays.Clear();
            textBoxDiscount.Text = "0";
            textBoxTax.Text = "0";
            textBoxRoomID.Text = "0";
            textBoxTotal.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textBoxPrice.Text!="0")
                {
                    float tax = int.Parse(textBoxTax.Text);
                    tax = (tax / 100) + 1;
                    float discount = int.Parse(textBoxDiscount.Text);
                    discount = 1 - (discount / 100);
                    int price = (int.Parse(textBoxPrice.Text));
                    int days = (int.Parse(textBoxDays.Text));
                    float totprice;
                    totprice = price * days;
                    totprice *=  discount;
                    totprice *= tax;
                    totprice = MathF.Floor(totprice);
                    textBoxTotal.Text = totprice.ToString();
                }
                else
                {
                    MessageBox.Show("Select a room type", "Price Calculate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void validation_Tax(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTax.Text) || textBoxTax.Text == "0")
            {
                e.Cancel = true;
                errorProviderTax.SetError(textBoxTax, "This field cannot be empty");
            }
            else if (!Regex.IsMatch(textBoxTax.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderTax.SetError(textBoxTax, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderTax.SetError(textBoxTax, "");
            }
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ClearRecords();
        }

        private void validation_Discount(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxDiscount.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderDiscount.SetError(textBoxDiscount, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderDiscount.SetError(textBoxDiscount, "");
            }
        }
    }
}
