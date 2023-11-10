using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class ImagePost: Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, bool isPublic, string imageUrl)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            this.ImageUrl = imageUrl;         

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - Image at {3} ", this.ID, this.Title, this.SendByUserName, this.ImageUrl);
        }
    }
}
