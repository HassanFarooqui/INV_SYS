using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IVN_SYS.Models;
using System.Data.SqlClient;

namespace IVN_SYS
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            if (BtnSave.Text == "Update")
            {
                UpdateRecord();
            }
            else
            {
                SaveRecord();
            }

        }

        public void SaveRecord()
        {
            var userName = TbxUserName.Text;
            var pwd = TbxPassword.Text;
            ConnectionStringClass Con = new ConnectionStringClass();
            SqlConnection myCon = Con.getDatabaseConnection();
            string query = "insert into tbl_AddUser (user_name, password) values ('" +userName +"', '" +pwd+"')";
            SqlCommand cmd = new SqlCommand(query, myCon);
            try
            {
                myCon.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateRecord()
        {

        }
    }
}
