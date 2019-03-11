using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Entity.Models
{
    public class ContentTag
    {

        public int Id { get; set; }
        public int ContentId { get; set; }
        public int TagId { get; set; }
    }
}
