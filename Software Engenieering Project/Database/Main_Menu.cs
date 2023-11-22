using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Software_Engenieering_Project
{
    public partial class Main_Menu : Form
    {
        //boolean makes a switch between the vendor and product view very easy
        bool vendorLoaded = false;
        public Main_Menu()
        {
            InitializeComponent();
        }

        //Loading Products/Vendors
        private void button_ViewProducts_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);
            MainMenuedvg.DataSource = dataset.Tables[0];
            vendorLoaded = false;
            label_Filter.Text = "Product Filters";
            label_Categories.Text = "Product Categories";
            unselectButtons();
        }

        private void button_ViewVendors_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class 
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS);
            MainMenuedvg.DataSource = dataset.Tables[0];
            vendorLoaded = true;
            label_Filter.Text = "Vendor Filters";
            label_Categories.Text = "Vendor Categories";
            unselectButtons();
        }

        //Filters
        //only one radio button can be selected at a time.
        private void radioButton_Popularity_CheckedChanged(object sender, EventArgs e)
        {
            MainMenuedvg.Columns.Clear();
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset = dbConn.getDataSet(Constants.SEARCHFUNCTION);
            MainMenuedvg.DataSource = dataset.Tables[0];
        }

        private void radioButton_BestRating_CheckedChanged(object sender, EventArgs e)
        {
            if (vendorLoaded == false)
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Rating DESC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Rating DESC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_AZ_CheckedChanged(object sender, EventArgs e)
        {
            if (vendorLoaded == false)
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name ASC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Name ASC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_ZA_CheckedChanged(object sender, EventArgs e)
        {
            if (vendorLoaded == false)
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name DESC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Name DESC");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        //Searchbar
        private void textBox_Searchbox_TextChanged(object sender, EventArgs e)
        {
            //Data grid is refreshed every time a new letter is typed.
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " Where Products_Table.Product_Name LIKE '%" + textBox_Searchbox.Text + "%';");
            MainMenuedvg.DataSource = dataset.Tables[0];
        }

        //function for frmVendors new Window with more information
        private void MainMenuedvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vendorLoaded)
            {
                if (e.RowIndex >= 0) //check if data is available
                {
                    DataGridViewRow dgr = MainMenuedvg.Rows[e.RowIndex];
                    // Get the data from the selected row
                    frmVendor frm = new frmVendor(); // create new instance of vendor form
                    //pass data to form
                    frm.companyname = dgr.Cells[0].Value.ToString();
                    frm.companywebsite = dgr.Cells[1].Value.ToString();
                    frm.companyreviewDate = dgr.Cells[3].Value.ToString();
                    //show vendor form
                    frm.ShowDialog();
                }
            }
        }

        private void unselectButtons()
        {
            //This function makes it possible to reselect the different filters after switching from the vendor to product an vice versa
            //Whitout unselecting the buttons another one has to be select first and then the wanted one again.
            radioButton_Popularity.Checked = false;
            radioButton_BestRating.Checked = false;
            radioButton_AZ.Checked = false;
            radioButton_ZA.Checked = false;
            radioButton_NewestFirst.Checked = false;
            radioButton_OldestFirst.Checked = false;
            radioButton_FullMatch.Checked = false;
            radioButton_PartialMatch.Checked = false;
        }
    }
}