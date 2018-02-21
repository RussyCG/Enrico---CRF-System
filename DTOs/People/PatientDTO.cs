using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.People
{
    public class PatientDTO : Base.BaseDTO
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
        public PatientDTO()
            : base()
        {

        }

        /// <summary>
        /// Initialize the Patient DTO without an ID
        /// </summary>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public PatientDTO(string CaseNumberParam)
            : base()
        {
            this.CaseNumber = CaseNumberParam;
        }

        /// <summary>
        /// Initialize the Patient DTO
        /// </summary>
        /// <param name="IDParam">ID number of the record</param>
        /// <param name="CaseNumberParam">Case Number of the Patient</param>
        public PatientDTO(int IDParam, string CaseNumberParam)
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
