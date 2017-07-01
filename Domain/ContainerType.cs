using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("COTYPE")]
    public class ContainerType
    {
        private string typeCode = string.Empty;
        private string superType = string.Empty;
        private string typeName= string.Empty;
        
        [DBField("TYCOD")]
        [PrimaryKey]
        public string TypeCode { get {return typeCode; } set { typeCode=value.Trim() ; } }
        [DBField("SUTYP")]
        public string SuperType { get { return superType; } set { superType=value.Trim(); } }
        [DBField("TNAME")]
        public string TypeName { get { return typeName; } set { typeName= value.Trim(); } }
    }
}
