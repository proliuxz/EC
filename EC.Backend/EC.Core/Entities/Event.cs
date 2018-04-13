using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Core.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public Player player { get; set; }
        public List<Player> Players { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EventStatus Status { get; set; }
    }

    public enum EventStatus {
        Canceled = 0,
        Pending = 1,
        Processing = 2,
        Finished = 3,
    }
}
