using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("LOCATION")]
    public class Location
    {
        private string locationId;
        private string locationName = string.Empty;
        private string address = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string LocationId { get {return locationId; } set { locationId=value.Trim() ; } }
        [DBField("LOCNAM")]
        public string LocationName { get { return locationName; } set { locationName=value.Trim(); } }
        [DBField("ADDR")]
        public string Address { get { return address; }  set { address= value.Trim(); } }
        
    }
}
