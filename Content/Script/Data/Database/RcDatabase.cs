using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Data.Database
{
    /// <summary>
    /// Represents RC database with SQLite.
    /// </summary>
    public class RcDatabase
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private String _connectionString;

        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets the connection string path. 
        /// </summary>
        public String ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
        /// Sets connection string and calls TestConnection.
        /// </summary>
        public void Init(String connectionString)
        {
            _connectionString = connectionString;
            TestConnection();
        }

        /// <summary>
		/// Returns a valid connection.
		/// </summary>
        public SqliteConnection GetConnection()
        {
            if(_connectionString == null)
            {
                throw new Exception("Database has not been initialized.");
            }

            SqliteConnection connection = new SqliteConnection("URI=file:" + _connectionString);
            connection.Open();

            // Active foreing keys.
            using (SqliteCommand command = new SqliteCommand("PRAGMA foreign_keys = 1", connection))
            {
                command.ExecuteNonQuery();
            }
            
            return connection;
        }

        /// <summary>
		/// Tests connection.
		/// </summary>
		/// <exception cref="Exception">Thrown if connection couldn't be established.</exception>
        public void TestConnection()
        {
            SqliteConnection connection = null;

            try
            {
                connection = this.GetConnection();
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }

        }

        // --------------------------------------------------
        // Tournament
        // --------------------------------------------------

        public void AddTournament(Tournament tournament)
        {
            using (SqliteConnection connection = GetConnection())
            {
                using (InsertCommand command = new InsertCommand("INSERT INTO '", connection))
                {

                }
            }
        }
    }
}
