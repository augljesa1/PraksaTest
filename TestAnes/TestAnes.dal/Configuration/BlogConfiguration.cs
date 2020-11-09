using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestAnes.dal.Domain;

namespace TestAnes.dal.Configuration
{
    public class BlogConfiguration : BaseEntitityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.User)
                .WithMany(p => p.Blogs)
                .HasForeignKey(p => p.UserId);

            //builder.HasData(new Blog[]
            //{
            //    new Blog{
            //        Id = 1,
            //        Title = "Neki naslov",
            //        Summary = "this is a car blog",
            //        Content = "about cars",
            //        PublishedDateAndTime = new DateTime(2020, 9, 11),

            //    },
            //    new Blog{
            //        Id = 2,
            //        Title = "Neki naslov",
            //        Summary = "this is a car blog",
            //        Content = "about cars",
            //        PublishedDateAndTime = new DateTime(2020, 9, 11),
            //    },


            //    new Blog{
            //        Id = 3,
            //        Title = "Neki naslov",
            //        Summary = "this is a car blog",
            //        Content = "about cars",
            //        PublishedDateAndTime = new DateTime(2020, 9, 11)
            //    },

            //    new Blog{
            //        Id = 4,
            //        Title = "Neki naslov",
            //        Summary = "this is a car blog",
            //        Content = "about cars",
            //        PublishedDateAndTime = new DateTime(2020, 9, 11),
            //    }
            //});
        }
    }
}
