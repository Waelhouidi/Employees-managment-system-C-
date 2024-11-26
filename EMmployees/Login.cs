using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EMmployees
{
    public partial class Login : Form
    {
        private Color originalButtonColor = Color.LightGray;
        private Color hoverButtonColor = Color.FromArgb(100, 149, 237); 
        private Timer hoverTimer;
        private Timer openAnimationTimer;
        private float opacityStep = 0.05f; 
        private int sizeStep = 10;         
        private bool isButtonHovering = false;

        private bool isPictureHovering = false;
        private Timer labelTimer;
        private int originalWidth;
        private int originalHeight;

        public Login()
        {
            InitializeComponent();
            SetupButtonHoverEffect();
            SetupPictureBoxHoverEffect();
            InitializeOpenAnimation();
        }

        private void InitializeOpenAnimation()
        {
            this.Opacity = 0;  
            originalWidth = this.Width;
            originalHeight = this.Height;

            this.Size = new Size(originalWidth - 50, originalHeight - 50);
            this.StartPosition = FormStartPosition.CenterScreen;

            openAnimationTimer = new Timer();
            openAnimationTimer.Interval = 30;  
            openAnimationTimer.Tick += OpenAnimationTimer_Tick;
            openAnimationTimer.Start();
        }

        private void OpenAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += opacityStep;

            if (this.Width < originalWidth || this.Height < originalHeight)
            {
                this.Width += sizeStep;
                this.Height += sizeStep;

                this.Left -= sizeStep / 2;
                this.Top -= sizeStep / 2;
            }

            if (this.Opacity >= 1 && this.Width >= originalWidth && this.Height >= originalHeight)
            {
                openAnimationTimer.Stop();
            }
        }

        private void SetupButtonHoverEffect()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = originalButtonColor;

                    button.MouseEnter += (s, e) => { isButtonHovering = true; hoverTimer.Start(); };
                    button.MouseLeave += (s, e) => { isButtonHovering = false; };
                }
            }

            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += (s, e) =>
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = ColorTransition(button.BackColor, isButtonHovering ? hoverButtonColor : originalButtonColor, 0.1f);
                    }
                }
            };
        }

        private void SetupPictureBoxHoverEffect()
        {
       titlelabel.ForeColor = Color.Transparent; 

            pictureBox1.MouseEnter += (s, e) => { isPictureHovering = true; labelTimer.Start(); };
            pictureBox1.MouseLeave += (s, e) => { isPictureHovering = false; };

            labelTimer = new Timer();
            labelTimer.Interval = 30;
            labelTimer.Tick += (s, e) =>
            {
            titlelabel.ForeColor = ColorTransition(titlelabel.ForeColor, isPictureHovering ? Color.Black : Color.Transparent, 0.1f);
            };
        }

        private Color ColorTransition(Color start, Color end, float percentage)
        {
            int r = (int)(start.R + (end.R - start.R) * percentage);
            int g = (int)(start.G + (end.G - start.G) * percentage);
            int b = (int)(start.B + (end.B - start.B) * percentage);
            return Color.FromArgb(r, g, b);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin savedAdmin = LoadAdminAccount();

            if (savedAdmin != null)
            {
                if (savedAdmin.UserName == username.Text && savedAdmin.Password == passwordLogin.Text)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                   
                   
                }
                else
                {
                    
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Admin account not found.");
            }
        }

        private Admin LoadAdminAccount()
        {
            try
            {
                string filePath = "data.txt"; 
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string userName = reader.ReadLine();
                        string password = reader.ReadLine();
                        return new Admin(userName, password);
                    }
                }
                else
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading admin account: {ex.Message}");
                return null;
            }
        }
    }
}
