using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("MEASUR")]
    public class ContainerCalculation
    {
        private string calculationId;
        private string containerId ;
        private decimal temperature ;
        private decimal density ;
        private decimal strength ;
        private string measurementTime ;
        private string liquidType ;
        private string solutionId;
        
        [DBField("ID")]
        [PrimaryKey]
        public string CalculationId { get {return calculationId; } set { calculationId=value; } }
        [DBField("SOLUID")]
        public string SolutionId { get { return solutionId; } set { solutionId  = value.Trim(); } }
        [DBField("COTID")]
        public string ContainerId { get { return containerId; } set { containerId=value; } }
        [DBField("TEMPRT")]
        public decimal Temperature { get {return temperature; } set { temperature = value; }  }
        [DBField("DENSITY")]
        public decimal Density { get { return density; } set { density= value; } }
        [DBField("STRENG")]
        public decimal Strength { get { return strength; }  set { strength= value; } }
        [DBField("MSTIME")]
        public string CalculationTime { get { return measurementTime; } set { measurementTime= value.Trim(); } }
        [DBField("LTYPE")]
        public string LiquidType { get { return liquidType; } set { liquidType = value.Trim(); } }
    }
}