using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnes.dal.Domain
{
    public class User : BaseEntitity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Blog { get; set; }
        public ICollection<Blog> Blogs { get; set; }


    }
}
