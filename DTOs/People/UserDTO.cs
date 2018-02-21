using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.People
{
    public abstract class UserDTO_old : Base.BaseDTO_old
    {
        #region Fields

        private string username;
        private string password;
        private DateTime lastActive;
        private bool isLocked;
        private string emailAddress;

        #endregion

        #region Constructors

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public UserDTO_old()
            : base()
        {

        }
        
        /// <summary>
        /// Initialise a user DTO_old without an ID
        /// </summary>
        /// <param name="UsernameParam">Unique Username for user</param>
        /// <param name="PasswordParam">Unique Password for user</param>
        /// <param name="LastActiveParam">Date Time the user was last active on the system</param>
        /// <param name="IsLockedParam">True if the user is locked out of the system and not allowed to log in</param>
        /// <param name="EmailAddressParam">Email Address to contact the user</param>
        public UserDTO_old(string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base()
        {
            this.Username = UsernameParam;
            this.Password = PasswordParam;
            this.LastActive = LastActiveParam;
            this.IsLocked = IsLockedParam;
            this.EmailAddress = EmailAddressParam;
        }

        /// <summary>
        /// Initialise a user DTO_old
        /// </summary>
        /// <param name="IDParam">ID of the User</param>
        /// <param name="UsernameParam">Unique Username for user</param>
        /// <param name="PasswordParam">Unique Password for user</param>
        /// <param name="LastActiveParam">Date Time the user was last active on the system</param>
        /// <param name="IsLockedParam">True if the user is locked out of the system and not allowed to log in</param>
        /// <param name="EmailAddressParam">Email Address to contact the user</param>
        public UserDTO_old(int IDParam, string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(IDParam)
        {
            this.Username = UsernameParam;
            this.Password = PasswordParam;
            this.LastActive = LastActiveParam;
            this.IsLocked = IsLockedParam;
            this.EmailAddress = EmailAddressParam;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Email Address for contacting the user
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        /// <summary>
        /// Determines if the users account has been locked, preventing them from logging in
        /// </summary>
        public bool IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }

        /// <summary>
        /// Date Time that the user performed an action on the system
        /// </summary>
        public DateTime LastActive
        {
            get { return lastActive; }
            set { lastActive = value; }
        }

        /// <summary>
        /// Password for the user to confirm identification
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Unique username of the user which allows the user to log in
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        #endregion
    }
}
