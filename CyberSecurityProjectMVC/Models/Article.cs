using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSecurityProjectMVC.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
