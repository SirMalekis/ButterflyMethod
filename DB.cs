using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ButterFly
{
    internal class DB
    {
        private readonly string dataSource;
        public DB(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection con = new SQLiteConnection(dataSource);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                                + "CREATE TABLE users("
                                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                + "login TEXT, "
                                + "pass TEXT, "
                                + "name TEXT, "
                                + "surname TEXT);";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Dispose();
            }
            return true;
        }
        public int UsersID()
        {
            SQLiteConnection con = new SQLiteConnection(dataSource);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    string sql_command = "SELECT count(id) FROM users";
                    cmd.CommandText = sql_command;
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Dispose();
            }
            return -1;
        }
        public bool ValidUser(string username, string password)
        {
            SQLiteConnection con = new SQLiteConnection(dataSource);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = string.Format("SELECT login, pass, name, surname"
                    + "FROM users"
                    + "where login = '{0}' AND"
                    + "password = '{1}'",
                   username, password);
                    var usersCount = (int)cmd.ExecuteScalar();
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Dispose();
            }
            return false;
        }
    }
}