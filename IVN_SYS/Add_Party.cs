using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IVN_SYS.Models;

namespace IVN_SYS
{
    public partial class Add_Party : Form
    {
        public Add_Party()
        {
            InitializeComponent();
        }

        private void SaveParty(object sender, EventArgs e)
        {
            ConnectionStringClass mycon = new ConnectionStringClass();
            SqlConnection sqlCon = mycon.getDatabaseConnection();
            string query = "insert into tbl_AddParty (party_id,party_name,address, phone_no, email) values (1,'Hassan', 'abc block', '32547895879', 'test@gmail.com')";
            SqlCommand mycommand = new SqlCommand(query, sqlCon);
            try
            {
                sqlCon.Open();

                sqlCon.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
