using System;
using System.Collections.Generic;
using DomainModel.Classes;

namespace DomainModel
{
	public class Post : BaseFieldsTables
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime PublishDate { get; set; }
		public Access Accesses { get; set; }
		public bool EnableComment { get; set; }
		public string FeaturePiture { get; set; }
		public virtual ICollection<Tag> Tags { get; set; }
		public virtual ICollection<Comment> Comments { get; set; }
		public virtual ICollection<Category> Categories { get; set; }
	}
}