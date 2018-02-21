using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.People.Users
{
    public class StudyMonitorDTO_old : UserDTO_old
    {
        #region Constructors

        public StudyMonitorDTO_old()
            : base()
        {

        }

        public StudyMonitorDTO_old(string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        public StudyMonitorDTO_old(int IDParam, string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(IDParam, UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        #endregion
    }
}
