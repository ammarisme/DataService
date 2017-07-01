using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFALibrary.Common;

namespace SFALibrary.Domain
{
    [FileName("DCSLUSER")]
    [Serializable()]
    public class User
    {
        private string epfNumber = string.Empty;
        private string userId = string.Empty;
        private string userFullName = string.Empty;
        private string password = string.Empty;
        private string userLevel = string.Empty;
        private string locationId= string.Empty;

        [DBField("EPFNUM" )]
        public string EpfNumber { get { return epfNumber; } set { epfNumber = value.Trim(); } }
        [DBField("USERID")]
        [PrimaryKey]
        public string UserId { get { return userId; } set { userId = value.Trim(); } }
        [DBField("USRNAME")]
        public string UserFullName { get { return userFullName; } set { userFullName = value.Trim(); } }
        [DBField("MAINPASS")]
        public string Password { get { return password; } set { password = value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId = value.Trim(); } }
        [DBField("USRLV")]
        public string UserLevel { get { return userLevel; } set { userLevel = value.Trim(); } }
        public Location _Location { get; set; }
    }
}
