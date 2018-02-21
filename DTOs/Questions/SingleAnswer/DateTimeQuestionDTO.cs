using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Questions
{
    public class DateTimeQuestionDTO : QuestionDTO
    {
        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public DateTimeQuestionDTO()
            : base()
        {

        }

        /// <summary>
        /// Initialize Question DTO
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public DateTimeQuestionDTO(int NumberParam, string TextParam)
            : base(NumberParam, TextParam)
        {

        }

        /// <summary>
        /// Initialize Question DTO
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public DateTimeQuestionDTO(int IDParam, int NumberParam, string TextParam)
            : base(IDParam, NumberParam, TextParam)
        {

        }
    }
}
