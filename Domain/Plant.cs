using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("PLANT")]
    public class Plant
    {
        private string id;
        private string plantName = string.Empty;

        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim(); } }
        [DBField("PNAME")]
        public string PlantName { get { return plantName; } set { plantName = value.Trim(); } }
    }
}
