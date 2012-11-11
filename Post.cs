using System.Collections.Generic;
using DomainModel.Classes;

namespace DomainModel
{
    public class Post : BaseFieldsTables
    {
        public virtual ICollection<Comment> Comments { get; set; }
    }
}