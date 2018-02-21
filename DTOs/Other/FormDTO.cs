using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.Other
{
    public class FormDTO_old : Base.BaseDTO_old
    {
        private string title;
        private int orderNumber;
        private List<Questions.QuestionDTO_old> list;

        public List<Questions.QuestionDTO_old> Questions
        {
            get { return list; }
            set { list = value; }
        }

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

    }
}
