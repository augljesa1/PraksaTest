using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestAnes.dal.Domain;

namespace TestAnes.dal.Configuration
{
    public class UserConfiguration : BaseEntitityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);



            //builder.HasData(new User[]
            //{
            //    new User{
            //        Id = 1,
            //        Name = "Anes Uglješa",
            //        Email = "augljesa1@etf.unsa.ba",
            //        Age = 23,
            //        Blog = 6,
            //    },
            //    new User{
            //        Id = 2,
            //        Name = "Habib Sarajlić",
            //        Email = "hsarajelic1@etf.unsa.ba",
            //        Age = 23,
            //        Blog = 8,
            //    },
            //    new User{
            //        Id = 3,
            //        Name = "Elmin Sejdić",
            //        Email = "esejddic1@etf.unsa.ba",
            //        Age = 24,
            //        Blog = 2,
            //    },
            //    new User{
            //        Id = 4,
            //        Name = "Almedina Kerla",
            //        Email = "akerla1@etf.unsa.ba",
            //        Age = 23,
            //        Blog = 8,
            //    }
            //});
        }
    }
}
