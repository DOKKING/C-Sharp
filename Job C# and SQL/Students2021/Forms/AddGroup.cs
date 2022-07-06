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
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) {
                MessageBox.Show("Поле \"Название группы\" не может быть пустым!");
                return;
            }
            else
                using (SqlConnection sqlCon = new SqlConnection(Program.conStr))
                {
                    SqlCommand sqlCommand = new SqlCommand("sp_InsertIntoGroupT", sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    sqlCommand.Parameters.Add(new SqlParameter("@GrName", textBox1.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@GrStar", textBox2.Text));

                    try
                    {
                        sqlCon.Open();
                        sqlCommand.ExecuteReader();
                        sqlCon.Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Проверьте уникальность группы!");
                        return;
                    }
                    Close();
                }
        }
    }
}
