using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("LOCTRANS")]
    public class LocationTransfer
    {
        private string id ;
        private string liquidTypeName;
        private string fromLocationId;
        private string toLocationId;
        private string vehicleId;
        private string solutionMeasurementId;
        private decimal weight;
        private decimal volume;
        private string driverId;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("TYNAME")]
        public string LiquidType { get { return liquidTypeName; }  set { liquidTypeName = value.Trim(); } }
        [DBField("FRLOCI")]
        public string FromLocationId { get { return fromLocationId; } set { fromLocationId = value.Trim(); } }
        [DBField("TOLOCI")]
        public string ToLocationId { get { return toLocationId; } set { toLocationId = value.Trim(); } }
        [DBField("VEHICID")]
        public string VehicleId { get { return vehicleId; } set { vehicleId = value.Trim(); } }
        [DBField("MESURE")]
        public string SolutionMeasurementId { get { return solutionMeasurementId; }  set { solutionMeasurementId = value.Trim(); } }
        [DBField("WEIGHT")]
        public decimal Weight { get { return weight; } set { weight = value; } }
        [DBField("VOLUME")]
        public decimal Volume { get { return volume; }  set { volume = value; } }
        [DBField("DRIVID")]
        public string DriverId { get { return driverId; }  set { driverId = value.Trim(); } }
    }
}
