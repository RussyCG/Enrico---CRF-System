using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.Questions
{
    public class NumericQuestionDTO_old : QuestionDTO_old
    {
        #region Fields

        private string unit;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public NumericQuestionDTO_old()
            : base()
        {

        }

        /// <summary>
        /// Initialize Question DTO_old
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public NumericQuestionDTO_old(int NumberParam, string TextParam, string UnitParam)
            : base(NumberParam, TextParam)
        {
            InitialiseComponents(NumberParam, TextParam, UnitParam);
        }

        /// <summary>
        /// Initialize Question DTO_old
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public NumericQuestionDTO_old(int IDParam, int NumberParam, string TextParam, string UnitParam)
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
