using System.Security.Cryptography.X509Certificates;

namespace Visualization
{
    class GlobalClass
    {
        public struct User
        {
            public string strUsrId;
            public string strUsrName;
            public bool isSuperAccount;
        };
        public static User user;
    }
}
