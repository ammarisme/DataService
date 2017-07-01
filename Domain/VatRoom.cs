using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    public class VatRoom
    {
        private string vatRoomId = string.Empty;
        private string vatRoomName = string.Empty;
        private string locationId = string.Empty;

        [DBField("VRMID")]
        [PrimaryKey]
        public string VatRoomId { get {return vatRoomId; } set { vatRoomId=value.Trim() ; } }
        [DBField("VRMNM")]
        public string VatRoomName{ get { return vatRoomName; } set { vatRoomName=value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; }  set { locationId= value.Trim(); } }

        public Location _Location { get; set; }
        public VatRoom _VatRoom { get; set; }
    }
}
