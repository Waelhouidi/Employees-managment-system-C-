namespace EMmployees
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.AddEmployeesBtn = new System.Windows.Forms.Button();
            this.dhasboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dhachy1 = new EMmployees.dhachy();
            this.addEmployee1 = new EMmployees.AddEmployee();
            this.salarycs1 = new EMmployees.Salarycs();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SalaryBtn);
            this.panel1.Controls.Add(this.AddEmployeesBtn);
            this.panel1.Controls.Add(this.dhasboardBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 677);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome User :";
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.Location = new System.Drawing.Point(35, 407);
            this.SalaryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(171, 47);
            this.SalaryBtn.TabIndex = 3;
            this.SalaryBtn.Text = "Salary";
            this.SalaryBtn.UseVisualStyleBackColor = true;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click);
            // 
            // AddEmployeesBtn
            // 
            this.AddEmployeesBtn.Location = new System.Drawing.Point(35, 338);
            this.AddEmployeesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEmployeesBtn.Name = "AddEmployeesBtn";
            this.AddEmployeesBtn.Size = new System.Drawing.Size(171, 47);
            this.AddEmployeesBtn.TabIndex = 2;
            this.AddEmployeesBtn.Text = "Add Employee";
            this.AddEmployeesBtn.UseVisualStyleBackColor = true;
            this.AddEmployeesBtn.Click += new System.EventHandler(this.AddEmployeesBtn_Click);
            // 
            // dhasboardBtn
            // 
            this.dhasboardBtn.Location = new System.Drawing.Point(35, 262);
            this.dhasboardBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dhasboardBtn.Name = "dhasboardBtn";
            this.dhasboardBtn.Size = new System.Drawing.Size(171, 47);
            this.dhasboardBtn.TabIndex = 1;
            this.dhasboardBtn.Text = "Dashboard";
            this.dhasboardBtn.UseVisualStyleBackColor = true;
            this.dhasboardBtn.Click += new System.EventHandler(this.dhasboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees Managment System";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dhachy1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salarycs1);
            this.panel3.Location = new System.Drawing.Point(244, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 685);
            this.panel3.TabIndex = 2;
            // 
            // log
            // 
            this.log.ErrorImage = ((System.Drawing.Image)(resources.GetObject("log.ErrorImage")));
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.InitialImage = ((System.Drawing.Image)(resources.GetObject("log.InitialImage")));
            this.log.Location = new System.Drawing.Point(35, 563);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(32, 32);
            this.log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.log.TabIndex = 5;
            this.log.TabStop = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(90, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "LogOut";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dhachy1
            // 
            this.dhachy1.Location = new System.Drawing.Point(11, 8);
            this.dhachy1.Name = "dhachy1";
            this.dhachy1.Size = new System.Drawing.Size(1098, 626);
            this.dhachy1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(3, 3);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1106, 627);
            this.addEmployee1.TabIndex = 1;
            // 
            // salarycs1
            // 
            this.salarycs1.Location = new System.Drawing.Point(11, 3);
            this.salarycs1.Name = "salarycs1";
            this.salarycs1.Size = new System.Drawing.Size(1109, 655);
            this.salarycs1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1357, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Employees managment system";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button AddEmployeesBtn;
        private System.Windows.Forms.Button dhasboardBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private AddEmployee addEmployee1;
        private Salarycs salarycs1;
        private dhachy dhachy1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox log;
    }
}