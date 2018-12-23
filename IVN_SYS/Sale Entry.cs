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
    public partial class Sale_Entry : Form
    {
        public Sale_Entry()
        {
            InitializeComponent();
        }

        private void Sale_Entry_Load(object sender, EventArgs e)
        {
            ConnectionStringClass conString = new ConnectionStringClass();
            SqlConnection myCon = conString.getDatabaseConnection();

            string query = "select party_name from tbl_AddParty";
            SqlCommand myCmd = new SqlCommand(query, myCon);
            try
            {
                myCon.Open();
                SqlDataReader PartyName = myCmd.ExecuteReader();
              
                while (PartyName.Read())
                {
                    string str = PartyName.GetValue(0).ToString().Trim();
                    CbxPartyName.Items.Add(str);
                }
                myCon.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
