using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace RC.Data.Database
{
    /// <summary>
    /// Base class for simplified SQLite commands.	
    /// </summary>
    public abstract class SimpleCommand : IDisposable
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        protected SqliteCommand _command;
        protected Dictionary<String, Object> _set;

        // --------------------------------------------------
        // Constructor
        // --------------------------------------------------

        /// <summary>
        /// Initializes internal objects.
        /// </summary>      
        protected SimpleCommand(String command, SqliteConnection connection, SqliteTransaction transaction = null)
        {
            _command = new SqliteCommand(command, connection, transaction);
            _set = new Dictionary<String, Object>();
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
        /// Adds a parameter that's not handled by Set.
        /// </summary>
        public void AddParameter(String name, Object value)
        {
            _command.Parameters.AddWithValue(name, value);
        }


        /// <summary>
        /// Sets value for field.
        /// </summary>
        public void Set(String field, Object value)
        {
            _set[field] = value;
        }

        public abstract Int32 Execute();

        // --------------------------------------------------
        // IDisposable
        // --------------------------------------------------

        /// <summary>
        /// Disposes internal, wrapped objects.
        /// </summary>
        public void Dispose()
        {
            _command.Dispose();
        }
    }
}
