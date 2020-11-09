using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnes.dal.Domain
{
    public class Blog : BaseEntitity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDateAndTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
