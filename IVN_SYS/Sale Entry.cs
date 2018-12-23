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
        string id;
        List<string> productnameArray = new List<string>();

        public Sale_Entry()
        {
            InitializeComponent();
        }
        private int GetID()
        {
            int party = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlCon = myConnection.getDatabaseConnection();

            string q = "select s_no from tbl_Sale order by s_no desc;";
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
        private void Sale_Entry_Load(object sender, EventArgs e)
        {
            id = Convert.ToString(this.GetID());
            TbxSno.Text = id;
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

            string queryForProductName = "select product_name from tbl_AddProduct";
            SqlCommand myCmd1 = new SqlCommand(queryForProductName, myCon);
            try
            {
                myCon.Open();
               SqlDataReader productName = myCmd1.ExecuteReader();


                while (productName.Read())
                {
                    string str2 = productName.GetValue(0).ToString().Trim();
                    productnameArray.Add(str2);

                }
                myCon.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("String array not working");
            }

        }

        private void GdvSaleEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("GdvSaleEntry_CellClick");

        }

        private void GdvSaleEntry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("GdvSaleEntry_CellMouseClick");
        }
    }
}
