using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("ALCMETR")]
    public class AlcoholoMetric
    {
        private decimal density ;
        private decimal temperature ;
        private decimal strength ;

        [DBField("DENSITY")]
        [PrimaryKey]
        public decimal Density { get { return density; } set { density = value; } }
        [DBField("TEMPRT")]
        public decimal Temperature { get { return temperature; } set { temperature= value; } }
        [DBField("STRENG")]
        public decimal Strength { get { return strength; } set {strength=value; } }
        
    }
}
