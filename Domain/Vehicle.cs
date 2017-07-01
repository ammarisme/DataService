using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("VEHICLE")]
    public class Vehicle
    {
        private string id;
        private string vehicleName = string.Empty;
        private decimal capacity;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("VNAME")]
        public string VehicleName { get { return vehicleName; } set { vehicleName = value.Trim(); } }
        [DBField("CCITY")]
        public decimal Capacity { get { return capacity; } set { capacity = value; } }
    }
}
