﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPassword
{
    [Serializable]  //表示这个类可以被序列化
    public class User
    {
        string _loginName;
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        string _loingPassword;
        public string LoingPassword
        {
            get
            {
                if (_loingPassword != "")
                    return MyEncrypt.DecryptDES(_loingPassword);
                return _loingPassword;
            }
            set { _loingPassword = value; }
        }

        public User(string loginName, string loginPwd)
        {
            _loginName = loginName;
            _loingPassword = loginPwd;
        }
    }
}

