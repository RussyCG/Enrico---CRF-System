using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Questions
{
    public class NumericQuestion : Question
    {
        #region Fields

        private string unit;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public NumericQuestion()
            : base()
        {

        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public NumericQuestion(int NumberParam, string TextParam, string UnitParam)
            : base(NumberParam, TextParam)
        {
            InitialiseComponents(NumberParam, TextParam, UnitParam);
        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public NumericQuestion(int IDParam, int NumberParam, string TextParam, string UnitParam)
            : base(IDParam, NumberParam, TextParam)
        {

        }

        #endregion

        #region Properties

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion

        #region Methods

        private void InitialiseComponents(int NumberParam, string TextParam, string UnitParam)
        {
            this.Number = NumberParam;
            this.Text = TextParam;
            this.Unit = UnitParam;
        }

        #endregion
    }
}
