using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVN_SYS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            Add_Product add_prod = new Add_Product();
            add_prod.ShowDialog();
        }

        private void AddParty(object sender, EventArgs e)
        {
            Add_Party add_party = new Add_Party();
            add_party.ShowDialog();
        }
    }
}
