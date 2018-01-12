using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Data.Database
{
    /// <summary>
	/// Wrapper around SqliteCommand, for easier, cleaner inserting.
	/// </summary>
    public class InsertCommand : SimpleCommand
    {
        // --------------------------------------------------
        // Constructor
        // --------------------------------------------------
       
            /// <summary>
        /// Creates new insert command.
        /// </summary>       
        public InsertCommand(String command, SqliteConnection connection, SqliteTransaction transaction = null)
            : base(command, connection, transaction)
        {
        }

        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        public Int64 LastId
        {
            get
            {
                _command.CommandText = "SELECT last_insert_rowid()";
                return (Int64)_command.ExecuteNonQuery();
            }
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
		/// Runs SqliteCommand.ExecuteNonQuery
		/// </summary>
		public override int Execute()
        {
            // Build values part
            StringBuilder sb1 = new StringBuilder(); // fields
            StringBuilder sb2 = new StringBuilder(); // values

            foreach (String parameter in _set.Keys)
            {
                sb1.AppendFormat("`{0}`, ", parameter);
                sb2.AppendFormat("@{0}, ", parameter);
            }

            // Add values part
            String values = "(" + (sb1.ToString().Trim(' ', ',')) + ") VALUES (" + (sb2.ToString().Trim(' ', ',')) + ")";
            _command.CommandText = string.Format(_command.CommandText, values);

            // Add parameters
            foreach (KeyValuePair<String, Object> parameter in _set)
            {
                _command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }

            // Run
            return _command.ExecuteNonQuery();
        }
    }
}
