using System;
using System.Collections.Generic;
using System.Drawing;

namespace Rc.Data.Model
{
    /// <summary>
    /// Represents a category data object at runtime. 
    /// </summary>
    public class Category : Object, IEquatable<Category>
    {
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets or sets the category's name.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the category's image relative/absolute path.
        /// </summary>
        public String Image { get; set; }

        /// <summary>
        /// Gets or sets the category's color. 
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the category's questions. 
        /// </summary>
        public List<Question> Questions { get; set; }

        // --------------------------------------------------
        // IEquatable <Category>
        // --------------------------------------------------

        public Boolean Equals(Category other)
        {
            return
                this.Name == other.Name &&
                this.Image == other.Image &&
                this.Color == other.Color &&
                this.Questions == other.Questions;
        }

    }
}
