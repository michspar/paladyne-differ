using Paladyne_differ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQLAdapter
{
    public class MSSqlDataAdapter : Paladyne_differ.IDataAdapter, IDisposable
    {
        MSSQLConnectionSettings form;

        public MSSqlDataAdapter()
        {
            form = new MSSQLConnectionSettings(this);
        }

        public Control GetSettingsControl()
        {
            return form;
        }

        public override string ToString()
        {
            return "Microsoft SQL Server";
        }

        string serverNameCached;
        string[] databasesCached = new string[0];
        SqlConnection connection;

        public string[] FetchDatabases(string server, string usr = null, string pwd = null)
        {
            if (serverNameCached == server)
                return databasesCached;

            serverNameCached = server;

            form.Cursor = Cursors.WaitCursor;

            if (connection != null)
                connection.Dispose();

            connection = new SqlConnection(string.Format("Data Source={0};{1}", server, usr == null || pwd == null ? "Integrated Security=True" : "User ID=" + usr));

            try
            {
                if (usr != null && pwd != null)
                {
                    SecureString spwd = new SecureString();

                    Array.ForEach(pwd.ToCharArray(), ch => spwd.AppendChar(ch));

                    connection.Credential = new SqlCredential(usr, spwd);
                }

                connection.Open();

                databasesCached = connection.GetSchema("Databases").Rows.OfType<DataRow>().Select(row => row.Field<string>(0)).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            form.Cursor = Cursors.Default;

            return databasesCached;
        }

        public string[] FetchTables(string database)
        {
            connection.ChangeDatabase(database);

            return connection.GetSchema("Tables").Rows.OfType<DataRow>().Select(row => row.Field<string>(2)).ToArray();
        }

        public void ApplySettings(string table)
        {
            if (string.IsNullOrWhiteSpace(table))
                return;

            var datatable = new DataTable();

            new SqlDataAdapter("select * from " + table, connection).Fill(datatable);

            SettingsApplied(this, new DataTableEventArgs(datatable));
        }

        public event EventHandler<DataTableEventArgs> SettingsApplied;

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
