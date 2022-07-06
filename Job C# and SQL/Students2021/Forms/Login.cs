using Students2021.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students2021.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string strCommand = "select UserName from UsersT";
            Methods method = new Methods();
            method.ComboListCreate(comboBox1, strCommand);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pass = null;
            SqlConnection SqlCon = new SqlConnection(Program.conStr);

            SqlCommand command = new SqlCommand($"select Pass from UsersT where UserName = '{comboBox1.Text}'", SqlCon);

            SqlCon.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                pass = dr.GetValue(0).ToString().Trim();
            }

            if (textBox1.Text == pass)
                Close();
            else
                MessageBox.Show("Неверный пароль. Повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
