using Students2021.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students2021.Codes
{
    class Methods
    {
        private SqlConnection SqlCon;
        private SqlCommand sqlCommand;
        public Methods()
        {
            SqlCon = new SqlConnection(Program.conStr);
        }
        public void ComboListCreate(ComboBox comboBox, string command)
        {
            sqlCommand = new SqlCommand(command, SqlCon);
            SqlCon.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
            {
                comboBox.Items.Add(dr.GetValue(0).ToString().Trim());
            }
            comboBox.SelectedIndex = 0;
            SqlCon.Close();
        }

        public DataTable GetTable(string sp)
        {
            sqlCommand = new SqlCommand(sp, SqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            DataTable dt = new DataTable();

            SqlCon.Open();
            dt.Load(sqlCommand.ExecuteReader());
            SqlCon.Close();

            return dt;
        }

        public void DeleteFromTable(string sp, string param, string value)
        {
            sqlCommand = new SqlCommand(sp, SqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter(param, value));

            SqlCon.Open();
            sqlCommand.ExecuteReader();
            SqlCon.Close();
        }

        public void SpAdd(string sp, List<SpParams> spParams)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.conStr))
            {
                sqlCommand = new SqlCommand(sp, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                //Подставляем параметры в хранимую процедуру
                foreach (var param in spParams) {
                    sqlCommand.Parameters.Add(new SqlParameter(param.Param, param.Value));
                }
                try { 
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch {
                    MessageBox.Show("Внимание! \nВозможно используется неверный тип данных. Проверьте поле \"Код студента\"", "Сработал блок обработки исключений", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
