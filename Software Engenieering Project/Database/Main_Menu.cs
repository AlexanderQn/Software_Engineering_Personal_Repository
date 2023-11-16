using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engenieering_Project
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
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            MainMenuedvg.Columns.Clear();
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name ASC");
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name DESC");
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string UserInput = textBox1.Text;
            //MainMenuedvg.Columns.Clear();
            //DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            //DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + "Where" + UserInput);
        }
    }
}
