using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Constants
    {
        public static string SHOWPREVIEWPRODUCTS = "SELECT Product_Name, Product_Type, Product_Description FROM Products_Table";
        public static string SHOWPREVIEWVENDORS = "SELECT Company_Name, Company_Website, Company_Last_Review_Date FROM Companies_Table";
        public static string Test = "SELECT Products_Table.Product_Name, Companies_Table.Company_Name FROM Companies_Table INNER JOIN Products_Table ON Companies_Table.Company_ID = Products_Table.Company_ID";
        public static string Test1 = "SELECT Products_Table.Product_Name, Companies_Table.Company_Name FROM Companies_Table, Products_Table";
    }
}
