using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int currentPostID;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }    
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set;}

        //constructors
        public Post()
        {
            ID = 0;
            Title = "My first Post";
            IsPublic = true;
            SendByUserName = "Rick Fitch";
        }
        //new post
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }
        // increment ID
        protected int GetNextID()
        {
            return ++currentPostID;
        }
        // edit post
        public void UpdatePost(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        //Override the toString in Object Class
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }



    }
}
