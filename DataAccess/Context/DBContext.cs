using Models.Other;
using Models.Questions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_old.Context
{
    class DBContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
        public DbSet<CheckboxSelectionQuestion> CheckboxSelectionQuestions { get; set; }
        public DbSet<RadioSelectionQuestion> RadioSelectionQuestions { get; set; }
        public DbSet<ComboBoxSelectionQuestion> ComboBoxSelectionQuestions { get; set; }
        public DbSet<TextQuestion> TextQuestions { get; set; }
        public DbSet<NumericQuestion> NumericQuestions { get; set; }
        public DbSet<DateTimeQuestion> DateTimeQuestions { get; set; }
        
    }
}
