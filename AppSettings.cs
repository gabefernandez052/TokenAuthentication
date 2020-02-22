using System.Collections.Generic;

namespace TokenAuthentication
{
    public class AppSettings
    {
        public IEnumerable<UserInfo> Users { get; set; }

        public string AuthenticationSecret { get; set; }

        public class UserInfo
        {
            public string User { get; set; }
            public string Value { get; set; }
        }
    }
}