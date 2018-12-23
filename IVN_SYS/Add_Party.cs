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
        string id;
        public Add_Party()
        {
            InitializeComponent();
        }
        private void Add_Party_Load(object sender, EventArgs e)
        {
            id = Convert.ToString(this.GetID());
        }
        private int GetID()
        {
            int party = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlCon = myConnection.getDatabaseConnection();

            string q = "select party_id from tbl_AddParty order by party_id desc;";
            SqlCommand getId = new SqlCommand(q, sqlCon);
            try
            {
                sqlCon.Open();
                int id = Convert.ToInt32(getId.ExecuteScalar()) + 1;
                party = id;
                sqlCon.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return party;
        }

        private void SaveParty(object sender, EventArgs e)
        {
            if ((TbxPartyName.Text != "" || TbxAddress.Text != "" || TbxEmail.Text != "" || TbxPhoneNo.Text != "") && (TbxPartyName.Text != null || TbxAddress.Text != null || TbxEmail.Text != null || TbxPhoneNo.Text != null))
            {
                ConnectionStringClass mycon = new ConnectionStringClass();
                SqlConnection sqlCon = mycon.getDatabaseConnection();
                string query = "insert into tbl_AddParty (party_id,party_name,address, phone_no, email) values ('" + id + "','" + TbxPartyName.Text + "', '" + TbxAddress.Text + "', '" + TbxPhoneNo.Text + "', '" + TbxEmail.Text + "')";
                SqlCommand mycommand = new SqlCommand(query, sqlCon);
                try
                {
                    sqlCon.Open();
                    mycommand.ExecuteNonQuery();
                    sqlCon.Close();

                    TbxPartyName.Text = "";
                    TbxEmail.Text = "";
                    TbxAddress.Text = "";
                    TbxPhoneNo.Text = "";
                    id = Convert.ToString(this.GetID());
                    MessageBox.Show("Party Saved");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Insert value in textboxes");
            }
            
        }
    }
}
