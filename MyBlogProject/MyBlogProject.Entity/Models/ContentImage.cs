﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Entity.Models
{
    public class ContentImage
    {

        public int Id { get; set; }
        public int ContentId { get; set; }
        public int ImageId { get; set; }
    }
}
