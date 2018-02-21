using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.People.Users
{
    public class StudyMonitorDTO : UserDTO
    {
        #region Constructors

        public StudyMonitorDTO()
            : base()
        {

        }

        public StudyMonitorDTO(string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        public StudyMonitorDTO(int IDParam, string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(IDParam, UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        #endregion
    }
}
