using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_olds.People.Users
{
    public class StudyCoordinatorDTO_old : UserDTO_old
    {
        #region Constructors

        public StudyCoordinatorDTO_old()
            : base()
        {

        }

        public StudyCoordinatorDTO_old(string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        public StudyCoordinatorDTO_old(int IDParam, string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(IDParam, UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        #endregion
    }
}
