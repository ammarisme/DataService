using SFALibrary.Common;
using System;

namespace SFALibrary.Domain
{
    [Serializable()]
    public class Solute
    {
        private string id = string.Empty;
        
        [DBField("ID")]
        [PrimaryKey]
        public string Id { get {return id; } set { id=value.Trim() ; } }
    }
}
