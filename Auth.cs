using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ButterFly
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastpoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "" || passField.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } // проверка на заполнение полей

            string loginUser = loginField.Text;
            //string passwordUser = passField.Text;
            string passwordUser = md5.hashPassword(passField.Text);

            string dbPath = System.IO.Path.Combine(Application.StartupPath, "databasefile.db");
            SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SQLiteCommand com = connection.CreateCommand();
            com.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            com.CommandText = "SELECT * FROM 'users' WHERE login = @login AND pass = @pass";

            com.Parameters.Add("@login", DbType.String).Value = loginField.Text;
            //com.Parameters.Add("@pass", DbType.String).Value = passField.Text;
            com.Parameters.Add("@pass", DbType.String).Value = md5.hashPassword(passField.Text);

            adapter.SelectCommand = com;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешная авторизация!");
                this.Hide(); // форма авторизации скрывается
                ButterflyMethod butterflymethod = new ButterflyMethod();
                butterflymethod.ShowDialog(); // переход к главной форме
                this.Close(); // закрывается форма авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                loginField.Clear();
                passField.Clear();
            }
        }
        private void regLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }
    }
}
