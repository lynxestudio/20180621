using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Samples.OracleConnections
{
    public partial class FrmMain : Form
    {
        OracleConnectionStringBuilder builder = null;
        List<ConnectionManager> connectionsManager = null;
        
        int id = 0;

        public FrmMain()
        {
            InitializeComponent();
            connectionsManager = new List<ConnectionManager>();
        }

        private void BtnConnectionAllClick(object sender, EventArgs e)
        {
            try
            {
                if (connectionsManager.Count > 0)
                {
                    foreach (var item in connectionsManager)
                    {
                        item.CloseConnection();
                        item.StartDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");
                    }
                    PrintOutput(connectionsManager);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConnectClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UserId.Text))
                    MessageBox.Show("Empty user");
                else
                    if (string.IsNullOrEmpty(Password.Text))
                        MessageBox.Show("Empty DataSource");
                    else
                        if (string.IsNullOrEmpty(DataSource.Text))
                            MessageBox.Show("Empty DataSource");
                        else
                        {
                            builder = new OracleConnectionStringBuilder();
                            builder.Add("User Id", UserId.Text);
                            builder.Add("Password", Password.Text);
                            builder.Add("Data Source", DataSource.Text);
                            builder.Add("Connection Timeout", (int)TimeOut.Value);
                            ConnectionManager connection = new ConnectionManager(builder);
                            id++;
                            connection.Id = id;
                            connection.StartDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");
                            if (connection.GetConnection().State  == ConnectionState.Open)
                            {
                                connectionsManager.Add(connection);
                                PrintOutput(connectionsManager);
                            }
                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        void PrintOutput(List<ConnectionManager> connectionsManager)
        {
            Output.Clear();
            StringBuilder buf = new StringBuilder();
            foreach (var item in connectionsManager)
            {
                string label = "Connected";
                if (item.State == "Closed")
                    label = "Disconnected";
                buf.AppendLine(item.Id + "| User ["+ item.UserID +"] creates a Datasource [ " + item.DataSource + " ] - " + label +" at " + item.StartDate + " - State [" + item.State + "] ");
            }
            Output.Text = buf.ToString();
            Logger.LogMessage(buf);
        }

        private void BtnShowClick(object sender, EventArgs e)
        {
            Output.Text = Logger.OpenLog();
        }
    }
}
