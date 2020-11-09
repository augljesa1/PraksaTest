using System;
using System.Collections.Generic;
using System.Text;
using TestAnes.dal.Domain;

namespace TestAnes.dal.ViewModel
{
    public class BlogDto
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDateAndTime { get; set; }

        public BlogDto(){
        }
        public BlogDto(Blog Blog)
        {
            Title = Blog.Title;
            Summary = Blog.Summary;
            Content = Blog.Content;
            PublishedDateAndTime = Blog.PublishedDateAndTime;
        }
    }
}
