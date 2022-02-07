using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendtByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendtByUsername;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL ,this.SendByUsername);
        }

    }
}
