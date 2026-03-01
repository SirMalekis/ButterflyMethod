namespace ButterFly
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.regLabel);
            this.panel1.Controls.Add(this.userSurnameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(167)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(468, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "При создании пароля допустимы только буквы, цифры и знаки препинания";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(167)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(82, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "При создании логина допустимы только буквы и цифры";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(167)))), ((int)(((byte)(250)))));
            this.regLabel.Location = new System.Drawing.Point(326, 413);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(155, 26);
            this.regLabel.TabIndex = 8;
            this.regLabel.Text = "Авторизоваться";
            this.regLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(468, 166);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(303, 64);
            this.userSurnameField.TabIndex = 7;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userSurnameField_KeyPress);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(82, 166);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(291, 64);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameField_KeyPress);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // buttonReg
            // 
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(92)))));
            this.buttonReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(227)))));
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Palatino Linotype", 25F);
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(220, 357);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(369, 54);
            this.buttonReg.TabIndex = 5;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(468, 251);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(303, 64);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passField_KeyPress);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(82, 251);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(291, 64);
            this.loginField.TabIndex = 3;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginField_KeyPress);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(398, 251);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 251);
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
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(776, 0);
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
            this.label2.Size = new System.Drawing.Size(800, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Регистрация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg";
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
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}