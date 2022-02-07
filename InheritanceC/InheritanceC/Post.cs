using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;

        // propoerites
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        //Default constructor
        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Daniel";
        }

        // Instance constructor
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}
