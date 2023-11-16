using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engenieering_Project
{
    internal class Constants
    {
        public static string SHOWPREVIEWPRODUCTS = "SELECT Products_Table.Product_Name as 'Product Name'," +
                                                   "Products_Table.Product_Type as 'Product Type', " +
                                                   "Products_Table.Product_Description as 'Product Description', " +
                                                   "Companies_Table.Company_Name as 'Company Name' " +
                                                   "FROM Companies_Table " +
                                                   "INNER JOIN Products_Table " +
                                                   "ON Companies_Table.Company_ID = Products_Table.Company_ID ";

        public static string SHOWPREVIEWVENDORS = "SELECT Company_Name as 'Company Name', " +
                                                  "Company_Website as 'Website', " +
                                                  "Company_Last_Review_Date as 'Last Review' " +
                                                  "FROM Companies_Table ";

        public static string awdwad = "adawd";


        //SELECT* FROM Student WHERE NAME = 'Ram' OR NAME = 'SUJIT';


        public static string SEARCH = SHOWPREVIEWPRODUCTS + "WHERE";

        public static string Test = "SELECT Products_Table.Product_Name as 'Product Name', " +
                                    "Products_Table.Product_Type as 'Product Type', " +
                                    "Products_Table.Product_Description as 'Product Description', " +
                                    "Companies_Table.Company_Name as 'Company Name' " +
                                    "FROM Companies_Table " +
                                    "INNER JOIN Products_Table " +
                                    "ON Companies_Table.Company_ID = Products_Table.Company_ID ";

        public static string TEST = "SELECT Products_Table.Product_ID, Companies_Table.Company_I, Products_Capabilities_Table.Product_Capability_ID, Modules_Table.Module_ID, Business_Areas_Table.Business_Area_ID, Financial_Services_Client_Types_Table.Financial_Service_Client_Typ_ID " +
                                    "FROM Companies_Table " +
                                    "INNER JOIN Products_Table " +
                                        "ON Companies_Table.Company_ID = Products_Table.Company_ID " +
                                    "INNER JOIN Products_Capabilities_Table " +
                                        "ON Products_Table.Product_ID = Products_Capabilities_Table.Product_Capability_ID " +
                                    "INNER JOIN Modules_Table " +
                                        "ON Products_Capabilities_Table.Product_Capability_ID = Modules_Table.Module_ID " +
                                    "INNER JOIN Business_Areas_Table " +
                                        "ON Products_Capabilities_Table.Product_Capability_ID = Business_Areas_Table.Business_Area_ID" +
                                    "INNER JOIN Financial_Services_Client_Types_Table" +
                                        "ON Products_Capabilities_Table.Product_Capability_ID = Financial_Services_Client_Types_Table.Financial_Service_Client_Typ_ID";
    }
}
//1277, 688