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

        //Loading the database
        private void button_ViewProducts_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void button_ViewVendors_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        //Filters
        //only one radio button can be selected at a time.
        private void radioButton_Popularity_CheckedChanged(object sender, EventArgs e)
        {
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SEARCHFUNCTION);
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void radioButton_AZ_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name ASC");
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        private void radioButton_ZA_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name DESC");
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

        //Searchbar
        private void button_SearchSubmission_Click(object sender, EventArgs e)
        {
            Textbox_Search();
        }

        private void textBox_Searchbox_TextChanged(object sender, EventArgs e)
        {
            Textbox_Search();
        }

        public void Textbox_Search()
        {
            //Data grid is refreshed every time a new letter is typed.
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet datasetProducts = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " Where Products_Table.Product_Name LIKE '%" + textBox_Searchbox.Text + "%';");
            MainMenuedvg.DataSource = datasetProducts.Tables[0];
        }

    }
}