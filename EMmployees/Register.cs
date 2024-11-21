using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EMmployees
{
    public partial class Register : Form
    {
        private Timer zoomTimer;
        private Timer successLabelTimer;
        private Timer navigationTimer;  
        private bool isZoomingIn = false;
        private int zoomStep = 5;
        private int targetZoomSize = 150; 
        private int fadeStep = 5;
        private int originalPictureBoxWidth;
        private int originalPictureBoxHeight;
        private int originalPictureBoxX;
        private int originalPictureBoxY;

        public Register()
        {
            InitializeComponent();
            SetupRealTimeValidation();
            originalPictureBoxWidth = pictureBox1.Width;
            originalPictureBoxHeight = pictureBox1.Height;
            originalPictureBoxX = pictureBox1.Location.X;
            originalPictureBoxY = pictureBox1.Location.Y;
        }

        private void SetupRealTimeValidation()
        {
            userRegister.TextChanged += userRegister_TextChanged;
            password.TextChanged += password_TextChanged;
            confirmpassword.TextChanged += confirmpassword_TextChanged;
        }

        private void userRegister_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(userRegister.Text, @"[^a-zA-Z0-9]"))
            {
                label4.Text = "Username cannot contain special characters.";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = ""; 
            }
        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != confirmpassword.Text)
            {
                label4.Text = "Passwords do not match.";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = ""; 
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            confirmpassword_TextChanged(sender, e);
        }

        private void RegisterNow_Click(object sender, EventArgs e)
        {

            if (password.Text == confirmpassword.Text && label4.Text == "")
            {
                Admin AdminAcount= new Admin(userRegister.Text, password.Text);
                SaveAdminAccount(AdminAcount);

                StartZoomInAnimation();
                StartSuccessLabelAnimation("Registration Successful!");

                userRegister.Enabled = true;
                password.Enabled = true;
                confirmpassword.Enabled = true;

                StartNavigationTimer();
            }
            else
            {
                label4.Text = "Please fix the errors above.";
                label4.ForeColor = Color.Red;
            }
        }
        private void SaveAdminAccount(Admin admin)
        {
            try
            {
                string filePath = "data.txt"; // This could be a path to your file
                using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrite existing file
                {
                    writer.WriteLine(admin.UserName);  // Save username
                    writer.WriteLine(admin.Password);  // Save password
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving admin account: {ex.Message}");
            }
        }

        private void StartZoomInAnimation()
        {
            isZoomingIn = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new Size(originalPictureBoxWidth, originalPictureBoxHeight); 

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            zoomTimer = new Timer();
            zoomTimer.Interval = 30;
            zoomTimer.Tick += (sender, e) =>
            {
                if (isZoomingIn && pictureBox1.Width < targetZoomSize)
                {
                    pictureBox1.Width += zoomStep;
                    pictureBox1.Height += zoomStep;

                    pictureBox1.Location = new Point(centerX - pictureBox1.Width / 2, centerY - pictureBox1.Height / 2);
                }
                else
                {
                    zoomTimer.Stop();
                    isZoomingIn = false;
                }
            };

            zoomTimer.Start();
        }

        private void StartSuccessLabelAnimation(string message)
        {
            label4.Text = message;
            label4.ForeColor = Color.Green;
            label4.Visible = true;

            label4.ForeColor = Color.FromArgb(0, label4.ForeColor.R, label4.ForeColor.G, label4.ForeColor.B);

            successLabelTimer = new Timer();
            successLabelTimer.Interval = 30; 
            successLabelTimer.Tick += (sender, e) =>
            {
                if (label4.ForeColor.A < 255)
                {
                    label4.ForeColor = Color.FromArgb(label4.ForeColor.A + fadeStep, label4.ForeColor.R, label4.ForeColor.G, label4.ForeColor.B);
                }
                else
                {
                    successLabelTimer.Stop();
                }
            };

            successLabelTimer.Start();
            RegisterNow.Hide(); 
            password.Hide();
            confirmpassword.Hide();
            userRegister.Hide();
            label3.Hide();
            label1.Hide();
            label2.Hide();




        }

        private void StartNavigationTimer()
        {
            navigationTimer = new Timer();
            navigationTimer.Interval = 2000; 
            navigationTimer.Tick += (sender, e) =>
            {
                try
                {
                    navigationTimer.Stop();
                    OpenLoginForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            };

            navigationTimer.Start();
        }

        private void OpenLoginForm()
        {
            try
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening login form: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
