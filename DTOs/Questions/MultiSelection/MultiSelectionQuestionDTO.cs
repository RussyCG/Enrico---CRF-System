using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Questions
{
    /// <summary>
    /// A question that has a multiple options that the user must select from
    /// </summary>
    public abstract class MultiSelectionQuestionDTO : QuestionDTO
    {
        #region Fields

        private List<string> options;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public MultiSelectionQuestionDTO()
            : base()
        {

        }

        /// <summary>
        /// Initialize Multi Selection Question
        /// </summary>
        /// <param name="NumberParam">Order number</param>
        /// <param name="TextParam">Text to answer</param>
        /// <param name="OptionsParam">Options to select from</param>
        public MultiSelectionQuestionDTO(int NumberParam, string TextParam, List<string> OptionsParam)
            : base(NumberParam, TextParam)
        {
            this.Options = OptionsParam;
        }

        /// <summary>
        /// Initialize Multi Selection Question
        /// </summary>
        /// <param name="IDParam">ID of the multi selection question</param>
        /// <param name="NumberParam">Order number</param>
        /// <param name="TextParam">Text to answer</param>
        /// <param name="OptionsParam">Options to select from</param>
        public MultiSelectionQuestionDTO(int IDParam, int NumberParam, string TextParam, List<string> OptionsParam)
            : base(IDParam, NumberParam, TextParam)
        {
            this.Options = OptionsParam;
        }

        #endregion

        #region Properties

        public List<string> Options
        {
            get { return options; }
            set { options = value; }
        }

        #endregion
    }
}
