using System;

namespace Rc.Data.Model
{
    /// <summary>
    /// Represents a team data object at runtime. 
    /// </summary>
    public class Team : Object, IEquatable<Team>
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
