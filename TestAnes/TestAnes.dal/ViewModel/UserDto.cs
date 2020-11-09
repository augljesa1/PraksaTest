using System;
using System.Collections.Generic;
using System.Text;
using TestAnes.dal.Domain;

namespace TestAnes.dal.ViewModel
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Blog { get; set; }
        public UserDto() { }
        public UserDto(User User)
        {
            Id = User.Id;
            Name = User.Name;
            Email = User.Email;
            Age = User.Age;
            Blog = User.Blog;
        }

    }
}
