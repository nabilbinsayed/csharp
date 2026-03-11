using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMed
{
    class VideoPost : Post
    {
        public string VideoURL { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL)
        {
            this.ID = GetNextID();
            this.Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            this.VideoURL = videoURL;

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.SendByUsername} - {this.VideoURL}");
        }

    }
}