using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC.Data.Database
{
    /// <summary>
	/// Wrapper around SqliteCommand, for easier, cleaner updating.
	/// </summary>
    public class UpdateCommand : SimpleCommand
    {
        // --------------------------------------------------
        // Constructor
        // --------------------------------------------------

        /// <summary>
		/// Creates new update command.
		/// </summary>		
		public UpdateCommand(string command, SqliteConnection connection, SqliteTransaction transaction = null)
            : base(command, connection, transaction)
        {
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
		/// Runs SqliteCommand.ExecuteNonQuery
		/// </summary>
		public override int Execute()
        {
            // Build setting part
            StringBuilder sb = new StringBuilder();
            foreach (String parameter in _set.Keys)
            {
                sb.AppendFormat("`{0}` = @{0}, ", parameter);
            }               

            // Add setting part
            _command.CommandText = string.Format(_command.CommandText, sb.ToString().Trim(' ', ','));

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
