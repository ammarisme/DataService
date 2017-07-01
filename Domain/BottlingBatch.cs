using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("BOTBAT")]
    public class BottlingBatch
    {
        private decimal id;
        private string bottleQuantity;
        private string plantId;
        private string containerId;
        private string measurementId;
        private decimal volume;
        private string bottleType;
        
        [DBField("ID")]
        [PrimaryKey]
        public decimal Id { get {return id; } set { id=value; } }
        [DBField("BTLQTY")] 
        public string BottleQuantity  { get { return bottleQuantity; } set { bottleQuantity = value.Trim(); } }
        [DBField("PLANTI")]
        public string PlantId { get { return plantId; } set { plantId = value.Trim(); } }
        [DBField("CONTID")]
        public string ContainerId { get { return containerId; }  set { containerId = value.Trim(); } }
        [DBField("MESURE")]
        public string MeasurementId { get { return measurementId; }  set { measurementId = value.Trim(); } }
        [DBField("VOLUME")]
        public decimal Volume { get { return volume; }  set { volume = value; } }
        [DBField("BTLTYPE")]
        public string BottleType { get { return bottleType; } set { bottleType = value.Trim(); } }
    }
}
