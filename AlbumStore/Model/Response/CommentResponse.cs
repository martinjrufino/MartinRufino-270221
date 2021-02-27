using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Model.Response
{
    public class CommentResponse
    {
        public CommentResponse(List<Comment> commentLst)
        {
            this.commentLst = commentLst;
        }

        public List<Comment> commentLst { get; set; }
    }
}
