using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("SINTAKE")]
    public class LiquidInput
    {
        private string id = string.Empty;
        private string containerId = string.Empty;
        private string inputDateTime = string.Empty;
        private decimal weight;
        private decimal bulkVolume;
        private decimal temperature;
        private decimal density;
        private decimal strength;
        private string remarks = string.Empty;
        private decimal pureVolume;
        private string liquidTypeId = string.Empty;
        private decimal fromDepth;
        private decimal toDepth;
        private string solutionId = string.Empty;
        private string createdUser = string.Empty;
        private string locationId = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("INDATE")]
        public string InputDateTime { get { return inputDateTime; } set { inputDateTime = value.Trim(); } }
        [DBField("WEIGHT")]
        public decimal Weight { get { return weight; } set { weight= value; } }
        [DBField("VOLUME")]
        public decimal BulkVolume { get { return bulkVolume; } set { bulkVolume = value; } }
        [DBField("TEMPRT")]
        public decimal Temperature { get { return temperature; } set { temperature= value; } }
        [DBField("DENSITY")]
        public decimal Density { get { return density; } set { density= value; } }
        [DBField("STRENG")]
        public decimal Strength { get { return strength; } set { strength= value; } }
        [DBField("SOLUID")]
        public string SolutionId { get { return solutionId; } set { solutionId = value.Trim(); } }
        [DBField("LIQNAM")]
        public string Remarks { get { return remarks; } set { remarks = value.Trim(); } }
        [DBField("PUREVOL")]
        public decimal PureVolume { get { return pureVolume; } set { pureVolume = value; } }
        [DBField("CONTID")]
        public string ContainerId { get { return containerId; } set { containerId= value.Trim(); } }
        [DBField("LIQTYPE")]
        public string LiquidTypeId { get { return liquidTypeId; } set { liquidTypeId = value.Trim(); } }
        [DBField("FRDEPTH")]
        public decimal FromDepth { get { return fromDepth; } set { fromDepth = value; } }
        [DBField("TODEPTH")]
        public decimal ToDepth { get { return toDepth; } set { toDepth = value; } }
        [DBField("CUSER")]
        public string CreatedUser { get { return createdUser; } set { createdUser= value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId = value.Trim(); } }
    }
}
