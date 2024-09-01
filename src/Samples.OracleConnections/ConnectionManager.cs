using Oracle.DataAccess.Client;
using System.Data;
using System;
using System.Text;
namespace Samples.OracleConnections
{
    public  sealed class ConnectionManager 
    {
        OracleConnection connection = null;
        public OracleConnectionStringBuilder Builder { private set; get; }
        public string DataSource { private set; get; }
        public int Id { set;  get; }
        public string StartDate { set; get; }
        public string UserID { get; private set; }
        public string State 
        {
            get 
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        return "Open";
                }
                return "Closed";
            }
        }

        public ConnectionManager(OracleConnectionStringBuilder builder)
        {
            this.Builder = builder;
            this.DataSource = builder.DataSource;
            this.UserID = builder.UserID;
        }

        public OracleConnection GetConnection() 
        {
            string connectionString = this.Builder.ConnectionString;
            connection = new OracleConnection(connectionString);
            connection.StateChange += Logger.ConnectionStateChange;
            connection.InfoMessage += Logger.ConnectionInfoMessage;
            connection.Open();
            return connection;
        }

        public void CloseConnection() 
        {
            if (connection != null) {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection = null;
                }
            }
        }
    }
}