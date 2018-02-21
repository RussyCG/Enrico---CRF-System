using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Questions
{
    /// <summary>
    /// Represents a Question that will be presented to the user to be answered
    /// </summary>
    public abstract class Question : Base.Base
    {
        #region Fields

        private int number;
        private string text;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public Question():
            base()
        {

        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public Question(int NumberParam, string TextParam)
            : base()
        {
            this.Number = NumberParam;
            this.Text = TextParam;
        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public Question(int IDParam, int NumberParam, string TextParam)
            : base(IDParam)
        {
            this.Number = NumberParam;
            this.Text = TextParam;
        }

        #endregion

        #region Properties

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        #endregion
    }
}
