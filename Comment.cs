using System.Collections.Generic;
using DomainModel.Classes;

namespace DomainModel
{
    public class Comment : BaseFieldsTables
    {
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public virtual Comment Reply { set; get; }
        public int? ReplyId { get; set; }
        public ICollection<Comment> Children { get; set; }
    }
}