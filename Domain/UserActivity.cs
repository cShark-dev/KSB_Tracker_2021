using System;

namespace Domain
{
    public class UserKsb
    {
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid ActivityId { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsHost { get; set; }
    }
}