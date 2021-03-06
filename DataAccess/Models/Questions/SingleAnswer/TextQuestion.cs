﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Questions
{
    public class TextQuestion : Question
    {
        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public TextQuestion()
            : base()
        {

        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        public TextQuestion(int NumberParam, string TextParam)
            : base(NumberParam, TextParam)
        {

        }

        /// <summary>
        /// Initialize Question 
        /// </summary>
        /// <param name="NumberParam">Question Number Eg. 1.</param>
        /// <param name="TextParam">Text of the question to ask the user</param>
        /// <param name="IDParam">ID of the Question</param>
        public TextQuestion(int IDParam, int NumberParam, string TextParam)
            : base(IDParam, NumberParam, TextParam)
        {

        }
    }
}
