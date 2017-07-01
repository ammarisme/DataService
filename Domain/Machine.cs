using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("MACHINE")]
    public class Machine
    {
        private decimal id;
        private string status;
        private string machineName;
        private string locationId = string.Empty;
        private string machineType = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public decimal Id { get {return id; } set { id=value; } }
        [DBField("STATUS")]
        public string Status { get { return status; } set { status = value.Trim(); } }
        [DBField("MCNAME")]
        public string MachineName { get { return machineName; } set { machineName= value.Trim(); } }
        [DBField("MTYPE")]
        public string MachineType { get { return machineType; } set { machineType= value.Trim(); } }
        [DBField("LOCID")]
        public string LocationId { get { return locationId; } set { locationId = value.Trim(); } }
    }
}

    