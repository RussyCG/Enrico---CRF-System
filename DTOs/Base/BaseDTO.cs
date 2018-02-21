using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.Base
{
    /// <summary>
    /// Generic Base class for getting the ID
    /// </summary>
    public class BaseDTO_old
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
        public BaseDTO_old()
        {

        }

        /// <summary>
        /// Constructor to initialize the BaseDTO_old
        /// </summary>
        /// <param name="IDParam">ID of the record</param>
        public BaseDTO_old(int IDParam)
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
