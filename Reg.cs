using System.Data;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace ButterFly
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();

            userNameField.Text = "Имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Фамилия";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Пароль";
            passField.ForeColor = Color.Gray;
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
            if (e.Button == MouseButtons.Left)
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Имя";
                userNameField.ForeColor = Color.Gray;
            }
                
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Фамилия")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Фамилия";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Пароль";
                passField.ForeColor = Color.Gray;
            }
        }
        public Boolean CheckUser()
        {
            string loginUser = loginField.Text;

            SQLiteConnection connection = new SQLiteConnection("Data Source=databasefile.db");
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM `users` WHERE `login` = @loginUser";

            command.Parameters.Add("@loginUser", DbType.String).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегистрирован, введите другой");
                loginField.Clear();
                passField.Clear();
                return true;
            }
            else
                return false;
        }

        public void Check()
        {
            if (loginField.Text == "" || passField.Text == "" || userNameField.Text == "" || userSurnameField.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } // проверка на заполнение полей
            if (CheckUser())
            {
                return;
            } // проверка на наличие уже имеющегося пользователя
        } // проверки

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            //string passwordUser = passField.Text;
            string passwordUser = md5.hashPassword(passField.Text);
            string nameUser = userNameField.Text;
            string surnameUser = userSurnameField.Text;

            if (userNameField.Text == "Имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurnameField.Text == "Фамилия")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (CheckUser())
                return;

            Check();

            SQLiteConnection connection = new SQLiteConnection("Data Source=databasefile.db");
            connection.Open();

            SQLiteCommand com = connection.CreateCommand();
            com.Connection = connection;

            com.CommandText = "INSERT INTO users (login, pass, name, surname) VALUES (@login, @pass, @name, @surname)";
            com.Parameters.AddWithValue("@login", loginUser);
            com.Parameters.AddWithValue("@pass", passwordUser);
            com.Parameters.AddWithValue("@name", nameUser);
            com.Parameters.AddWithValue("@surname", surnameUser);


            if (com.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт успешно зарегестрирован");
            else
                MessageBox.Show("Ошибка регистрации аккаунта");
        }
        private void regLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void userNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetter(S) && S != 8)
                e.Handled = true;
        }

        private void userSurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetter(S) && S != 8)
                e.Handled = true;
        }

        private void loginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void passField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && !Char.IsPunctuation(S) && S != 8)
                e.Handled = true;
        }
    }
}
