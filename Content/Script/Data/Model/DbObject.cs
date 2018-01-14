using System;

namespace Rc.Data.Model
{
    /// <summary>
    /// Base class for database entities.
    /// </summary>
    public class DbObject
    {
        public const string NONE = "none";

                /// <summary>
        /// Gets or sets the database id.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
