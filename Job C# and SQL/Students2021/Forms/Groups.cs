using Students2021.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students2021.Forms
{
    public partial class Groups : Form
    {
        private Methods methods;
        public Groups()
        {
            InitializeComponent();
            methods = new Methods();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.FormClosed += (x, y) =>dataGridView1.DataSource = methods.GetTable("sp_SelectFromGroupT");
            addGroup.ShowDialog();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = methods.GetTable("sp_SelectFromGroupT");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                methods.DeleteFromTable("sp_DeleteFromGroupT", "@GrName", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
