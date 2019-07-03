using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class CommentsViewModel
    {
        public List<Content> Contents { get; set; }
        public Content Content { get; set; }
    }
}
