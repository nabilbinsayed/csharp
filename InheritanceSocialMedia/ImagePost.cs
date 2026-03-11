using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMed
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, bool isPublic, string imageURL)
        {
            this.ID = GetNextID();
            this.Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            this.ImageURL = imageURL;

        }
        
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendByUsername} - {this.ImageURL}");
        }

    }
}