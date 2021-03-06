﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.People.Users
{
    public class DataManager : User
    {
        #region Constructors

        public DataManager()
            : base()
        {

        }

        public DataManager(string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        public DataManager(int IDParam, string UsernameParam, string PasswordParam, DateTime LastActiveParam, bool IsLockedParam, string EmailAddressParam)
            : base(IDParam, UsernameParam, PasswordParam, LastActiveParam, IsLockedParam, EmailAddressParam)
        {

        }

        #endregion
    }
}
