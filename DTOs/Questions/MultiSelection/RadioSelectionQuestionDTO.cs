using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Questions
{
    public class RadioSelectionQuestionDTO : MultiSelectionQuestionDTO
    {
        #region Constructors

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public RadioSelectionQuestionDTO()
            : base()
        {

        }

        /// <summary>
        /// Initialize Multi Selection Question
        /// </summary>
        /// <param name="NumberParam">Order number</param>
        /// <param name="TextParam">Text to answer</param>
        /// <param name="OptionsParam">Options to select from</param>
        public RadioSelectionQuestionDTO(int NumberParam, string TextParam, List<string> OptionsParam)
            : base(NumberParam, TextParam, OptionsParam)
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
        public RadioSelectionQuestionDTO(int IDParam, int NumberParam, string TextParam, List<string> OptionsParam)
            : base(IDParam, NumberParam, TextParam, OptionsParam)
        {
            this.Options = OptionsParam;
        }

        #endregion
    }
}
