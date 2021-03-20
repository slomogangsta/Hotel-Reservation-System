using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Geom;
using System.Net;
using System.Net.Mail;



namespace HRS_Application
{
    public partial class FormBilling : Form
    {
        public FormBilling()
        {
            InitializeComponent();
            GetResvRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NCM8HN8\SQLEXPRESS; Initial Catalog = DemoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void GetResvRecords()
        {
            string query = "Select * from ResvRooms";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView2.DataSource = dt;
        }

        int[] arrRoomID = { 101, 102, 103, 104, 105 };

        private void FormBilling_Load(object sender, EventArgs e)
        {
            GetResvRecords();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                GetResvRecords();
            }
        }


        private string getHtml()
        {
            try
            {
                string messageBody = "<font><h2><center>Pai Group of International Hotels </center></h2></font><br>";
                messageBody += "<font><h3><center>President Hotel, Hubballi, Karnataka, India - 580031</center></h3></font><br>";
                messageBody += "<font><h4><center>GSTIN: 29AACAK9702A1ZV</center></h4></font><br>";
                messageBody += "<hr>";
                messageBody += "<font><h3><u>Customer Details</u></h3></font><br>";
                messageBody += "Name: " + textBoxCustomerFName.Text + textBoxCustomerLName.Text +"<br>";
                messageBody += "contact: "+textBoxEmail.Text + textBoxMobileNo.Text+"<br>";
                messageBody += "Government ID (Aadhaar):" + textBoxAadhaar.Text + "<br>";
                messageBody += "GSTIN (Customer): "+textBoxGSTIN.Text+"<br>";
                messageBody += "<hr>";
                messageBody += "<font><h3><u>Room Details</u></h3></font><br><br>";
                string query = "Select RoomName from RoomInfo where RoomID = @rid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rid", textBoxRoomID.Text);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string RoomName = sdr["RoomName"].ToString();
                con.Close();
                messageBody += "Room Type:"+RoomName+"<br>";
                messageBody += "Reservation ID:"+resvno+"<br>";
                messageBody += "Price Per Day: " + textBoxPrice.Text + "<br>";
                messageBody += "No of Days: " + textBoxDays.Text + "(From: )" + resindate + " to " + resoutdate+"<br>";
                messageBody += "Additional Price: "+ textBoxAdditionalPrice.Text+"<br>";
                messageBody += "Discount %: "+textBoxDiscount.Text+"<br>";
                messageBody += "Tax %: "+textBoxTax.Text+"<br>";
                messageBody += "<hr>";
                messageBody += "Total Payable Amount: "+textBoxTotal.Text+"<br>";


                return messageBody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new System.Net.Mail.MailAddress("paihotels28@gmail.com");
                message.To.Add(new MailAddress(textBoxEmail.Text));
                message.Subject = "Pai Hotel invoice" + textBoxDays.Text + "(From: )" + resindate + " to " + resoutdate;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("paihotels28@gmail.com", "Pai@hotel123");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }


        private void buttonRefreshCustomer_Click(object sender, EventArgs e)
        {
            string htmlString = getHtml();  
            Email(htmlString);
            MessageBox.Show("Email sent successfully!","Invoice Email", MessageBoxButtons.OK);
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = "0";
            textBoxRoomID.Text = "0";
            textBoxDiscount.Text = "0";
            textBoxDays.Clear();
            textBoxAdditionalPrice.Text = "0";
            textBoxTax.Text = "18";
            textBoxGSTIN.Clear();
            textBoxTotal.Text = "0";
            textBoxCustomerID.Text = "0";
            textBoxAadhaar.Clear();
            textBoxCustomerFName.Clear();
            textBoxCustomerLName.Clear();
            textBoxEmail.Clear();
            textBoxMobileNo.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textBoxPrice.Text != "0")
                {
                    float tax = int.Parse(textBoxTax.Text);
                    tax = (tax / 100) + 1;
                    float discount = int.Parse(textBoxDiscount.Text);
                    discount = 1 - (discount / 100);
                    int price = (int.Parse(textBoxPrice.Text));
                    int days = (int.Parse(textBoxDays.Text));
                    int addprice = (int.Parse(textBoxAdditionalPrice.Text));
                    float totprice;
                    totprice = price * days;
                    totprice *= discount;
                    totprice *= tax;
                    totprice += addprice;
                    totprice = MathF.Floor(totprice);
                    textBoxTotal.Text = totprice.ToString();
                }
                else
                {
                    MessageBox.Show("Select a room type", "Price Calculate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void validation_Days(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDays.Text) || textBoxDays.Text == "0")
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

        private void validation_AdditionalPrice(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxAdditionalPrice.Text, "^[0-9]"))
            {
                e.Cancel = true;
                errorProviderAdditionalPrice.SetError(textBoxAdditionalPrice, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdditionalPrice.SetError(textBoxAdditionalPrice, "");
            }
        }
        
        private void validation_GSTIN(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxGSTIN.Text, "^[a-zA-Z0-9]"))
            {
                e.Cancel = true;
                errorProviderGSTIN.SetError(textBoxGSTIN, "Only +ve numeric values are accepted");
            }
            else
            {
                e.Cancel = false;
                errorProviderGSTIN.SetError(textBoxGSTIN, "");
            }
        }

