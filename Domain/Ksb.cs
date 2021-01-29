using System;
using System.Collections.Generic;

namespace Domain
{
    public class Ksb
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Faculty { get; set; }
        public string Supervisor { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}



