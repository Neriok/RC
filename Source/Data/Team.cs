using System;

namespace RC.Data
{
    /// <summary>
    /// Represents a team data object at runtime. 
    /// </summary>
    public class Team : DbObject, IEquatable<Team>
    {
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets or sets the team's name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the team's image relative/absolute path.
        /// </summary>
        public String Image { get; set; }

        // --------------------------------------------------
        // IEquatable <Team>
        // --------------------------------------------------

        public Boolean Equals(Team other)
        {
            return
                this.Name == other.Name &&
                this.Image == other.Image;
        }
    }
}
