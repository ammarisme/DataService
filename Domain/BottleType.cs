using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("BTLTYPE")]
    public class BottleType
    {
        private string id;
        private string bottleName = string.Empty;
        private decimal capacity;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("BTNAME")]
        public string BottleName { get { return bottleName; } set { bottleName = value.Trim(); } }
        [DBField("CCITY")]
        public decimal Capacity { get { return capacity; } set { capacity = value; } }
    }
}
