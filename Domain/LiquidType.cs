using SFALibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFALibrary.Domain
{
    [Serializable()]
    [FileName("LIQTYPE")]
    public class LiquidType
    {
        private string liquidTypeId= string.Empty;
        private string liquidName = string.Empty;
        
        [DBField("ID")]
        [PrimaryKey]
        public string LiquidTypeId { get {return liquidTypeId; } set { liquidTypeId = value.Trim() ; } }
        [DBField("LIQNAM")]
        public string LiquidName{ get { return liquidName; } set { liquidName = value.Trim(); } }
    }
}
