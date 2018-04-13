using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Core.Entities
{
    public class Player : BaseEntity
    {
        public PlayerInfo Information { get; set; }
        public List<Event> InvolvedEvents { get; set; }
    }
}
