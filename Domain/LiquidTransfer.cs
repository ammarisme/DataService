using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("LIQTRNS")]
    public class LiquidTransfer
    {
        private string id = string.Empty;
        private decimal sourceWeight ;
        private decimal sourceBulkVolume;
        private decimal sourcePureVolume;
        private decimal destinationPureVolume;
        private string transferTime = string.Empty;
        private decimal sourceDepthFrom;
        private decimal sourceDepthTo;
        private decimal destinationDepthFrom;
        private decimal destinationDepthTo;
        private string fromContainer = string.Empty;
        private string toContainer = string.Empty;
        private decimal destinationTemperature;
        private decimal destinationStrength;
        private decimal destinationDensity;
        private decimal sourceTemperature;
        private decimal sourceStrength;
        private decimal sourceDensity;
        private string liquidTypeId = string.Empty;
        private string transferType = string.Empty;
        private string createdUser = string.Empty;
        private decimal wastage;
        private decimal destinationWeight;
        private decimal destinationBulkVolume;
        private string locationId = string.Empty;
        private string status = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("TTIME")]
        public string TransferTime { get { return transferTime; } set { transferTime= value.Trim(); } }
        [DBField("WASTGE")]
        public decimal Wastage { get { return wastage; } set { wastage = value; } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId = value.Trim(); } }

        [DBField("LTYPE")]
        public string LiquidType { get { return liquidTypeId; } set { liquidTypeId = value.Trim(); } }
        [DBField("TTYPE")]
        public string TransferType { get { return transferType; } set { transferType = value.Trim(); } }
        [DBField("CUSER")]
        public string CreatedUser { get { return createdUser; } set { createdUser = value.Trim(); } }

        [DBField("STATUS")]
        public string Status { get { return status; } set { status = value.Trim(); } }


        #region Source
        [DBField("WEIGHT")]
        public decimal SourceWeight { get { return sourceWeight; } set { sourceWeight = value; } }
        [DBField("VOLUME")]
        public decimal SourceBulkVolume { get { return sourceBulkVolume; } set { sourceBulkVolume = value; } }
        [DBField("SPURVOL")]
        public decimal SourcePureVolume { get { return sourcePureVolume; } set { sourcePureVolume = value; } }
        [DBField("FCOTID")]
        public string FromContainer { get { return fromContainer; } set { fromContainer = value.Trim(); } }

        [DBField("SODEPF")]
        public decimal SourceDepthFrom { get { return sourceDepthFrom; } set { sourceDepthFrom= value; } }
        [DBField("SODEPT")]
        public decimal SourceDepthTo { get { return sourceDepthTo; } set { sourceDepthTo = value; } }

        [DBField("FTEMPR")]
        public decimal SourceTemperature { get { return sourceTemperature; } set { sourceTemperature = value; } }
        [DBField("FDENST")]
        public decimal SourceDensity { get { return sourceDensity; } set { sourceDensity = value; } }
        [DBField("FSTRNG")]
        public decimal SourceStrength { get { return sourceStrength; } set { sourceStrength = value; } }
        #endregion

        #region Destination
        [DBField("TCOTID")]
        public string ToContainer { get { return toContainer; } set { toContainer= value.Trim(); } }

        [DBField("TTEMPR")]
        public decimal DestinationTemperature { get { return destinationTemperature; } set { destinationTemperature = value; } }
        [DBField("TDENST")]
        public decimal DestinationDensity { get { return destinationDensity; } set { destinationDensity= value; } }
        [DBField("TSTRNG")]
        public decimal DestinationStrength { get { return destinationStrength; } set { destinationStrength = value; } }

        [DBField("DEDEPF")]
        public decimal DestinationDepthFrom { get { return destinationDepthFrom; } set { destinationDepthFrom = value; } }
        [DBField("DEDEPT")]
        public decimal DestinationDepthTo { get { return destinationDepthTo; } set { destinationDepthTo = value; } }
        [DBField("DWEIGT")]
        public decimal DestinationWeight { get { return destinationWeight; } set { destinationWeight = value; } }
        [DBField("DVOLUM")]
        public decimal DestinationBulkVolume { get { return destinationBulkVolume; } set { destinationBulkVolume = value; } }
        [DBField("DPURVOL")]
        public decimal DestinationPureVolume { get { return destinationPureVolume; } set { destinationPureVolume = value; } }
        #endregion

        public Container _FromContainer { get; set; }
        public Container _ToContainer { get; set; }
    }
}