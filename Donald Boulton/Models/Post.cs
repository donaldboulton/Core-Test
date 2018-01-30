using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Donald_Boulton.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Category { get; set; }
        public string CategoryImg { get; set; }
    }
}
