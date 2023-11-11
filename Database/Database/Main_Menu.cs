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
            //returns the object of the DBConnection class 
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
