using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Core.Entities
{
    public class PlayerInfo : BaseEntity
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}
