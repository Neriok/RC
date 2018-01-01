﻿using System;
using System.Collections.Generic;

namespace RC.Data
{
    /// <summary>
    /// Represents a tournament data object at runtime. 
    /// </summary>
    public class Tournament : DbObject, IEquatable<Tournament>
    {
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets or sets the tournament's name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the tournament's image relative/absolute path.
        /// </summary>
        public String Image { get; set; }

        /// <summary>
        /// Gets or sets the tournament's rounds. 
        /// </summary>
        public Int32 Rounds { get; set; }

        /// <summary>
        /// Gets or sets the tournament's teams.
        /// </summary>
        public List<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the torunament's categories.
        /// </summary>
        public List<Category> Categories { get; set; }

        // --------------------------------------------------
        // IEquatable <Tournament>
        // --------------------------------------------------

        public Boolean Equals(Tournament other)
        {
            return
                this.Name == other.Name &&
                this.Image == other.Image &&
                this.Rounds == other.Rounds &&
                this.Teams == other.Teams &&
                this.Categories == other.Categories;
        }


    }
}
