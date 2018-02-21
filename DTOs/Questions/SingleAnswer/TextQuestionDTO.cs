﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.Questions
{
    public class TextQuestionDTO_old : QuestionDTO_old
    {
        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public TextQuestionDTO_old()
            : base()
        {

        }

        /// <summary>
        /// Initialize Question DTO_old
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public TextQuestionDTO_old(int NumberParam, string TextParam)
            : base(NumberParam, TextParam)
        {

        }

        /// <summary>
        /// Initialize Question DTO_old
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public TextQuestionDTO_old(int IDParam, int NumberParam, string TextParam)
            : base(IDParam, NumberParam, TextParam)
        {

        }
    }
}
