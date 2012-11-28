using System;
using System.Collections.Generic;
using DomainModel.Classes;

namespace DomainModel
{
    public class Post : BaseFieldsTables
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public Access Access { get; set; }
        public bool EnableComment { get; set; }
        public bool FeaturePiture { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}