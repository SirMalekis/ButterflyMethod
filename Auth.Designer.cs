namespace ButterFly
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.regLabel);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 488);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(227)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Palatino Linotype", 25F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(200, 370);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(137, 55);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(99, 262);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(379, 60);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(99, 166);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(379, 64);
            this.loginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(489, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 29);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Авторизация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(167)))), ((int)(((byte)(250)))));
            this.regLabel.Location = new System.Drawing.Point(176, 428);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(179, 26);
            this.regLabel.TabIndex = 6;
            this.regLabel.Text = "Ещё нет аккаунта?";
            this.regLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 488);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label regLabel;
    }
}

