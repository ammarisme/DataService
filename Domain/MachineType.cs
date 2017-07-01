using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("MATYPE")]
    public class MachineType
    {
        private string id;
        private string typeName = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("TNAME")]
        public string TypeName { get { return typeName; } set { typeName = value.Trim(); } }
    }
}

