using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class ImagePost:Post
    {
        public string ImageUrl { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string imageUrl, string uname):base(title, uname)
        {
            this.ID = getCurrentId();
            this.ImageUrl = imageUrl;
          
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title,this.ImageUrl, this.UserName);
        }
    }
}
