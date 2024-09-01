

namespace Samples.OracleConnections
{
    using System;
    using System.Text;
    using System.Data;
    using System.IO;
    using Oracle.DataAccess.Client;
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class Logger
    {
        public static void ConnectionStateChange(Object sender, StateChangeEventArgs args)
        {
            StringBuilder buf = new StringBuilder();
            buf.Append("Connection StateChange event:");
            buf.Append("   OriginalState: " + args.OriginalState);
            buf.Append("   CurrentState:  " + args.CurrentState);
            buf.Append(Environment.NewLine);
            LogMessage(buf);
        }

        public static void ConnectionInfoMessage(Object sender, OracleInfoMessageEventArgs args)
        {
            LogSqlErrors("Connection InfoMessage event, SQL errors: ", args.Errors);
        }

        static void LogSqlErrors(string message,OracleErrorCollection errors)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(message);

            foreach (OracleError error in errors)
            {
                builder.Append(Environment.NewLine);
                builder.Append("   Procedure: ");
                builder.Append(error.Procedure);

                builder.Append(Environment.NewLine);
                builder.Append("   Line number: ");
                builder.Append(error.Number);

                builder.Append(Environment.NewLine);
                builder.Append("   Message: ");
                builder.Append(error.Message);

                builder.Append(Environment.NewLine);
                builder.Append("   Server: ");
                builder.Append(error.DataSource);

                builder.Append(Environment.NewLine);
                builder.Append("   Source: ");
                builder.Append(error.Source);
            }

            LogMessage(builder);

        }

        public static void LogMessage(StringBuilder s)
        {
            using (FileStream stream = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(stream);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.Write(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " +s.ToString());
                sw.Flush();
                sw.Close();
            }
        }

        public static string OpenLog()
        {
            using (FileStream stream = new FileStream("log.txt",FileMode.Open,FileAccess.Read))
            {
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
        }

    }
}
