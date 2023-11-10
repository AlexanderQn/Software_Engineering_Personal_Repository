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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //returns the object of the DB1Connection class 
            DB1Connection dbConn = DB1Connection.getInstanceofDB1Connection();
            DataSet datasetProducts = dbConn.getDataSet("Select * FROM Products");
            Database1.DataSource = datasetProducts.Tables[0]; 
        }
    }
}
