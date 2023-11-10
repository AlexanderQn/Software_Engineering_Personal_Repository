using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //returns the object of the DB1Connection class 
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet("Select * FROM Products_Table");
            dgv.DataSource = datasetProducts.Tables[0];
        }
    }
}
