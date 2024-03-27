namespace Pratice_App_for_Mum
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Dapper;

    public class Database : IRepository
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\Pratice App for Mum\\Pratice App for mum\\database.db";

        private Form1 form1 = new Form1();

        public IEnumerable<Mission> GetMissions()
        {
            return Enumerable.Empty<Mission>();
        }

        public IEnumerable<Town> GetTowns()
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM Towns";
                CommandDefinition command = new CommandDefinition(sql);

                return connection.Query<Town>(command);
            }
        }

        public IEnumerable<Worker> GetWorkers()
        {
            using (IDbConnection connect = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM Workers";
                CommandDefinition command = new CommandDefinition(sql);

                return connect.Query<Worker>(command);
            }
        }

        public bool CreateNewTown(string newTown)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                string sqlname = $"INSERT Into Towns (Name) VALUES('{newTown}')";
                CommandDefinition command = new CommandDefinition(sqlname);

                return connection.Execute(command) > 0;
            }
        }

        public bool DeleteTown(int townId)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                string sqlname = $"DELETE FROM Towns WHERE Id = '{townId}'";
                CommandDefinition command = new CommandDefinition(sqlname);

                return connection.Execute(command) > 0;
            }
        }
    }
}
