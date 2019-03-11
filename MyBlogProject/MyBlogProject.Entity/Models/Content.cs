using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Entity.Models
{
    public class Content
    {

        public int Id { get; set; }
        public string ContentHeader { get; set; }
        public string ContentBody { get; set; }
        public int ContentTypeId { get; set; }
        public int ContentImageId { get; set; }
        public int ContentTagId { get; set; }
        public virtual ICollection<ContentImage> ContentImages { get; set; }
        public virtual ICollection<ContentTag> ContentTags { get; set; }


    }
}
