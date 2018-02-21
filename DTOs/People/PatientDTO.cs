using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.People
{
    public class PatientDTO_old : Base.BaseDTO_old
    {
        #region Fields

        /// <summary>
        /// Case number to link to the patient
        /// </summary>
        private string caseNumber;

        #endregion

        #region Constructor

        /// <summary>
        /// Empty constructor
        /// </summary>
        public PatientDTO_old()
            : base()
        {

        }

        /// <summary>
        /// Initialize the Patient DTO_old without an ID
        /// </summary>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public PatientDTO_old(string CaseNumberParam)
            : base()
        {
            this.CaseNumber = CaseNumberParam;
        }

        /// <summary>
        /// Initialize the Patient DTO_old
        /// </summary>
        /// <param name="IDParam">ID number of the record</param>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public PatientDTO_old(int IDParam, string CaseNumberParam)
            : base(IDParam)
        {
            this.CaseNumber = CaseNumberParam;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Case number to link to the patient
        /// </summary>
        public string CaseNumber
        {
            get { return caseNumber; }
            set { caseNumber = value; }
        }

        #endregion
    }
}
