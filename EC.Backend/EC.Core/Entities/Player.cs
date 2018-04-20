using System;
using System.Collections.Generic;

namespace EC.Core.Entities
{
    public class Player : BaseEntity
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}
