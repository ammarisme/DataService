using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("COTRANS")]
    public class MachineContainerTransfer
    {
        private string id = string.Empty;
        private string containerId = string.Empty;
        private string distillationMachineId = string.Empty;
        private decimal containerFromDepth;
        private decimal containerToDepth;
        private decimal transferVolume;
        private string status = string.Empty;
        private decimal temperature;
        private decimal strength;
        private decimal density;
        private string createdUser = string.Empty;
        private string outputTime = string.Empty;
        private decimal transferPureVolume;
        private decimal transferWeight;
        private string liquidTypeId = string.Empty;
        private string distillationId = string.Empty;
        private string locationId = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("COTID")]
        public string ContainerId { get { return containerId; } set { containerId= value.Trim(); } }
        [DBField("DSTLID")]
        public string DistillationId { get { return distillationId; } set { distillationId = value.Trim(); } }
        [DBField("DMACHN")]
        public string DistillationMachineId { get { return distillationMachineId; } set { distillationMachineId = value.Trim(); } }
        [DBField("COFRDEP")]
        public decimal ContainerFromDepth { get { return containerFromDepth; } set { containerFromDepth= value; } }
        [DBField("COTODEP")]
        public decimal ContainerToDepth { get { return containerToDepth; } set { containerToDepth= value; } }
        [DBField("VOLUME")]
        public decimal TransferVolume { get { return transferVolume; } set { transferVolume= value; } }
        [DBField("PURVOL")]
        public decimal TransferPureVolume { get { return transferPureVolume; } set { transferPureVolume = value; } }
        [DBField("WEIGHT")] 
        public decimal Weight { get { return transferWeight; } set { transferWeight = value; } }
        [DBField("STATUS")]
        public string Status{ get { return status; } set { status= value.Trim(); } }
        [DBField("TEMPRT")]
        public decimal Temperature { get { return temperature; } set { temperature = value; } }
        [DBField("DENST")]
        public decimal Density { get { return density; } set { density= value; } }
        [DBField("STRNG")]
        public decimal Strength { get { return strength; } set { strength= value; } }
        [DBField("OUTIME")]
        public string OutputTime { get { return outputTime; } set { outputTime = value.Trim(); } }
        [DBField("LIQTYPE")]
        public string LiquidTypeId { get { return liquidTypeId; } set { liquidTypeId = value.Trim(); } }
        [DBField("CUSER")]
        public string CreatedUser { get { return createdUser; } set { createdUser = value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId = value.Trim(); } }

    }
}