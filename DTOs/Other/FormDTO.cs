using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Other
{
    public class FormDTO : Base.BaseDTO
    {
        private string title;
        private int orderNumber;
        private List<Questions.QuestionDTO> list;

        public List<Questions.QuestionDTO> Questions
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
