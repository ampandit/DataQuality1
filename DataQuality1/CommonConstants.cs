using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humana.IMA.DataMarketplace.Common.Core.Constants
{
    public sealed class CommonConstants
    {
        public sealed class Encryption
        {
            public const string Salt = "837";
            public const string Key = "-=!@#$%^&*()=-";
        }

        public sealed class PodiumRequestPaths
        {
            public const string GetEntitiesByCrit = "entity/v1/getEntitiesByCrit/6/";
            public const string Login = "j_spring_security_check";
            public const string Logout = "j_spring_security_logout";
        }

        public sealed class SessionCookieKey
        {
            public const string CookieBase = "PodiumCookienBase";
            public const string SessionId = "PodiumSession";
        }

        public const int PageSizeForResults = 6;
    }
}
