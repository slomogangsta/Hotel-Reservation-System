using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRS_Application
{
    public partial class LandingPageForm : Form
    {
        public LandingPageForm()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void username_Validation(object sender, CancelEventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                e.Cancel = true;
                errorProviderUsername.SetError(textBoxUsername, "Username cannot be empty!");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxUsername.Text, "^[a-zA-Z ]"))
            {
                e.Cancel = true;
                errorProviderUsername.SetError(textBoxUsername, "Username can only consist of alphabets!");
            }
            else
            {
                e.Cancel = false;
                errorProviderUsername.SetError(textBoxUsername, "");
            }
        
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textBoxUsername.Text == "admin" & textBoxPassword.Text == "Admin@123")
                {
                    MessageBox.Show("You have sucessfully logged in");
                    this.Hide();
                    ApplicationForm af = new ApplicationForm();
                    af.Show();
                }
                else if (textBoxUsername.Text != "admin")
                {
                    MessageBox.Show("You've entered wrong username");
                    textBoxUsername.Focus();
                }
                else
                {
                    MessageBox.Show("You've entered wrong password");
                    textBoxPassword.Focus();
                }
            }
        }

        private void password_Validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                e.Cancel = true;
                errorProviderPassword.SetError(textBoxPassword, "Username cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProviderPassword.SetError(textBoxPassword, "");
            }
        }

        private void buttonCloseWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestoreWin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimizeWin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
