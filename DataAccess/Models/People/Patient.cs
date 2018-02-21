using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.People
{
    public class Patient : Base.Base
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
        public Patient()
            : base()
        {

        }

        /// <summary>
        /// Initialize the Patient  without an ID
        /// </summary>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public Patient(string CaseNumberParam)
            : base()
        {
            this.CaseNumber = CaseNumberParam;
        }

        /// <summary>
        /// Initialize the Patient 
        /// </summary>
        /// <param name="IDParam">ID number of the record</param>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public Patient(int IDParam, string CaseNumberParam)
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
