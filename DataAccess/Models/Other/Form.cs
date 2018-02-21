using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Other
{
    public class Form : Base.Base
    {
        private string title;
        private int orderNumber;
        private List<Questions.Question> list;

        public List<Questions.Question> Questions
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
