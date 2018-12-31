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
    public partial class Add_Product : Form
    {
        string id;
        public Add_Product()
        {
            InitializeComponent();
        }
        private void Add_Product_Load(object sender, EventArgs e)
        {
            id = Convert.ToString(this.GetID());
            ConnectionStringClass myCon = new ConnectionStringClass();
            SqlConnection sqlC = myCon.getDatabaseConnection();
            String selectQuery = "select * from tbl_AddProduct order by product_id asc";
            SqlCommand mycmd = new SqlCommand(selectQuery, sqlC);
            try
            {
                sqlC.Open();
                SqlDataReader DR = mycmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        GdvProducts.Rows.Add(DR[0].ToString(), DR[1].ToString());
                    }
                }
                sqlC.Close();                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SaveProduct(object sender, EventArgs e)
        {
            String product_name = Tbx_ProductName.Text;
            if (product_name != "" && product_name != null)
            {
                ConnectionStringClass myConnection = new ConnectionStringClass();
                SqlConnection sqlC = myConnection.getDatabaseConnection();
                string insertQuery = "insert into tbl_AddProduct (product_id, product_name) Values ( '"+id+"', '" + product_name + "')";
                SqlCommand mycommand = new SqlCommand(insertQuery, sqlC);
                try
                {
                    sqlC.Open();
                    var a = mycommand.ExecuteNonQuery();
                    sqlC.Close();

                    Tbx_ProductName.Text = "";
                    id = Convert.ToString(this.GetID());
                    MessageBox.Show("Product Saved");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Product Name");
            }
        }
        private int GetID()
        {
            int product = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlCon = myConnection.getDatabaseConnection();

            string q = "select product_id from tbl_AddProduct order by product_id desc";
            SqlCommand getId = new SqlCommand(q, sqlCon);
            try
            {
                sqlCon.Open();
                int id = Convert.ToInt32(getId.ExecuteScalar()) + 1;
                product = id;
                sqlCon.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return product;
        }
    }
}