        string resvno;
        string roomno;
        string customerid;
        string resindate;
        string resoutdate;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                resvno = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                roomno = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCustomerID.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                resindate = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                resoutdate = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                FeedOtherValues();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: ", outOfRange.Message);
                MessageBox.Show("please select whole row");
            }


        }

        private void FeedOtherValues()
        {
            string query = "Select RoomPrice from RoomInfo where RoomID in (Select RoomID from RoomsNew where RoomNo = @rno)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rno", roomno);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            textBoxPrice.Text = sdr["RoomPrice"].ToString();
            con.Close();
            query = "Select RoomID from RoomsNew where RoomNo = @rno";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rno", roomno);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();
            textBoxRoomID.Text = sdr["RoomID"].ToString();
            con.Close();
            DateTime StartDate = DateTime.Parse(resindate);
            DateTime EndDate = DateTime.Parse(resoutdate);
            textBoxDays.Text = (EndDate - StartDate).TotalDays.ToString();

            query = "Select * from Customer where CustomerID = @cin";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cin", textBoxCustomerID.Text);
            con.Open();
            sdr = cmd.ExecuteReader();
            sdr.Read();

            textBoxCustomerFName.Text = sdr["FirstName"].ToString();
            textBoxCustomerLName.Text = sdr["LastName"].ToString();
            textBoxEmail.Text = sdr["Email"].ToString();
            textBoxMobileNo.Text = sdr["Mobile"].ToString();
            textBoxAadhaar.Text = sdr["Aadhaar"].ToString();
            con.Close();
        }

        private void PrinttoPDF()
        {
            PdfWriter writer1 = new PdfWriter("C:\\Users\\VIJAYLAXMI\\Desktop\\pdf\\" + textBoxCustomerID.Text + ".pdf");
            PdfDocument pdf1 = new PdfDocument(writer1);
            Document document1 = new Document(pdf1, PageSize.A4, false);

            Paragraph header = new Paragraph("Pai Group of International Hotels")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);
            document1.Add(header);

            Paragraph subheader = new Paragraph("President Hotel, Hubballi, Karnataka, India - 580031")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15);
            document1.Add(subheader);

            Paragraph gst = new Paragraph("GSTIN: 29AACAK9702A1ZV")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14);
            document1.Add(gst);

            LineSeparator ls = new LineSeparator(new SolidLine());
            document1.Add(ls);

            Paragraph CustomerDetails = new Paragraph("Customer Details")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(14)
                .SetUnderline();
            document1.Add(CustomerDetails);

            Paragraph Name = new Paragraph("Name: " + textBoxCustomerFName.Text + " " + textBoxCustomerLName.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Name);

            Paragraph Contact = new Paragraph("Contact: " + textBoxEmail.Text + ", " + textBoxMobileNo.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Contact);

            Paragraph Govtid = new Paragraph("Government ID (Aadhaar): " + textBoxAadhaar.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Govtid);

            Paragraph GstCus = new Paragraph("GSTIN (Customer): " + textBoxGSTIN.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(GstCus);

            document1.Add(ls);
            Paragraph RoomDetails = new Paragraph("Room Details:")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetUnderline()
                .SetFontSize(12);
            document1.Add(RoomDetails);

            string query = "Select RoomName from RoomInfo where RoomID = @rid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rid", textBoxRoomID.Text);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string RoomName = sdr["RoomName"].ToString();
            con.Close();
            Paragraph RoomN = new Paragraph("Room Type: " + RoomName)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(RoomN);

            Paragraph ResvN = new Paragraph("Reservation ID: " + resvno)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(ResvN);

            Paragraph Price = new Paragraph("Price Per Day: " + textBoxPrice.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Price);

            Paragraph Ndays = new Paragraph("No of Days: " + textBoxDays.Text + "(From: )" + resindate + " to " + resoutdate)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Ndays);

            Paragraph Aprice = new Paragraph("Additional Price: " + textBoxAdditionalPrice.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Aprice);

            Paragraph Discount = new Paragraph("Discount %: " + textBoxDiscount.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Discount);

            Paragraph Tax = new Paragraph("Tax %: " + textBoxTax.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            document1.Add(Tax);

            document1.Add(ls);
            Paragraph Total = new Paragraph("Total Payable Amount: " + textBoxTotal.Text)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(14);
            document1.Add(Total);

            document1.Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if(textBoxRoomID.Text!="0" & textBoxCustomerID.Text!="0")
            {
                PrinttoPDF();
                MessageBox.Show("PDF Generated successfully!", "PDF Generation", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Select an entry to generate bill", "Invoice Generation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdditionalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGSTIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAadhaar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCustomerFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
