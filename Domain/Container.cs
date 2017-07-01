using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("CONTAIN")]
    public class Container
    {
        private string containerId = string.Empty;
        private string containerName = string.Empty;
        private decimal capacityWeight;
        private decimal capacityVolume;
        private string status = string.Empty;
        private decimal minDepth;
        private decimal maxDepth;
        private decimal minVolume;
        private decimal maxVolume;
        private decimal minWeight;
        private decimal maxWeight;
        private decimal fillVolume;
        private decimal pureVolume;
        private decimal fillWeight;
        private decimal currentDepth;
        private string containerType = string.Empty;
        private string locationId = string.Empty;
        private string vatRoomId = string.Empty;
        private string liquidTypeId = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return containerId; } set { containerId=value.Trim() ; } }
        [DBField("CONAME")]
        public string ContainerName { get { return containerName; } set { containerName = value.Trim(); } }
        [DBField("CWEIGT")]
        public decimal CapacityWeight { get { return capacityWeight; } set { capacityWeight=value; } }
        [DBField("CVOLUM")]
        public decimal CapacityVolume { get { return capacityVolume; } set { capacityVolume = value; } }
        [DBField("STATUS")]
        public string Status { get { return status; } set {status=value.Trim(); } }
        [DBField("MINDEP")]
        public decimal MinimumDepth { get { return minDepth; } set { minDepth= value; } }
        [DBField("MAXDEP")]
        public decimal MaximumDepth { get { return maxDepth; } set { maxDepth= value; } }
        [DBField("MINVOL")]
        public decimal MinimumVolume { get { return minVolume; } set { minVolume= value; } }
        [DBField("MAXVOL")]
        public decimal MaximumVolume { get { return maxVolume; } set { maxVolume= value; } }
        [DBField("MINWEI")]
        public decimal MinimumWeight { get { return minWeight ; } set { minWeight = value; } }
        [DBField("MAXWEI")]
        public decimal MaximumWeight { get { return maxWeight; } set { maxWeight = value; } }
        [DBField("COTYPE")]
        public string ContainerType { get { return containerType; } set { containerType = value.Trim(); } }
        [DBField("FILVOL")]
        public decimal FilledVolume { get { return fillVolume; } set { fillVolume= value; } }
        [DBField("PUREVOL")]
        public decimal PureVolume { get { return pureVolume; } set { pureVolume= value; } }
        [DBField("FILWEI")]
        public decimal FilledWeight { get { return fillWeight; } set { fillWeight= value; } }
        [DBField("CURDEP")]
        public decimal CurrentDepth { get { return currentDepth; } set { currentDepth = value; } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId= value.Trim(); } }
        [DBField("VATRID")]
        public string VatRoomId { get { return vatRoomId; } set { vatRoomId = value.Trim(); } }
        [DBField("LIQTYPE")]
        public string LiquidTypeId { get { return liquidTypeId; } set { liquidTypeId= value.Trim(); } }
        
    }
}
