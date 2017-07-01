using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("VATGAG")]
    public class GaugedVat
    {
        private decimal lowerBound;
        private decimal upperBound;
        private decimal volume;
        private string containerId;
        private decimal variance;

        [DBField("COTID")]
        public string ContainerId { get { return containerId; } set { containerId= value; } }
        [DBField("LOBOND")]
        public decimal LowerBound { get { return lowerBound; } set { lowerBound= value; } }
        [DBField("UPBOND")]
        public decimal UpperBound { get { return upperBound; } set { upperBound= value; } }
        [DBField("VOLUM")]
        public decimal Volume { get { return volume; } set { volume = value; } }
        [DBField("VARIAN")]
        public decimal Variance { get { return variance; } set { variance= value; } }
    }
}
