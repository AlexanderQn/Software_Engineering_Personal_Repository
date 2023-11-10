using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class DB1Connection
    {
        //attributes
        //private object of the class itelf
        private static DB1Connection _instance;

        //the connection string
        private string dbConnectionString;


        //constructor
        private DB1Connection()
        {
            //initialise the DB1ConnectionSting
            dbConnectionString = Properties.Settings.Default.DB1ConnectionString;
        }

        //methods
        /*
         * static method that gives access to the private object
         */
        public static DB1Connection getInstanceofDB1Connection()
        {
            if (_instance == null)
                _instance = new DB1Connection();
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();


            using (SqlConnection connToDB = new SqlConnection(dbConnectionString))
            {
                //open connection
                connToDB.Open();

                //send SQL query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }
    }
}
