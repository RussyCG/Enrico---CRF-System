using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Base
{
    /// <summary>
    /// Generic Base class for getting the ID
    /// </summary>
    public class BaseDTO
    {
        #region Fields

        /// <summary>
        /// unique ID that identifies the tuple
        /// </summary>
        private int id;

        #endregion

        #region Constructors

        /// <summary>
        /// Base empty constructor
        /// </summary>
        public BaseDTO()
        {

        }

        /// <summary>
        /// Constructor to initialize the BaseDTO
        /// </summary>
        /// <param name="IDParam">ID of the record</param>
        public BaseDTO(int IDParam)
        {
            this.ID = IDParam;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Unique ID for the record
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

    }
}
