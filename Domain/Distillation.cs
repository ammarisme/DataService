using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("DISLATE")]
    public class Distillation
    {
        private string id = string.Empty;
        private string startTime = string.Empty;
        private string endTime = string.Empty;
        private string containerId = string.Empty;
        private string machineId = string.Empty;
        private decimal inputGrossVolume;
        private decimal outputGrossVolume;
        private decimal inputPureVolume;
        private decimal outputPureVolume;
        private string status = string.Empty;
        private string solutionMeasurementId = string.Empty;
        private decimal containerFromDepth;
        private decimal containerToDepth;
        private string distillationType = string.Empty;
        private string liquidTypeId = string.Empty;
        private string createdUser= string.Empty;
        private string locationId = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("DSTIME")]
        public string StartTime { get { return startTime; } set { startTime = value.Trim(); } }
        [DBField("DETIME")]
        public string EndTime{ get { return endTime; } set {endTime = value.Trim(); } }
        [DBField("DTYPE")]
        public string DistillationType{ get { return distillationType; }  set { distillationType = value.Trim(); } }
        [DBField("CONTID")]
        public string ContainerId{ get { return containerId; } set { containerId = value.Trim(); } }
        [DBField("DMACHN")]
        public string MachineId{ get { return machineId; } set { machineId = value.Trim(); } }
        [DBField("INGVOL")]
        public decimal InputGrossVolume{ get { return inputGrossVolume; } set { inputGrossVolume = value; } }
        [DBField("OUGVOL")]
        public decimal OutputGrossVolume{ get { return outputGrossVolume; } set { outputGrossVolume = value; } }
        [DBField("INPVOL")]
        public decimal InputPureVolume{ get { return inputPureVolume; } set { inputPureVolume= value; } }
        [DBField("OUPVOL")]
        public decimal OutputPureVolume{ get { return outputPureVolume; } set { outputPureVolume = value; } }
        [DBField("STATUS")]
        public string Status { get { return status; } set { status = value.Trim(); } }
        [DBField("SMEASR")]
        public string SolutionMeasurementId{ get { return solutionMeasurementId; } set { solutionMeasurementId = value.Trim(); } }
        [DBField("CFRDEP")]
        public decimal ContainerFromDepth{ get { return containerFromDepth; } set { containerFromDepth = value; } }
        [DBField("CTODEP")]
        public decimal ContainerToDepth{ get { return containerToDepth; } set { containerToDepth = value; } }
        [DBField("LTYPE")]
        public string LiquidTypeId{ get { return liquidTypeId; } set { liquidTypeId = value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId= value.Trim(); } }
        [DBField("CUSER")]
        public string CreatedUser { get { return createdUser; } set { createdUser= value.Trim(); } }
    }
}
