using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EasyMed
{
    class DataSourceConn
    {

        private string driver;
        private string server;
        private string logDB;
        private string logPw;

        public DataSourceConn()
        {
            this.driver = getDriver();
            this.server = getServer();
            this.logDB = "";
            this.logPw = "";
        }

    protected SqlConnection getConnection()
        {
            string varConnector = this.server + this.driver;
            SqlConnection Connector = new SqlConnection(varConnector);

            return Connector;


         }


        private string getDriver()
        {
            string Driver = "Initial Catalog = SMM; Integrated Security = True";
            return Driver;
        }

        private string getServer()
        {
            string server = "Data Source=QUEPACHO; ";
            return server;
        }

        private string getlogDB()
        {
            string DB = "";
            return DB;
        }

        private string getlogPw()
        {
            string Pw = "";
            return Pw;
        }

    }


   sealed  class DataConnector:DataSourceConn
    {
        private string typeCon;

        public DataConnector()
        {

        }

        
        public SqlConnection initializeDataComponent()
        {
            SqlConnection state = null;
            try
            {
                state =  this.getConnection();
            }
            catch (Exception e)
            {

                state = null;
            }

           return state;
        }

    }

   
}
