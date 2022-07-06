using Students2021.Codes;
using Students2021.Forms;
using Students2021.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Students2021
{
    public partial class Glavn : Form
    {
        private Methods methods;
        public Glavn()
        {
            InitializeComponent();
            methods = new Methods();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form login = new Forms.Login();
            login.ShowDialog();

            methods.ComboListCreate(comboBox2, "select GrName from GroupT");
            dataGridView1.DataSource = methods.GetTable("sp_SelectFromStudT");

        }
//----------------------------------------------------------------------------------------------------------------
        private void Button6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("Проверьте обязательные поля для заполнения", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                List<SpParams>  listParams = new List<SpParams>{
                    new SpParams { Param = "@IdStud", Value = textBox1.Text },
                    new SpParams { Param = "@Fam", Value = textBox2.Text },
                    new SpParams { Param = "@Name", Value = textBox4.Text },
                    new SpParams { Param = "@Otch", Value = textBox5.Text },
                    new SpParams { Param = "@Date", Value = dateTimePicker1.Value},
                    new SpParams { Param = "@Adres", Value = textBox8.Text },
                    new SpParams { Param = "@GrName", Value = comboBox2.Text },
                    new SpParams { Param = "@PGr", Value = comboBox1.Text }
                };
                methods.SpAdd("sp_InsertInToStudT", listParams);
            }

            dataGridView1.DataSource = methods.GetTable("sp_SelectFromStudT");
        }
//----------------------------------------------------------------------------------------------------------------

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox8.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);

            textBox1.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button1.Enabled = true;
        }

        private void ГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<SpParams> listParams = new List<SpParams>{
                    new SpParams { Param = "@IdStud", Value = textBox1.Text },
                    new SpParams { Param = "@Fam", Value = textBox2.Text },
                    new SpParams { Param = "@Name", Value = textBox4.Text },
                    new SpParams { Param = "@Otch", Value = textBox5.Text },
                    new SpParams { Param = "@Date", Value = dateTimePicker1.Value},
                    new SpParams { Param = "@Adres", Value = textBox8.Text },
                    new SpParams { Param = "@GrName", Value = comboBox2.Text },
                    new SpParams { Param = "@PGr", Value = comboBox1.Text }
                };
            methods.SpAdd("sp_UpdateStud", listParams);

            textBox1.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button1.Enabled = false;

            foreach (Control tb in Controls)
            {
                if (tb is TextBox)
                    tb.Text = string.Empty;
            }
            dataGridView1.DataSource = methods.GetTable("sp_SelectFromStudT");
        }
    }
}
