using System;

namespace Rc.Data
{
    /// <summary>
    /// Represents a question data object at runtime. 
    /// </summary>
    public class Question : DbObject, IEquatable<Question>, ICloneable
    {
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets or sets the question caption.
        /// </summary>
        public String Caption { get; set; }

        /// <summary>
        /// Gets or sets the question type.
        /// </summary>
        public QuestionType QuestionType { get; set; }

        /// <summary>
        /// Gets or sets the multimedia absolute/relative path.
        /// </summary>
        public String Multimedia { get; set; }

        /// <summary>
        /// Gets or sets the answer A.
        /// </summary>
        public String AnswerA { get; set; }

        /// <summary>
        /// Gets or sets the answer B.
        /// </summary>
        public String AnswerB { get; set; }

        /// <summary>
        /// Gets or sets the answer C.
        /// </summary>
        public String AnswerC { get; set; }

        /// <summary>
        /// Gets or sets the answer D.
        /// </summary>
        public String AnswerD { get; set; }

        /// <summary>
        /// Gets or sets the correct answer.
        /// </summary>
        public CorrectAnswer CorrectAnswer { get; set; }

        /// <summary>
        /// Gets or sets the teaching of the question.
        /// </summary>
        public String Teaching { get; set; }
        
        // --------------------------------------------------
        // IEquatable <Question>
        // --------------------------------------------------

        public Boolean Equals(Question other)
        {
            return

                this.Caption == other.Caption &&
                this.QuestionType == other.QuestionType &&
                this.Multimedia == other.Multimedia &&
                this.AnswerA == other.AnswerA &&
                this.AnswerB == other.AnswerB &&
                this.AnswerC == other.AnswerC &&
                this.AnswerD == other.AnswerD &&
                this.CorrectAnswer == other.CorrectAnswer &&
                this.Teaching == other.Teaching;
        }

        // --------------------------------------------------
        // ICloneable
        // --------------------------------------------------

        public Object Clone()
        {
            return (Question)MemberwiseClone();
        }
    }

    /// <summary>
    /// Represents question's types. 
    /// </summary>
    public enum QuestionType
    {
        Normal = 0,
        Image = 1,
        Video = 2,
    }

    /// <summary>
    /// Enumaration of the four possible answers.
    /// </summary>
    public enum CorrectAnswer
    {        
        A = 0,
        B = 1,
        C = 2,
        D = 3
    }
}
